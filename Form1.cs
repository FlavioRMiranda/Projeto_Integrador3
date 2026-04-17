using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Draft;

namespace Projeto_Integrador3
{
    public partial class Form1 : Form
    {
        private string senhaJogadorCriador;
        private int idJogadorCriador;
        private int idJogadorAtual;
        private int idPartidaAtual = 0;
        private int idJogadorDoDadoAtual = 0;
        private string senhaJogadorAtual;
        private string GRUPO = "Fossilizados";
        private string jogadorDaVez;
        private string nomeJogadorDaVez;
        private string regraAtual;
        private int idJogador;
        private string senhaJogador;
        private bool modoDemo = false;

        private Dictionary<string, Dictionary<string, int>> tabuleiroDemo =
            new Dictionary<string, Dictionary<string, int>>();

        public Form1()
        {
            InitializeComponent();
            labelGrupo.Text = GRUPO;
            CriarPaineisCercados();
            InicializarTabuleiroDemo();
        }

        private void InicializarTabuleiroDemo()
        {
            tabuleiroDemo["FI"] = new Dictionary<string, int>();
            tabuleiroDemo["RS"] = new Dictionary<string, int>();
            tabuleiroDemo["MT"] = new Dictionary<string, int>();
            tabuleiroDemo["IS"] = new Dictionary<string, int>();
            tabuleiroDemo["PA"] = new Dictionary<string, int>();
            tabuleiroDemo["CD"] = new Dictionary<string, int>();
            tabuleiroDemo["RI"] = new Dictionary<string, int>();
        }

        private void CriarPaineisCercados()
        {
            // Essas coordenadas são baseados na resolução do meu Laptop.
            // --> fazer variaveis que pegam a resolução e calculam as coordenadas corretas
            // -- Lucas <3
            painelPorCercado["FI"] = CriarPainel(90, 55, 420, 200); // superior esquerdo
            painelPorCercado["RS"] = CriarPainel(885, 70, 175, 125); // superior direito
            painelPorCercado["MT"] = CriarPainel(60, 350, 375, 215); // esquerdo do meio
            painelPorCercado["IS"] = CriarPainel(795, 360, 440, 220); // Centro-direita
            painelPorCercado["PA"] = CriarPainel(150, 625, 325, 260); // inferior esquerdo
            painelPorCercado["CD"] = CriarPainel(990, 620, 300, 180); // inferior direito

            foreach (var painel in painelPorCercado.Values)
            {
                pictureBoxTabuleiro.Controls.Add(painel);
            }
        }

        private FlowLayoutPanel CriarPainel(int x, int y, int largura, int altura)
        {
            FlowLayoutPanel painel = new FlowLayoutPanel();
            painel.Location = new Point(x, y);
            painel.Size = new Size(largura, altura);
            painel.BackColor = Color.FromArgb(80, Color.White);
            painel.WrapContents = true;
            painel.AutoScroll = false;
            painel.BringToFront();
            return painel;
        }

        private void AdicionarDinoDemo(string codDino, string codCercado)
        {
            codDino = codDino.Trim().ToUpper();
            codCercado = codCercado.Trim().ToUpper();

            if (!imagensDinos.ContainsKey(codDino))
            {
                MessageBox.Show("Código de dino inválido: " + codDino);
                return;
            }

            if (!painelPorCercado.ContainsKey(codCercado))
            {
                MessageBox.Show("Código de cercado inválido: " + codCercado);
                return;
            }

            if (!tabuleiroDemo.ContainsKey(codCercado))
            {
                tabuleiroDemo[codCercado] = new Dictionary<string, int>();
            }

            if (!tabuleiroDemo[codCercado].ContainsKey(codDino))
            {
                tabuleiroDemo[codCercado][codDino] = 0;
            }

            tabuleiroDemo[codCercado][codDino]++;
            RenderizarTabuleiroDemo();
            AtualizarTextoTabuleiroDemo();
        }

