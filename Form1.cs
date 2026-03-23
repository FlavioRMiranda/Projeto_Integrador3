using Draft;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_Integrador3
{
    public partial class Form1 : Form
    {
        private string senhaJogadorCriador;
        private int idJogadorCriador;
        private int idJogadorAtual;
        private string senhaJogadorAtual;
        private string GRUPO = "Fossilizados";
        private string jogadorDaVez;
        private string nomeJogadorDaVez;
        private string regraAtual;
        private int idJogador;
        private string senhaJogador;

        public Form1()
        {
            InitializeComponent();
            labelGrupo.Text = GRUPO;
        }

        // ==========================
        // Função auxiliar Prompt
        // ==========================
        public string Prompt(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 10, Top = 20, Text = text, AutoSize = true };
            TextBox inputBox = new TextBox() { Left = 10, Top = 50, Width = 260 };
            Button confirmation = new Button() { Text = "OK", Left = 200, Width = 70, Top = 80, DialogResult = DialogResult.OK };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmation);

            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : "";
        }

        
        private void buttonEquipe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Equipe: SeuNomeOuGrupo");
        }
        private void buttonVersao_Click(object sender, EventArgs e)
        {
            try
            {
                string versao = Jogo.versao;

                MessageBox.Show("Versão da DLL: " + versao);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        // ==========================
        // CRIAR PARTIDA
        // ==========================

        private void buttonCriarPartida_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = textBoxNomePartida.Text.Trim();
                string senha = textBoxSenhaPartida.Text.Trim();

                // Validação
                if (nome.Length == 0)
                {
                    MessageBox.Show("Informe o nome da partida.");
                    return;
                }

                if (nome.Length > 15)
                {
                    MessageBox.Show("O nome da partida deve ter no máximo 15 caracteres.");
                    return;
                }

                if (senha.Length > 10)
                {
                    MessageBox.Show("A senha da partida deve ter no máximo 10 caracteres.");
                    return;
                }

                // 🔥 Chamada correta
                string retorno = Jogo.CriarPartida(nome, senha, GRUPO).Trim();

                // 🔍 Tenta interpretar como ID da partida
                if (int.TryParse(retorno, out int idPartida))
                {
                    MessageBox.Show("Partida criada com sucesso! ID: " + idPartida);

                    // Atualiza lista
                    AtualizarListaPartidas();
                }
                else
                {
                    // Se não for número, é erro vindo do servidor
                    MessageBox.Show("Erro ao criar partida: " + retorno);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        // ==========================
        // ATUALIZAR  PARTIDAS
        // ==========================
        private void AtualizarListaPartidas()
        {
            listBoxPartidas.Items.Clear();

            string partidasAbertas = Draft.Jogo.ListarPartidas("A");

            Console.WriteLine("Partidas abertas:");
            Console.WriteLine(partidasAbertas);

            string resposta = Jogo.ListarPartidas("T");
            string[] linhas = resposta.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string linha in linhas)
            {
                if (!string.IsNullOrWhiteSpace(linha))
                {
                    // Separar pelos campos da string: Id, Nome, Data, Status
                    string[] partes = linha.Split(',');
                    if (partes.Length >= 4)
                    {
                        string id = partes[0].Trim();
                        string nome = partes[1].Trim();
                        string data = partes[2].Trim();
                        string status = partes[3].Trim();

                        // Tradução do status
                        string descricaoStatus = status == "A" ? "Aberta" :
                                                 status == "E" ? "Encerrada" :
                                                 status == "J" ? "Jogando" :
                                                 status;

                        listBoxPartidas.Items.Add(
                            $"{id} - {nome} ({descricaoStatus})"
                        );
                    }
                }
            }
        }



        // ==========================
        // LISTAR  PARTIDAS
        // ==========================
        private void buttonListarPartidas_Click(object sender, EventArgs e)
        {
           

                AtualizarListaPartidas();
          
        }


        // ==========================
        // JOGAR
        // ==========================

        int Jogar(int idJogador, string senha, string codDino, string codCercado)
        {
            // Validação ANTES da chamada
            if (codDino.Length != 2 || codCercado.Length != 2)
            {
                MessageBox.Show("Código inválido. Deve ter 2 caracteres.");
                return -1; // padrão de erro
            }

            string resposta = Draft.Jogo.Jogar(idJogador, senha, codDino, codCercado);

            int proximoTurno;

            if (int.TryParse(resposta, out proximoTurno))
            {
                MessageBox.Show("Jogada realizada! Próximo turno: " + proximoTurno);
                return proximoTurno;
            }
            else
            {
                MessageBox.Show("Erro ao jogar: " + resposta);
                return -1; // erro
            }
        }

        private void buttonJogar_Click(object sender, EventArgs e)
        {
            string codDino = textBoxDino.Text.Trim().ToUpper();
            string codCercado = textBoxCercado.Text.Trim().ToUpper();

            // 🔍 Validação
            if (codDino.Length != 2 || codCercado.Length != 2)
            {
                MessageBox.Show("Os códigos devem ter exatamente 2 caracteres.");
                return;
            }

            // Validação de acordo com a regra (Face do Dado)
            if (regraAtual == "FL") // Floresta (Parte de Cima)
            {
                // Cercados da parte de cima: Floresta da Igualdade (FI), Rei da Selva (RS)
                if (codCercado != "FI" && codCercado != "RS" && codCercado != "MT" && codCercado != "IS")
                {
                    MessageBox.Show("Jogada Inválida! O dado mandou jogar na Floresta (Parte de cima do tabuleiro).");
                    return; // Cancela o envio
                }
            }
            else if (regraAtual == "PR") // Pradaria (Parte de Baixo)
            {
                // Cercados da parte de baixo: Pradaria do Amor (PA), Campina da Diferença (CD)
                if (codCercado != "PA" && codCercado != "CD" && codCercado != "RS")
                {
                    MessageBox.Show("Jogada Inválida! O dado mandou jogar na Pradaria (Parte de baixo do tabuleiro).");
                    return;
                }
            }
            else if (regraAtual == "AL") // Praça de Alimentação (Lado Esquerdo)
            {
                if (codCercado != "FI" && codCercado != "MT" && codCercado != "PA")
                {
                    MessageBox.Show("Jogada Inválida! O dado mandou jogar na Praça de Alimentação (Lado esquerdo).");
                    return;
                }
            }
            else if (regraAtual == "WC") // Banheiros (Lado Direito)
            {
                if (codCercado != "IS" && codCercado != "CD" && codCercado != "RS")
                {
                    MessageBox.Show("Jogada Inválida! O dado mandou jogar nos Banheiros (Lado direito).");
                    return;
                }
            }

            string resposta = Draft.Jogo.Jogar(idJogador, senhaJogador, codDino, codCercado);

            // 🔄 Tratamento da resposta
            if (int.TryParse(resposta, out int proximoTurno))
            {
                MessageBox.Show("Jogada realizada! Próximo turno: " + proximoTurno);

                // 👉 Atualiza o tabuleiro na tela logo após a jogada dar certo
                string meuTabuleiro = Draft.Jogo.ExibirTabuleiro(idJogador, senhaJogador);

                // Limpa a caixa e joga o texto original do servidor pulando as linhas corretamente
                textBoxTabuleiro.Clear();
                textBoxTabuleiro.Text = meuTabuleiro.Replace("\n", Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Erro: " + resposta);
            }
        }

        private void textBoxSenhaPartida_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        // ==========================
        // ENTRAR EM UMA  PARTIDA
        // ==========================


        private void buttonEntrarPartida_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBoxIdPartida.Text, out int idPartida))
                {
                    MessageBox.Show("ID da partida inválido.");
                    return;
                }

                string nomeJogador = this.nomeJogador.Text.Trim();
                string senhaPartida = this.senhaPartida.Text;

                if (nomeJogador.Length == 0 || nomeJogador.Length > 20)
                {
                    MessageBox.Show("Nome do jogador deve ter até 20 caracteres.");
                    return;
                }

                string resposta = Jogo.Entrar(idPartida, nomeJogador, senhaPartida);

                // DEBUG: ver exatamente o que o servidor retorna
                MessageBox.Show("Resposta do servidor: " + resposta);

                if (resposta.StartsWith("ERRO"))
                {
                   MessageBox.Show(resposta);
                    return;
                }
                string[] dados = resposta.Split(',');

                idJogador = int.Parse(dados[0].Trim());
                senhaJogador = dados[1].Trim();
               
                string caminho = Path.Combine(
                   Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                       "credenciais.txt"
                          );

           
                string conteudo =
                    "===== NOVO REGISTRO =====" + Environment.NewLine +
                   // "ID Jogador: " + (idJogador ?? "N/A") + Environment.NewLine +
                    "Nome: " + (nomeJogador ?? "N/A") + Environment.NewLine +
                    "Senha Jogador: " + (senhaJogador ?? "N/A") + Environment.NewLine +
                    "ID Partida: " + idPartida + Environment.NewLine +
                    "Senha Partida: " + (senhaPartida ?? "N/A") + Environment.NewLine +
                    "Data: " + DateTime.Now + Environment.NewLine +
                    "----------------------" + Environment.NewLine;

                File.AppendAllText(caminho, conteudo);

                labelIdJogador.Text = "ID Jogador: " + idJogador;
                labelSenhaJogador.Text = "Senha Jogador: " + senhaJogador;

                MessageBox.Show("Você entrou na partida!\nID do jogador: " + idJogador);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExibirJogadores(int idPartida)
        {
            listBoxJogadores.Items.Clear(); // limpa o ListBox

            // Aqui chamamos exatamente o método da documentação
            string jogadoresStr = Draft.Jogo.ListarJogadores(idPartida);

            // Cada linha da string vira um item no ListBox
            foreach (var linha in jogadoresStr.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                listBoxJogadores.Items.Add(linha);
            }
        }

        private void listBoxPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPartidas.SelectedItem == null) return;

            // Pegando o Id da partida selecionada
            int idPartida = int.Parse(listBoxPartidas.SelectedItem.ToString().Split('-')[0].Trim());

            // Atualiza o listBoxJogadores usando o método da documentação
            ExibirJogadores(idPartida);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void labelSenha_Click(object sender, EventArgs e)
        {

        }

        private void textBoxGrupoPartida_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMostrarJogadores_Click(object sender, EventArgs e)
        {
            if (listBoxPartidas.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma partida primeiro!");
                return;
            }

            string linha = listBoxPartidas.SelectedItem.ToString(); // "1 - Teste"
            int idPartida = int.Parse(linha.Split('-')[0].Trim());  // Extrai o Id

            ExibirJogadores(idPartida);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private string obternomeJogadorporid(string id, ListBox listboxjogadores)
        {
            foreach (var item in listboxjogadores.Items)
            {
                string linha = item.ToString();
                string[] partes = linha.Split(',');

                if (partes.Length >= 2)
                {
                    string idlista = partes[0].Trim();
                    string nome = partes[1].Trim();

                    if (idlista == id)
                        return nome;
                }
            }

            return "desconhecido";
        }

        private string TraduzirDado(string sigla)
        {
            switch (sigla)
            {
                case "AL": return "Praça de Alimentação";
                case "FL": return "Floresta";
                case "PR": return "Pradaria";
                case "TI": return "Tiranossauro Rex";
                case "VZ": return "Cercado Vazio";
                case "WC": return "Banheiros";
                default: return sigla; // Se der erro, mostra a sigla mesmo
            }
        }

        private void buttonIniciarPartida_Click(object sender, EventArgs e)
        {
            if (listBoxJogadores.SelectedItem == null)
            {
                MessageBox.Show("Selecione um jogador para iniciar a partida.");
                return;
            }

            // Extrai o Id do jogador da linha selecionada
            string linhaJogador = listBoxJogadores.SelectedItem.ToString();
            int idJogador = int.Parse(linhaJogador.Split(',')[0].Trim());

            // Pede a senha do jogador
            // string senha = Microsoft.VisualBasic.Interaction.InputBox("Digite a senha do jogador:", "Senha do jogador", "");
            string senha = Prompt("Digite a senha do jogador:", "Senha do jogador");
            if (string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Senha não informada!");
                return;
            }
            senha = senha.Trim().ToUpper();
            Console.WriteLine($"Linha selecionada: '{linhaJogador}'");
            Console.WriteLine($"ID convertido: {idJogador}");
            Console.WriteLine($"Senha após Trim: '{senha.Trim()}'");


            Console.WriteLine($"ID: {idJogador}, Senha digitada: '{senha}' ({senha.Length} chars)");
            foreach (char c in senha)
            {
                Console.WriteLine($"Char: '{c}'  Código: {(int)c}");
            }


            try
            {
                // Inicia a partida
                string resultado = Draft.Jogo.Iniciar(idJogador, senha);
                MessageBox.Show(resultado, "Resultado da Partida");

                string[] dados = resultado.Split(',');

                Console.WriteLine($"Linha selecionada: '{linhaJogador}'");
                Console.WriteLine($"ID convertido: {idJogador}");

                




                // Puxa apenas os dinossauros da mão do jogador
                string cartasNaMao = Draft.Jogo.ExibirMao(idJogador, senha);

                // Limpa o TextBox antigo
                textBoxDinossauros.Clear();

                // Separa as linhas enviadas pela DLL e exibe na tela
                string[] linhasMao = cartasNaMao.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string linhaMao in linhasMao)
                {
                    textBoxDinossauros.AppendText(linhaMao + Environment.NewLine);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar a partida: " + ex.Message);
            }
        }


       
        private void labelSenhaJogador_Click(object sender, EventArgs e)
        {

        }

        private void labelIdJogador_Click(object sender, EventArgs e)
        {

        }

        private void listBoxJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxJogadores.SelectedItem == null)
                return;

            string linha = listBoxJogadores.SelectedItem.ToString();

            string[] dados = linha.Split(',');

            string idJogador = dados[0];

            labelIdJogador.Text = "ID Jogador: " + idJogador;   
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDinossauros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelGrupo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSenhaPartida_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void labelPartidas_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxPartida_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void labelDino_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.FlatStyle = FlatStyle.Flat;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Puxa a mão usando o ID e Senha que já estão salvos na memória do seu form
                string cartasNaMao = Draft.Jogo.ExibirMao(idJogador, senhaJogador);

                // Limpa a caixa de texto dos dinossauros
                textBoxDinossauros.Clear();

                // Separa as linhas e joga na tela
                string[] linhasMao = cartasNaMao.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string linha in linhasMao)
                {
                    textBoxDinossauros.AppendText(linha + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir a mão: " + ex.Message);
            }
        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 1. Uma trava de segurança: O timer só funciona se você tiver selecionado uma partida
            if (listBoxPartidas.SelectedItem != null)
            {
                try
                {
                    // Pega o ID da partida que está selecionada na lista
                    int idPartidaSelecionada = int.Parse(listBoxPartidas.SelectedItem.ToString().Split('-')[0].Trim());

                    // Pergunta pro servidor: "Como está a partida agora?"
                    string statusPartida = Draft.Jogo.VerificarPartida(idPartidaSelecionada);
                    string[] dadosPartida = statusPartida.Split(',');

                    // Só tenta atualizar se o servidor devolver a resposta completa (evita crash)
                    if (dadosPartida.Length >= 5)
                    {
                        // Atualiza o Turno (Posição 1)
                        string turnoAtual = dadosPartida[1];
                        labelTurno.Text = "Turno: " + turnoAtual;

                        // Atualiza o Dono do Dado (Posição 3) e Traduz o Dado (Posição 4)
                        string idJogadorDado = dadosPartida[3];
                        string faceDado = dadosPartida[4].Trim();
                        regraAtual = faceDado; // Já vamos salvar na memória limpinho, porque vamos usar essa regra nos IFs agora!

                        string nomeJogadorDado = obternomeJogadorporid(idJogadorDado, listBoxJogadores);

                        // O TRUQUE MÁGICO AQUI: 
                        // Se o código não conhecer o jogador, ele aperta o botão "Mostrar Jogadores" sozinho por trás dos panos e procura de novo!
                        if (nomeJogadorDado == "desconhecido")
                        {
                            ExibirJogadores(idPartidaSelecionada); // Atualiza a lista
                            nomeJogadorDado = obternomeJogadorporid(idJogadorDado, listBoxJogadores); // Tenta achar o nome de novo
                        }

                        labelJogadorDaVez.Text = "Jogador da vez: " + nomeJogadorDado;
                        labelDado.Text = "Dado: " + TraduzirDado(faceDado);
                    }
                }
                catch
                {
                    // Deixamos vazio de propósito. Se a internet piscar, o jogo não trava, ele só tenta de novo 2 segundos depois!
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBoxTabuleiro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}