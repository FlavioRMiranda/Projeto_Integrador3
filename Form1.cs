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

            string resposta = Draft.Jogo.Jogar(idJogador, senhaJogador, codDino, codCercado);

            // 🔄 Tratamento da resposta
            if (int.TryParse(resposta, out int proximoTurno))
            {
                MessageBox.Show("Jogada realizada! Próximo turno: " + proximoTurno);

                // 👉 Aqui você pode atualizar o tabuleiro depois
                // AtualizarTabuleiro();
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

                string nomeJogador = textBox2.Text.Trim();
                string senhaPartida = textBox3.Text;

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
               // jogadorDaVez = dados[0];
               // regraAtual = dados[1];

                string caminho = @"C:\Users\FlavioMiranda\source\repos\Projeto_Integrador_BCC\Projeto_Integrador_BCC\Projeto_Integrador3\Projeto_Integrador3\credenciais.txt";

                Directory.CreateDirectory(Path.GetDirectoryName(caminho));

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

                jogadorDaVez = dados[0];
                regraAtual = dados[1];

                labelJogadorDaVez.Text = "Jogador da vez: " + jogadorDaVez;
                labelDado.Text = "Dado: " + regraAtual;

                // (opcional, mas útil pra debug)
                MessageBox.Show(resultado, "Resultado da Partida");



                // Lista os dinossauros do jogo
                string listaDinos = Draft.Jogo.ListarDinossauros(true);

                // Limpa o TextBox
                textBoxDinossauros.Clear();

                // Separa cada linha
                string[] linhas = listaDinos.Split('\n');
                foreach (string linha in linhas)
                {
                    if (!string.IsNullOrWhiteSpace(linha))
                    {
                        // Pega o nome do dinossauro (segunda posição)
                        string[] partes = linha.Split(',');
                        if (partes.Length >= 2)
                        {
                            string nomeDino = partes[1].Trim();
                            textBoxDinossauros.AppendText(nomeDino + Environment.NewLine);
                        }
                    }
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
    }
}