        private void RenderizarTabuleiroDemo()
        {
            foreach (var painel in painelPorCercado.Values)
            {
                painel.Controls.Clear();
            }

            foreach (var entradaCercado in tabuleiroDemo)
            {
                string cercado = entradaCercado.Key;

                if (!painelPorCercado.ContainsKey(cercado))
                    continue;

                foreach (var entradaDino in entradaCercado.Value)
                {
                    string codigoDino = entradaDino.Key;
                    int quantidade = entradaDino.Value;

                    if (!imagensDinos.ContainsKey(codigoDino))
                        continue;

                    string caminho = CaminhoImagemDino(imagensDinos[codigoDino]);

                    if (!File.Exists(caminho))
                        continue;

                    for (int i = 0; i < quantidade; i++)
                    {
                        PictureBox pb = new PictureBox();
                        pb.Width = 40;
                        pb.Height = 40;
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.Image = new Bitmap(caminho);

                        painelPorCercado[cercado].Controls.Add(pb);
                    }
                }
            }
        }

        private void AtualizarTextoTabuleiroDemo()
        {
            textBoxTabuleiro.Clear();

            foreach (var entradaCercado in tabuleiroDemo)
            {
                string cercado = entradaCercado.Key;

                foreach (var entradaDino in entradaCercado.Value)
                {
                    string codigoDino = entradaDino.Key;
                    int quantidade = entradaDino.Value;

                    textBoxTabuleiro.AppendText(
                        cercado + "," + codigoDino + "," + quantidade + Environment.NewLine
                    );
                }
            }
        }

        private void RenderizarTabuleiroVisual()
        {
            foreach (var painel in painelPorCercado.Values)
            {
                painel.Controls.Clear();
            }

            string estadoTabuleiro = Draft.Jogo.ExibirTabuleiro(idJogador, senhaJogador);

            string[] linhas = estadoTabuleiro.Split(
                new[] { '\r', '\n' },
                StringSplitOptions.RemoveEmptyEntries
            );

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(',');

                if (partes.Length < 3)
                    continue;

                string cercado = partes[0].Trim().ToUpper();
                string codigoDino = partes[1].Trim().ToUpper();

                if (!int.TryParse(partes[2].Trim(), out int quantidade))
                    continue;

                if (!painelPorCercado.ContainsKey(cercado))
                    continue;

                if (!imagensDinos.ContainsKey(codigoDino))
                    continue;

                string caminho = CaminhoImagemDino(imagensDinos[codigoDino]);

                if (!File.Exists(caminho))
                    continue;

                for (int i = 0; i < quantidade; i++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Width = 40;
                    pb.Height = 40;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Image = new Bitmap(caminho);

                    painelPorCercado[cercado].Controls.Add(pb);
                }
            }
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
                StartPosition = FormStartPosition.CenterScreen,
            };

            Label textLabel = new Label()
            {
                Left = 10,
                Top = 20,
                Text = text,
                AutoSize = true,
            };
            TextBox inputBox = new TextBox()
            {
                Left = 10,
                Top = 50,
                Width = 260,
            };
            Button confirmation = new Button()
            {
                Text = "OK",
                Left = 200,
                Width = 70,
                Top = 80,
                DialogResult = DialogResult.OK,
            };

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

