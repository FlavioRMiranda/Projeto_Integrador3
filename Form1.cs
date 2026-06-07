using Draft;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Projeto_Integrador3
{
    public partial class Form1 : Form
    {
        private string GRUPO = "Fossilizados";
        private int idJogador;
        private string senhaJogador;
        private string regraAtual;
        private bool jogandoAutomaticamente = false;
        private string ultimaChaveProcessada = "";
        private int idPartidaAtual = 0;
        bool modoAutomatico = true;


        public Form1()//Construtor
        {
            InitializeComponent();
            labelGrupo.Text = GRUPO;
            this.Load += Form1_Load;//Para esconder botões do form quando jogo executado.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarInterface(); //Form1_Load chama o método ConfigurarInterface
        }

        private void ConfigurarInterface() //Metodo ConfigurarInterface. Tudo que estiver aqui como false, não será mostrado no painel grafico do jogo.
        {
            if (modoAutomatico)
            {
                buttonJogar.Visible = false;
                textBoxDino.Visible = false;
                textBoxCercado.Visible = false;
                groupBox1.Visible = false;
                label8.Visible = false;
                panelContainer.Visible = false;
            }
        }


        // ==========================
        // CRIAR PARTIDA
        // ==========================
        private void buttonCriarPartida_Click(object sender, EventArgs e)
        {
            string nome = textBoxNomePartida.Text.Trim();
            string senha = textBoxSenhaPartida.Text.Trim();

            string retorno = Jogo.CriarPartida(nome, senha, GRUPO).Trim();

            if (int.TryParse(retorno, out int id))
            
            {
                MessageBox.Show("Partida criada! ID: " + id);
                AtualizarListaPartidas();
            }
            else
            {
                MessageBox.Show(retorno);
            }
        }

        /*==========================================================================================================
        O método int.TryParse tenta converter uma string para inteiro sem lançar exceção.
        Ele retorna true se a conversão for bem-sucedida e atribui o valor à variável id usando o parâmetro out.
        Caso contrário, retorna false, permitindo tratar o erro sem interromper a execução do programa


        ============================================================================================================
         */
        // ==========================
        // LISTAR PARTIDAS
        // ==========================
        private void buttonListarPartidas_Click(object sender, EventArgs e)
        {
            AtualizarListaPartidas();
        }

        private void AtualizarListaPartidas()
        {
            listBoxPartidas.Items.Clear();

            string resposta = Jogo.ListarPartidas("T");
            string[] linhas = resposta.Split('\n');

            foreach (string linha in linhas)
            {
                if (string.IsNullOrWhiteSpace(linha)) continue;

                string[] partes = linha.Split(',');

                if (partes.Length >= 4)
                {
                    listBoxPartidas.Items.Add($"{partes[0]} - {partes[1]} ({partes[3]})");
                }
            }
        }

        private void buttonMostrarJogadores_Click(object sender, EventArgs e)
        {
            int idPartida;

            if (listBoxPartidas.SelectedItem != null)
            {
                string item = listBoxPartidas.SelectedItem.ToString();
                idPartida = int.Parse(item.Split('-')[0].Trim());
            }
            else if (!int.TryParse(textBoxIdPartida.Text.Trim(), out idPartida))
            {
                MessageBox.Show("Selecione uma partida ou informe o ID.");
                return;
            }

            string resposta = Jogo.ListarJogadores(idPartida);

            MessageBox.Show("ID Partida: " + idPartida + "\nResposta:\n" + resposta);

            listBoxJogadores.Items.Clear();

            string[] linhas = resposta.Split(
                new[] { "\r\n", "\n" },
                StringSplitOptions.RemoveEmptyEntries
            );

            foreach (string linha in linhas)
            {
                listBoxJogadores.Items.Add(linha);
            }
        }


        // ==========================
        // ENTRAR PARTIDA
        // ==========================
        private void buttonEntrarPartida_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxIdPartida.Text.Trim(), out int idPartida))
            {
                MessageBox.Show("Informe um ID de partida válido.");
                return;
            }

            idPartidaAtual = idPartida;

            string nome = nomeJogador.Text.Trim();
            string senhaPartida = this.senhaPartida.Text.Trim();

            string resposta = Jogo.Entrar(idPartidaAtual, nome, senhaPartida).Trim();

            if (!resposta.Contains(","))
            {
                MessageBox.Show("Erro ao entrar: " + resposta);
                return;
            }

            string[] dados = resposta.Split(',');

            if (dados.Length < 2)
            {
                MessageBox.Show("Resposta inesperada ao entrar: " + resposta);
                return;
            }

            if (!int.TryParse(dados[0].Trim(), out idJogador))
            {
                MessageBox.Show("Erro inesperado ao interpretar ID: " + resposta);
                return;
            }

            senhaJogador = dados[1].Trim();

            labelIdJogador.Text = "ID Jogador: " + idJogador;
            labelSenhaJogador.Text = "Senha Jogador: " + senhaJogador;

            MessageBox.Show("Jogador entrou na partida com sucesso.");
        }

        // ==========================
        // INICIAR PARTIDA
        // ==========================
        private void buttonIniciarPartida_Click(object sender, EventArgs e)
        {
            if (idJogador == 0 || string.IsNullOrWhiteSpace(senhaJogador))
            {
                MessageBox.Show("Entre na partida antes de iniciar.");
                return;
            }

            string resultado = Jogo.Iniciar(idJogador, senhaJogador);

            MessageBox.Show(resultado);

            if (!resultado.Contains(","))
            {
                MessageBox.Show("A partida ainda não foi iniciada. O timer não será ligado.");
                return;
            }

            timer1.Interval = 5000;
            timer1.Start();

         }

        // ==========================
        // JOGAR MANUAL
        // ==========================
        private void buttonJogar_Click(object sender, EventArgs e)
        {
            string codDino = textBoxDino.Text.ToUpper();
            string codCercado = textBoxCercado.Text.ToUpper();

            string resposta = Jogo.Jogar(idJogador, senhaJogador, codDino, codCercado);

            if (int.TryParse(resposta, out _))
            {
                AtualizarTabuleiroServidor();
            }
            else
            {
                MessageBox.Show(resposta);
            }
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
                case "RI": return "Rio";
                default: return sigla;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (idPartidaAtual == 0)
                return;

            if (idJogador == 0 || string.IsNullOrWhiteSpace(senhaJogador))
                return;

            string status = Jogo.VerificarPartida(idPartidaAtual);

            if (string.IsNullOrWhiteSpace(status) || status.Contains("ERRO"))
            {
                SalvarDebug("Status inválido:\n" + status);
                return;
            }

            string[] dados = status.Split(',');

            if (dados.Length < 5)
            {
                SalvarDebug("Formato inesperado:\n" + status);
                return;
            }

            if (!int.TryParse(dados[1].Trim(), out int turnoAtual))
            {
                SalvarDebug("Não foi possível converter o turno. Status recebido:\n" + status);
                return;
            }

            string statusPartida = dados[2].Trim().ToUpper();
            string donoDoDado = dados[3].Trim();
            regraAtual = dados[4].Trim().ToUpper();

            labelTurno.Text = "Turno: " + turnoAtual;
            labelDado.Text = "Dado: " + TraduzirDado(regraAtual);
            labelJogadorDaVez.Text = "Dono do dado: " + donoDoDado;

            if (statusPartida != "A")
            {
                SalvarDebug("Partida finalizada.");

                SalvarPontuacaoCalculada();

                timer1.Stop();
                return;
            }



            string chaveTurno = idJogador + "-" + turnoAtual;

            if (ultimaChaveProcessada == chaveTurno)
                return;

            if (jogandoAutomaticamente)
                return;

            jogandoAutomaticamente = true;

            try
            {
                bool jogou = ExecutarJogadaAutomatica();

                if (jogou)
                {
                    ultimaChaveProcessada = chaveTurno;
                    SalvarDebug("Jogada executada no turno " + turnoAtual);
                }
            }
            finally
            {
                jogandoAutomaticamente = false;
            }
        }

        private class JogadaBot
        {
            public string Dino { get; set; }
            public string Cercado { get; set; }
            public int Pontos { get; set; }
        }

        private class EstadoJogo
        {
            public int TurnoAtual { get; set; }
            public int RodadaAtual { get; set; } // Draftosaurus tem múltiplas rodadas
            public bool IsUltimaRodada { get; set; }
            public Dictionary<string, int> DinosRestantes { get; set; }
            public Dictionary<string, int> CercadosOcupacao { get; set; }
        }

        // Classe para representar o estado do jogo
 

        // Nova versão melhorada do método de pontuação
        private int PontuarJogadaAvancada(string tabuleiro, string dino, string cercado, EstadoJogo estado)
        {
            int pontos = 0;

            int qtdAtual = ContarDinosNoCercado(tabuleiro, cercado);
            bool temMesmoDino = CercadoTemDino(tabuleiro, cercado, dino);
            bool dinoUnicoNoZoo = !DinoExisteNoZoo(tabuleiro, dino);

            switch (cercado)
            {
                case "CD": // Campina da Diferença - quanto mais espécies diferentes, melhor
                    if (!temMesmoDino)
                    {
                        int especiesAtuais = ContarEspeciesNoCercado(tabuleiro, cercado);
                        // Bônus exponencial para novas espécies
                        pontos = 30 + (especiesAtuais * 15);

                        // Se for espécie única no zoo todo, bônus extra
                        if (dinoUnicoNoZoo)
                            pontos += 20;
                    }
                    else
                    {
                        pontos = -100; // Repetir espécie em CD é péssimo
                    }
                    break;

                case "FI": // Floresta da Igualdade - quer repetir a mesma espécie
                    if (qtdAtual == 0)
                        pontos = 20; // Começar FI
                    else if (temMesmoDino)
                    {
                        // Escala com quantidade: 2x=25, 3x=35, 4x=50
                        pontos = 20 + (qtdAtual * 10);

                        // Se puder completar 4 da mesma espécie, bônus enorme
                        if (qtdAtual + 1 == 4)
                            pontos += 40;
                    }
                    else
                        pontos = -80; // Misturar espécies na FI é muito ruim
                    break;

                case "MT": // Mata Tripla - quer exatamente 3 dinos
                    if (qtdAtual == 2)
                        pontos = 80; // Completar MT é prioridade máxima
                    else if (qtdAtual == 1)
                        pontos = 40; // Preparar MT
                    else if (qtdAtual == 0)
                        pontos = 25; // Iniciar MT
                    else if (qtdAtual >= 3)
                        pontos = -50; // Já tem 3+, não adicionar mais
                    break;

                case "PA": // Pradaria do Amor - quer pares da mesma espécie
                    int paresAtuais = ContarParesNoCercado(tabuleiro, cercado);
                    if (temMesmoDino)
                    {
                        int novoTotal = qtdAtual + 1;
                        int novosPares = novoTotal / 2;
                        int ganhoPares = (novosPares - paresAtuais) * 15;
                        pontos = 15 + ganhoPares;

                        // Evitar overcrowding na PA
                        if (qtdAtual >= 5)
                            pontos -= 20;
                    }
                    else
                    {
                        pontos = 8; // Colocar espécie nova é OK mas não ótimo
                    }
                    break;

                case "IS": // Ilha Solitária - quer 1 dino que não existe em outro lugar
                    if (qtdAtual == 0 && dinoUnicoNoZoo)
                        pontos = 45; // Cenário ideal
                    else if (qtdAtual == 0)
                        pontos = 20; // Começar IS com dino repetido
                    else
                        pontos = -999; // IS só pode ter 1 dino
                    break;

                case "RS": // Recinto Secreto - pontuação depende dos outros
                    if (qtdAtual == 0)
                        pontos = 30; // Vale a pena arriscar
                    else
                        pontos = -999; // Só cabe 1
                    break;

                case "RI": // Rio - último recurso
                    pontos = -50; // Ruim, mas melhor que não jogar
                    break;
            }

            // ========== BÔNUS DE ESTRATÉGIA AVANÇADA ==========

            // 1. Priorizar completar objetivos próximos
            if (qtdAtual + 1 == 3 && cercado == "MT")
                pontos += 50; // Falta 1 para completar MT

            if (qtdAtual + 1 == 4 && cercado == "FI")
                pontos += 45; // Falta 1 para completar FI

            // 2. Considerar final do jogo
            if (estado.IsUltimaRodada)
            {
                // Na última rodada, priorizar cercados que dão pontos imediatos
                if (cercado == "MT" || cercado == "CD")
                    pontos += 30;

                // Evitar RI na última rodada se possível
                if (cercado == "RI")
                    pontos -= 30;
            }

            // 3. Estratégia de early-game vs late-game
            if (estado.RodadaAtual <= 2) // Early game
            {
                // Construir base estratégica
                if (cercado == "MT" || cercado == "CD")
                    pontos += 15;
                if (cercado == "RI")
                    pontos -= 20;
            }

            return pontos;
        }

        // Método auxiliar para contar pares em um cercado
        private int ContarParesNoCercado(string tabuleiro, string cercado)
        {
            var dinos = new List<string>();

            foreach (string linha in tabuleiro.Split('\n'))
            {
                if (string.IsNullOrWhiteSpace(linha)) continue;
                string[] partes = linha.Split(',');

                if (partes.Length >= 3 && partes[0].Trim().ToUpper() == cercado)
                {
                    string dino = partes[1].Trim();
                    if (int.TryParse(partes[2].Trim(), out int qtd))
                    {
                        for (int i = 0; i < qtd; i++)
                            dinos.Add(dino);
                    }
                }
            }

            return dinos.GroupBy(d => d).Sum(g => g.Count() / 2);
        }

        // Método auxiliar para contar espécies diferentes em um cercado
        private int ContarEspeciesNoCercado(string tabuleiro, string cercado)
        {
            var especies = new HashSet<string>();

            foreach (string linha in tabuleiro.Split('\n'))
            {
                if (string.IsNullOrWhiteSpace(linha)) continue;
                string[] partes = linha.Split(',');

                if (partes.Length >= 3 && partes[0].Trim().ToUpper() == cercado)
                {
                    especies.Add(partes[1].Trim().ToUpper());
                }
            }

            return especies.Count;
        }

        // Nova versão do ExecutarJogadaAutomatica com estratégia melhorada
        private bool ExecutarJogadaAutomatica()
        {
            string mao = Jogo.ExibirMao(idJogador, senhaJogador);
            string tabuleiro = Jogo.ExibirTabuleiro(idJogador, senhaJogador);

            if (mao.Contains("ERRO"))
                return false;

            // Obter estado atual do jogo
            EstadoJogo estado = ObterEstadoJogo();

            string[] dinos = ObterDinosDisponiveis(mao);
            string[] cercados = ObterCercadosPermitidos(regraAtual);

            var jogadas = new List<JogadaBot>();

            foreach (string dino in dinos)
            {
                foreach (string cercado in cercados)
                {
                    if (!CercadoAceitaDino(tabuleiro, cercado, dino))
                        continue;

                    int pontos = PontuarJogadaAvancada(tabuleiro, dino, cercado, estado);

                    jogadas.Add(new JogadaBot
                    {
                        Dino = dino,
                        Cercado = cercado,
                        Pontos = pontos
                    });
                }
            }

            // Ordenar por pontuação (maior melhor)
            var melhores = jogadas.OrderByDescending(j => j.Pontos).ToList();

            string log = $"Regra={regraAtual}, Turno={estado.TurnoAtual}, Rodada={estado.RodadaAtual}\n";
            log += $"Mão:\n{mao}\nTabuleiro:\n{tabuleiro}\n\nJogadas avaliadas:\n";

            foreach (var j in melhores.Take(5))
                log += $"{j.Dino} em {j.Cercado} -> score {j.Pontos}\n";

            // Tentar as melhores jogadas
            foreach (var jogada in melhores)
            {
                string resposta = Jogo.Jogar(idJogador, senhaJogador, jogada.Dino, jogada.Cercado);

                log += $"\nTentando: {jogada.Dino} em {jogada.Cercado} -> {resposta}";

                if (int.TryParse(resposta, out _))
                {
                    SalvarDebug(log + "\n✅ Jogada aceita!");
                    AtualizarTabuleiroServidor();
                    return true;
                }

                if (resposta.Contains("já realizou"))
                {
                    SalvarDebug(log + "\n⚠️ Já jogou neste turno.");
                    return true;
                }
            }

            SalvarDebug(log + "\n❌ Nenhuma jogada aceita.");
            return false;
        }

        // Obter estado atual do jogo a partir do servidor
        private EstadoJogo ObterEstadoJogo()
        {
            var estado = new EstadoJogo
            {
                TurnoAtual = 0,
                RodadaAtual = 1,
                IsUltimaRodada = false,
                DinosRestantes = new Dictionary<string, int>(),
                CercadosOcupacao = new Dictionary<string, int>()
            };

            try
            {
                string status = Jogo.VerificarPartida(idPartidaAtual);
                if (!string.IsNullOrWhiteSpace(status) && !status.Contains("ERRO"))
                {
                    string[] dados = status.Split(',');
                    if (dados.Length >= 2 && int.TryParse(dados[1].Trim(), out int turno))
                    {
                        estado.TurnoAtual = turno;

                        // Draftosaurus tipicamente tem 4 rodadas de 6 turnos
                        estado.RodadaAtual = (turno / 6) + 1;
                        estado.IsUltimaRodada = estado.RodadaAtual >= 4;
                    }
                }

                // Obter mão para ver dinos restantes
                string mao = Jogo.ExibirMao(idJogador, senhaJogador);
                if (!mao.Contains("ERRO"))
                {
                    string[] linhas = mao.Split('\n');
                    for (int i = 1; i < linhas.Length; i++)
                    {
                        string[] partes = linhas[i].Split(',');
                        if (partes.Length >= 2 && int.TryParse(partes[1], out int qtd))
                        {
                            estado.DinosRestantes[partes[0].Trim()] = qtd;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                SalvarDebug("Erro ao obter estado: " + ex.Message);
            }

            return estado;
        }
 

        private bool DinoExisteNoZoo(string tabuleiro, string dino)
        {
            foreach (string linha in tabuleiro.Split('\n'))
            {
                if (string.IsNullOrWhiteSpace(linha))
                    continue;

                string[] partes = linha.Split(',');

                if (partes.Length < 3)
                    continue;

                string dinoAtual = partes[1].Trim().ToUpper();

                if (dinoAtual == dino.Trim().ToUpper())
                    return true;
            }

            return false;
        }

        private void SalvarDebug(string texto)
        {
            string caminho = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "debug_draftosaurus.txt"
            );

            File.AppendAllText(
                caminho,
                "\n====================\n" +
                DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\n" +
                texto
            );
        }

        private bool CercadoAceitaDino(string tabuleiro, string cercado, string dino)
        {
            int qtdNoCercado = ContarDinosNoCercado(tabuleiro, cercado);
            bool temMesmoDino = CercadoTemDino(tabuleiro, cercado, dino);

            if (cercado == "RS" && qtdNoCercado >= 1)
                return false;

            if (cercado == "IS" && qtdNoCercado >= 1)
                return false;

            if (cercado == "CD" && temMesmoDino)
                return false;

            if (cercado == "FI" && qtdNoCercado > 0 && !temMesmoDino)
                return false;

            if (cercado == "RI" || cercado == "RIO")
                return true;
            return true;
        }

        private int ContarDinosNoCercado(string tabuleiro, string cercado)
        {
            int total = 0;

            foreach (string linha in tabuleiro.Split('\n'))
            {
                if (string.IsNullOrWhiteSpace(linha)) continue;

                string[] partes = linha.Split(',');

                if (partes.Length >= 3 &&
                    partes[0].Trim().ToUpper() == cercado &&
                    int.TryParse(partes[2].Trim(), out int qtd))
                {
                    total += qtd;
                }
            }

            return total;
        }

        private bool CercadoTemDino(string tabuleiro, string cercado, string dino)
        {
            foreach (string linha in tabuleiro.Split('\n'))
            {
                if (string.IsNullOrWhiteSpace(linha)) continue;

                string[] partes = linha.Split(',');

                if (partes.Length >= 3 &&
                    partes[0].Trim().ToUpper() == cercado &&
                    partes[1].Trim().ToUpper() == dino)
                {
                    return true;
                }
            }

            return false;
        }

        private string[] ObterDinosDisponiveis(string mao)
        {
            var lista = new System.Collections.Generic.List<string>();

            string[] linhas = mao.Split(
                new[] { "\r\n", "\n" },
                StringSplitOptions.RemoveEmptyEntries
            );

            for (int i = 1; i < linhas.Length; i++)
            {
                string[] partes = linhas[i].Split(',');

                if (partes.Length >= 2 &&
                    int.TryParse(partes[1], out int qtd) &&
                    qtd > 0)
                {
                    lista.Add(partes[0].Trim().ToUpper());
                }
            }

            return lista.ToArray();
        }
        
        private string[] ObterCercadosPermitidos(string regra)
        {
            regra = regra.Trim().ToUpper();

            switch (regra)
            {
                case "FL":
                    return new[] { "FI", "MT", "RS", "RI" };

                case "PR":
                    return new[] { "CD", "PA", "RI" };

                case "AL":
                    return new[] { "MT", "CD", "FI", "PA", "RI" };

                case "WC":
                    return new[] { "CD", "RS", "IS", "RI" };

                case "VZ":
                    return new[] { "CD", "PA", "FI", "MT", "RS", "IS", "RI" };

                case "TI":
                    return new[] { "PA", "CD", "FI", "MT", "RS", "IS", "RI" };

                default:
                    return new[] { "PA", "CD", "FI", "MT", "RS", "IS", "RI" };
            }
        }

     
        private void AtualizarTabuleiroServidor()
        {
            string tabuleiro = Jogo.ExibirTabuleiro(idJogador, senhaJogador);

            textBoxTabuleiro.Text = tabuleiro;

            DesenharTabuleiro(tabuleiro);
        }

        private void DesenharTabuleiro(string tabuleiro)
        {
            Limpar();

            foreach (string linha in tabuleiro.Split('\n'))
            {
                if (string.IsNullOrWhiteSpace(linha))
                    continue;

                string[] p = linha.Split(',');

                if (p.Length < 3)
                    continue;

                string cercado = p[0].Trim().ToUpper();
                string dino = p[1].Trim();

                if (!int.TryParse(p[2].Trim(), out int qtd))


                    continue;

                Panel destino = GetPanel(cercado);

                if (destino == null)
                    continue;

                for (int i = 0; i < qtd; i++)
                {
                    AddDino(destino, dino, i);
                }
            }
        }

        private void Limpar()
        {
            panelFI.Controls.Clear();
            panelRS.Controls.Clear();
            panelMT.Controls.Clear();
            panelIS.Controls.Clear();
            panelPA.Controls.Clear();
            panelCD.Controls.Clear();
            panelCD.Controls.Clear();
            panelRIO.Controls.Clear();
        }

        private Panel GetPanel(string codCercado)
        {
            switch (codCercado)
            {
                case "FI": return panelFI;
                case "RS": return panelRS;
                case "MT": return panelMT;
                case "IS": return panelIS;
                case "PA": return panelPA;
                case "CD": return panelCD;
                case "RI": return panelRIO; // novo
                default: return null;
            }
        }
        private void AddDino(Panel p, string d, int i)
        {
            if (p == null)
                return;

            if (string.IsNullOrWhiteSpace(d))
                return;

            d = d.Trim();

            string nomeArquivo = char.ToUpper(d[0]) + d.Substring(1).ToLower() + ".jpg";
            string caminho = Path.Combine(Application.StartupPath, "assets", nomeArquivo);

            PictureBox pb = new PictureBox
            {
                Width = 40,
                Height = 40,
                Left = (i % 4) * 45,
                Top = (i / 4) * 45,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (File.Exists(caminho))
                pb.Image = Image.FromFile(caminho);
            else
                pb.BackColor = Color.Red;

            p.Controls.Add(pb);
        }

        // ==========================
        // PROMPT
        // ==========================
        public string Prompt(string text, string caption)
        {
            Form f = new Form();
            TextBox t = new TextBox { Left = 10, Top = 10, Width = 200 };
            Button b = new Button { Text = "OK", Left = 10, Top = 40 };

            string result = "";

            b.Click += (s, e) => { result = t.Text; f.Close(); };

            f.Controls.Add(t);
            f.Controls.Add(b);

            f.ShowDialog();

            return result;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAcompanhar_Click(object sender, EventArgs e)
        {
            if (listBoxPartidas.SelectedItem == null)
            {
                MessageBox.Show("Selecione a partida primeiro.");
                return;
            }

            if (idJogador == 0 || string.IsNullOrWhiteSpace(senhaJogador))
            {
                MessageBox.Show("Entre na partida antes de acompanhar.");
                return;
            }

            timer1.Interval = 5000;
            timer1.Start();

            MessageBox.Show("Acompanhamento iniciado para o jogador ID: " + idJogador);

            timer1_Tick(sender, e);
        }

        private void buttonTestarMao_Click_Click(object sender, EventArgs e)
        {
            string mao = Jogo.ExibirMao(idJogador, senhaJogador);

            MessageBox.Show("Mão recebida:\n" + mao);

            textBoxDinossauros.Clear();
            textBoxDinossauros.Text = mao.Replace("\n", Environment.NewLine);
        }

        private void pictureBoxTabuleiro_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDino_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExportarHistorico_Click(object sender, EventArgs e)
        {
            if (listBoxPartidas.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma partida.");
                return;
            }

            int idPartida = int.Parse(listBoxPartidas.SelectedItem.ToString().Split('-')[0].Trim());

            string historico = Draft.Jogo.ListarHistorico(idPartida);

            string caminho = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "historico_draftosaurus.txt"
            );

            File.WriteAllText(caminho, historico);

            MessageBox.Show("Histórico salvo em:\n" + caminho);
        }

        private void panelRIO_Paint(object sender, PaintEventArgs e)
        {

        }
        private void SalvarPontuacaoEmArquivo(int idPartida)
        {
            string historico = Jogo.ListarHistorico(idPartida);

            string[] linhas = historico.Split('\n');

            bool capturandoPontuacao = false;

            List<string> resultado = new List<string>();

            resultado.Add("=======================================");
            resultado.Add("Partida: " + idPartida);
            resultado.Add("Data: " + DateTime.Now);
            resultado.Add("=======================================");

            foreach (string linhaOriginal in linhas)
            {
                string linha = linhaOriginal.Trim();

                if (linha.Contains("Pontuação dos Jogadores"))
                {
                    capturandoPontuacao = true;
                    continue;
                }

                if (capturandoPontuacao && string.IsNullOrWhiteSpace(linha))
                    break;

                if (capturandoPontuacao)
                {
                    resultado.Add(linha);
                }
            }

            if (resultado.Count <= 4)
            {
                resultado.Add("⚠️ Pontuação não encontrada.");
            }

            resultado.Add(""); // linha em branco

            string caminho = "historico_partidas.txt";

            File.AppendAllLines(caminho, resultado);

            SalvarDebug("Pontuação salva em arquivo: " + caminho);

            SalvarPontuacaoEmArquivo(idPartidaAtual);
        }

        private int CalcularPontuacao(string tabuleiro)
        {
            if (string.IsNullOrWhiteSpace(tabuleiro))
                return 0;

            var linhas = tabuleiro.Split('\n');

            // Estrutura: cercado -> lista de dinos
            Dictionary<string, List<string>> cercados = new Dictionary<string, List<string>>();

            foreach (var linha in linhas)
            {
                // Ex: CD,Br,1
                var partes = linha.Split(',');

                if (partes.Length < 3)
                    continue;

                string cercado = partes[0].Trim();
                string dino = partes[1].Trim();

                if (!int.TryParse(partes[2].Trim(), out int qtd))
                    continue;

                if (!cercados.ContainsKey(cercado))
                    cercados[cercado] = new List<string>();

                for (int i = 0; i < qtd; i++)
                    cercados[cercado].Add(dino);
            }

            int pontos = 0;

            foreach (var kv in cercados)
            {
                string c = kv.Key;
                var dinos = kv.Value;

                int count = dinos.Count;

                switch (c)
                {
                    case "CD": // Campina da Diferença
                        int especies = dinos.Distinct().Count();
                        int[] tabelaCD = { 0, 1, 3, 6, 10, 15, 21 };
                        if (especies < tabelaCD.Length)
                            pontos += tabelaCD[especies];
                        else
                            pontos += tabelaCD.Last();
                        break;

                    case "FI": // Floresta da Igualdade
                        int qtd = count;
                        int[] tabelaFI = { 0, 2, 4, 8, 12, 18, 24 };
                        if (qtd < tabelaFI.Length)
                            pontos += tabelaFI[qtd];
                        else
                            pontos += tabelaFI.Last();
                        break;

                    case "MT": // Mata Tripla
                        if (count == 3)
                            pontos += 7;
                        break;

                    case "PA": // Pradaria do Amor
                        var grupos = dinos.GroupBy(d => d);
                        foreach (var g in grupos)
                        {
                            int pares = g.Count() / 2;
                            pontos += pares * 5;
                        }
                        break;

                    case "RI": // Rio
                        pontos += count;
                        break;

                    case "IS": // Ilha Solitária
                        if (count == 1)
                        {
                            string especie = dinos[0];

                            int totalNoZoo = cercados.Values.SelectMany(x => x)
                                                            .Count(d => d == especie);

                            if (totalNoZoo == 1)
                                pontos += 7;
                        }
                        break;

                    case "RS":
                        // Não calculado (depende dos outros jogadores)
                        break;
                }
            }

            return pontos;
        }

        private void SalvarPontuacaoCalculada()
        {
            try
            {
                string tabuleiro = Jogo.ExibirTabuleiro(idJogador, senhaJogador);

                int pontos = CalcularPontuacao(tabuleiro);
                string pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string caminho = Path.Combine(pasta, "pontuacao_calculada.txt");

                List<string> linhas = new List<string>
        {
            "=======================================",
            "Partida: " + idPartidaAtual,
            "Jogador: " + idJogador,
            "Data: " + DateTime.Now,
            "Pontuação Calculada: " + pontos,
            "Tabuleiro:",
            tabuleiro,
            "=======================================",
            ""
        };

                File.AppendAllLines(caminho, linhas);

                SalvarDebug("Pontuação calculada salva em: " + caminho);
            }
            catch (Exception ex)
            {
                SalvarDebug("ERRO ao salvar pontuação calculada: " + ex.Message);
                MessageBox.Show("Erro ao salvar pontuação: " + ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonPausarTimer_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                buttonPausarTimer.Text = "Continuar Bot";
                SalvarDebug("Timer pausado.");
            }
            else
            {
                timer1.Start();
                buttonPausarTimer.Text = "Pausar Bot";
                SalvarDebug("Timer retomado.");
            }
        }

    }
}