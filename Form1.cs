using Draft;
using System;
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
                string nome = textBoxNomePartida.Text;
                string senha = textBoxSenhaPartida.Text;
 
                // Validação de tamanho conforme documentação
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

                // Cria a partida
                string retorno = Jogo.CriarPartida(nome, senha, GRUPO);

                // Divide a resposta do servidor
                string[] dados = retorno.Split(',');

                if (dados.Length >= 2)
                {
                    // Primeiro valor → ID do jogador
                    idJogadorCriador = int.Parse(dados[0]);

                    // Segundo valor → senha do jogador
                    senhaJogadorCriador = dados[1];

                    // Atualiza os labels no formulário
                    labelSenhaJogador.Text = "Senha Jogador: ******";
                    labelSenhaJogador.Text = "Senha Jogador: " + new string('*', senhaJogadorCriador.Length);
                    MessageBox.Show("Senha do jogador: " + new string('*', senhaJogadorCriador.Length));
                    AtualizarListaPartidas();
                }
                else
                {
                    MessageBox.Show("Resposta inesperada do servidor: " + retorno);
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
                    if (partes.Length >= 2)
                    {
                        string id = partes[0].Trim();      // Id da partida
                        string nome = partes[1].Trim();    // Nome da partida
                        listBoxPartidas.Items.Add($"{id} - {nome}");
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



        private void textBoxIdPartida_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNomeJogador_TextChanged(object sender, EventArgs e)
        {

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

                string idJogador = dados[0].Trim();
                string senhaJogador = dados[1].Trim();

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
    }
}