        private string CaminhoImagemDino(string nomeArquivo)
        {
            return Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Assets",
                "Dinos",
                nomeArquivo
            );
        }

        private Dictionary<string, string> imagensDinos = new Dictionary<string, string>()
        {
            { "BR", "DinoRosa.jpg" },
            { "EP", "DinoLaranja.jpg" },
            { "ET", "DinoAzul.jpg" },
            { "PA", "DinoVerde.jpg" },
            { "TI", "DinoVermelho.jpg" },
            { "TR", "DinoAmarelo.jpg" },
        };

        private Dictionary<int, FlowLayoutPanel> painelPorJogador =
            new Dictionary<int, FlowLayoutPanel>();
        private Dictionary<int, string> senhaPorJogador = new Dictionary<int, string>();
        private Dictionary<string, FlowLayoutPanel> painelPorCercado =
            new Dictionary<string, FlowLayoutPanel>();

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
            string[] linhas = resposta.Split(
                new[] { "\r\n", "\n" },
                StringSplitOptions.RemoveEmptyEntries
            );

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
                        string descricaoStatus =
                            status == "A" ? "Aberta"
                            : status == "E" ? "Encerrada"
                            : status == "J" ? "Jogando"
                            : status;

                        listBoxPartidas.Items.Add($"{id} - {nome} ({descricaoStatus})");
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

            if (modoDemo)
            {
                AdicionarDinoDemo(codDino, codCercado);
                MessageBox.Show("Dino adicionado em modo demonstração.");
                return;
            }
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
                if (
                    codCercado != "FI"
                    && codCercado != "RS"
                    && codCercado != "MT"
                    && codCercado != "IS"
                )
                {
                    MessageBox.Show(
                        "Jogada Inválida! O dado mandou jogar na Floresta (Parte de cima do tabuleiro)."
                    );
                    return; // Cancela o envio
                }
            }
            else if (regraAtual == "PR") // Pradaria (Parte de Baixo)
            {
                // Cercados da parte de baixo: Pradaria do Amor (PA), Campina da Diferença (CD)
                if (codCercado != "PA" && codCercado != "CD" && codCercado != "RS")
                {
                    MessageBox.Show(
                        "Jogada Inválida! O dado mandou jogar na Pradaria (Parte de baixo do tabuleiro)."
                    );
                    return;
                }
            }
            else if (regraAtual == "AL") // Praça de Alimentação (Lado Esquerdo)
            {
                if (codCercado != "FI" && codCercado != "MT" && codCercado != "PA")
                {
                    MessageBox.Show(
                        "Jogada Inválida! O dado mandou jogar na Praça de Alimentação (Lado esquerdo) -> 'FI' ou 'MT' ou 'PA'."
                    );
                    return;
                }
            }
            else if (regraAtual == "WC") // Banheiros (Lado Direito)
            {
                if (codCercado != "IS" && codCercado != "CD" && codCercado != "RS")
                {
                    MessageBox.Show(
                        "Jogada Inválida! O dado mandou jogar nos Banheiros (Lado direito)."
                    );
                    return;
                }
            }

            string resposta = Draft.Jogo.Jogar(idJogador, senhaJogador, codDino, codCercado);

            // 🔄 Tratamento da resposta
            if (int.TryParse(resposta, out int proximoTurno))
            {
                MessageBox.Show("Jogada realizada! Próximo turno: " + proximoTurno);

                labelTurno.Text = "Turno: " + proximoTurno;
                // 👉 Atualiza o tabuleiro na tela logo após a jogada dar certo
                string meuTabuleiro = Draft.Jogo.ExibirTabuleiro(idJogador, senhaJogador);

                // Limpa a caixa e joga o texto original do servidor pulando as linhas corretamente
                textBoxTabuleiro.Clear();
                textBoxTabuleiro.Text = meuTabuleiro.Replace("\n", Environment.NewLine);
                RenderizarTabuleiroVisual();
                timer1_Tick(null, null);
            }
            else
            {
                MessageBox.Show("Erro: " + resposta);
            }
        }

        private void textBoxSenhaPartida_TextChanged(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

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
                idPartidaAtual = idPartida;

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

                idPartidaAtual = idPartida;
                senhaPorJogador[idJogador] = senhaJogador;
                ExibirJogadores(idPartida);
                RegistrarJogadoresNosPaineis();
                AtualizarMaosDeTodos();
                string caminho = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "credenciais.txt"
                );

                string conteudo =
                    "===== NOVO REGISTRO ====="
                    + Environment.NewLine
                    +
                    // "ID Jogador: " + (idJogador ?? "N/A") + Environment.NewLine +
                    "Nome: "
                    + (nomeJogador ?? "N/A")
                    + Environment.NewLine
                    + "Senha Jogador: "
                    + (senhaJogador ?? "N/A")
                    + Environment.NewLine
                    + "ID Partida: "
                    + idPartida
                    + Environment.NewLine
                    + "Senha Partida: "
                    + (senhaPartida ?? "N/A")
                    + Environment.NewLine
                    + "Data: "
                    + DateTime.Now
                    + Environment.NewLine
                    + "----------------------"
                    + Environment.NewLine;

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
            foreach (
                var linha in jogadoresStr.Split(
                    new[] { Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries
                )
            )
            {
                listBoxJogadores.Items.Add(linha);
            }
        }

        private void RegistrarJogadoresNosPaineis()
        {
            painelPorJogador.Clear();

            FlowLayoutPanel[] paineis =
            {
                painelPorCercado["FI"],
                painelPorCercado["RS"],
                painelPorCercado["MT"],
                painelPorCercado["IS"],
                painelPorCercado["PA"],
                painelPorCercado["CD"],
            };
            int indice = 0;
            foreach (var item in listBoxJogadores.Items)
            {
                if (indice >= 6)
                    break;
                string linha = item.ToString();
                string[] partes = linha.Split(',');

                if (partes.Length >= 2)
                {
                    int id = int.Parse(partes[0].Trim());
                    painelPorJogador[id] = paineis[indice];
                    indice++;
                }
            }
        }

        private void listBoxPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPartidas.SelectedItem == null)
                return;

            // Pegando o Id da partida selecionada
            int idPartida = int.Parse(listBoxPartidas.SelectedItem.ToString().Split('-')[0].Trim());

            // Atualiza o listBoxJogadores usando o método da documentação
            ExibirJogadores(idPartida);
        }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void labelNome_Click(object sender, EventArgs e) { }

        private void labelSenha_Click(object sender, EventArgs e) { }

        private void textBoxGrupoPartida_TextChanged(object sender, EventArgs e) { }

        private void buttonMostrarJogadores_Click(object sender, EventArgs e)
        {
            if (listBoxPartidas.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma partida primeiro!");
                return;
            }

            string linha = listBoxPartidas.SelectedItem.ToString(); // "1 - Teste"
            int idPartida = int.Parse(linha.Split('-')[0].Trim()); // Extrai o Id

            ExibirJogadores(idPartida);
        }

        private void label4_Click(object sender, EventArgs e) { }

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
                case "AL":
                    return "Praça de Alimentação";
                case "FL":
                    return "Floresta";
                case "PR":
                    return "Pradaria";
                case "TI":
                    return "Tiranossauro Rex";
                case "VZ":
                    return "Cercado Vazio";
                case "WC":
                    return "Banheiros";
                default:
                    return sigla; // Se der erro, mostra a sigla mesmo
            }
        }

        private string ExtrairCodigoDino(string linha)
        {
            if (string.IsNullOrWhiteSpace(linha))
                return null;

            linha = linha.Trim();

            if (linha.Length >= 2)
                return linha.Substring(0, 2).ToUpper();

            return null;
        }

        private void RenderizarMaoJogador(int idJogador, string cartasNaMao)
        {
            if (
                !painelPorJogador.TryGetValue(idJogador, out FlowLayoutPanel painel)
                || painel == null
            )
                return;

            painel.Controls.Clear();

            string[] linhas = cartasNaMao.Split(
                new[] { '\r', '\n' },
                StringSplitOptions.RemoveEmptyEntries
            );

            foreach (string linha in linhas)
            {
                string codigo = ExtrairCodigoDino(linha);

                if (codigo == null || !imagensDinos.ContainsKey(codigo))
                    continue;

                string caminho = CaminhoImagemDino(imagensDinos[codigo]);

                if (!File.Exists(caminho))
                    continue;

                PictureBox pb = new PictureBox();
                pb.Width = 46;
                pb.Height = 46;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Image = new Bitmap(caminho);

                painel.Controls.Add(pb);
            }
        }

        private void AtualizarMaosDeTodos()
        {
            foreach (var par in senhaPorJogador)
            {
                int id = par.Key;
                string senha = par.Value;

                try
                {
                    string cartasNaMao = Draft.Jogo.ExibirMao(id, senha);
                    RenderizarMaoJogador(id, cartasNaMao);
                }
                catch { }
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
            int idJogadorSelecionado = int.Parse(linhaJogador.Split(',')[0].Trim());

            // Pede a senha do jogador
            // string senha = Microsoft.VisualBasic.Interaction.InputBox("Digite a senha do jogador:", "Senha do jogador", "");
            string senha = Prompt("Digite a senha do jogador:", "Senha do jogador");
            if (string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Senha não informada!");
                return;
            }
            senha = senha.Trim().ToUpper();
            this.idJogador = idJogadorSelecionado;
            this.senhaJogador = senha;

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
                string meuTabuleiro = Draft.Jogo.ExibirTabuleiro(idJogador, senha);
                textBoxTabuleiro.Clear();
                textBoxTabuleiro.Text = meuTabuleiro.Replace("\n", Environment.NewLine);
                RenderizarTabuleiroVisual();

                string[] dados = resultado.Split(',');

                Console.WriteLine($"Linha selecionada: '{linhaJogador}'");
                Console.WriteLine($"ID convertido: {idJogador}");

                // Puxa apenas os dinossauros da mão do jogador
                string cartasNaMao = Draft.Jogo.ExibirMao(idJogador, senha);

                // Limpa o TextBox antigo
                textBoxDinossauros.Clear();

                // Separa as linhas enviadas pela DLL e exibe na tela
                string[] linhasMao = cartasNaMao.Split(
                    new[] { '\r', '\n' },
                    StringSplitOptions.RemoveEmptyEntries
                );

                foreach (string linhaMao in linhasMao)
                {
                    textBoxDinossauros.AppendText(linhaMao + Environment.NewLine);
                }
                //AtualizarMaosDeTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar a partida: " + ex.Message);
            }
        }

        private void labelSenhaJogador_Click(object sender, EventArgs e) { }

        private void labelIdJogador_Click(object sender, EventArgs e) { }

        private void listBoxJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxJogadores.SelectedItem == null)
                return;

            string linha = listBoxJogadores.SelectedItem.ToString();
            string[] dados = linha.Split(',');

            int idSelecionado = int.Parse(dados[0].Trim());

            labelIdJogador.Text = "ID Jogador: " + idSelecionado;

            if (senhaPorJogador.ContainsKey(idSelecionado))
            {
                idJogador = idSelecionado;
                senhaJogador = senhaPorJogador[idSelecionado];
                labelSenhaJogador.Text = "Senha Jogador: " + senhaJogador;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void textBoxDinossauros_SelectedIndexChanged(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void labelGrupo_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void textBoxSenhaPartida_TextChanged_1(object sender, EventArgs e) { }

        private void labelPartidas_Click(object sender, EventArgs e) { }

        private void label6_Click(object sender, EventArgs e) { }

        private void groupBoxPartida_Enter(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void label4_Click_1(object sender, EventArgs e) { }

        private void labelDino_Click(object sender, EventArgs e) { }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.FlatStyle = FlatStyle.Flat;
        }

        private void textBox4_TextChanged(object sender, EventArgs e) { }

        private void label12_Click(object sender, EventArgs e) { }

        private void label13_Click(object sender, EventArgs e) { }

        private void label11_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Puxa a mão usando o ID e Senha que já estão salvos na memória do seu form
                string cartasNaMao = Draft.Jogo.ExibirMao(idJogador, senhaJogador);

                // Limpa a caixa de texto dos dinossauros
                textBoxDinossauros.Clear();

                // Separa as linhas e joga na tela
                string[] linhasMao = cartasNaMao.Split(
                    new[] { '\r', '\n' },
                    StringSplitOptions.RemoveEmptyEntries
                );

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

        private void label13_Click_1(object sender, EventArgs e) { }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (idPartidaAtual <= 0)
                return;

            try
            {
                string statusPartida = Draft.Jogo.VerificarPartida(idPartidaAtual);
                string[] dadosPartida = statusPartida.Split(',');

                if (dadosPartida.Length >= 5)
                {
                    string statusDaPartida = dadosPartida[0].Trim();
                    string turnoAtual = dadosPartida[1].Trim();
                    string statusDoTurno = dadosPartida[2].Trim();
                    string idJogadorDado = dadosPartida[3].Trim();
                    string faceDado = dadosPartida[4].Trim();

                    regraAtual = faceDado;
                    labelTurno.Text = "Turno: " + turnoAtual;

                    if (int.TryParse(idJogadorDado, out int idDado))
                    {
                        idJogadorDoDadoAtual = idDado;

                        // troca automaticamente o "jogador logado" para quem está com o dado
                        if (senhaPorJogador.ContainsKey(idDado))
                        {
                            idJogador = idDado;
                            senhaJogador = senhaPorJogador[idDado];

                            labelIdJogador.Text = "ID Jogador: " + idJogador;
                            labelSenhaJogador.Text = "Senha Jogador: " + senhaJogador;
                        }
                    }

                    string nomeJogadorDado = obternomeJogadorporid(idJogadorDado, listBoxJogadores);

                    if (nomeJogadorDado == "desconhecido")
                    {
                        ExibirJogadores(idPartidaAtual);
                        nomeJogadorDado = obternomeJogadorporid(idJogadorDado, listBoxJogadores);
                    }

                    labelJogadorDaVez.Text = "Jogador com o dado: " + nomeJogadorDado;
                    labelDado.Text = "Dado: " + TraduzirDado(faceDado);
                }
            }
            catch { }
        }

        private void groupBox2_Enter(object sender, EventArgs e) { }

        private void panel1_Paint_1(object sender, PaintEventArgs e) { }

        private void textBoxTabuleiro_TextChanged(object sender, EventArgs e) { }
    }
}
