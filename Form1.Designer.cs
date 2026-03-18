using System.Windows.Forms;

namespace Projeto_Integrador3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelGrupo;
        private System.Windows.Forms.Label labelPartidas;

        private System.Windows.Forms.TextBox textBoxNomePartida;
        private System.Windows.Forms.TextBox textBoxSenhaPartida;

        private System.Windows.Forms.Button buttonCriarPartida;

        private System.Windows.Forms.ListBox listBoxPartidas;
        private System.Windows.Forms.PictureBox pictureBoxTabuleiro;
        private System.Windows.Forms.Button buttonVersao;
        private System.Windows.Forms.Button buttonListarPartidas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxTabuleiro = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonIniciarPartida = new System.Windows.Forms.Button();
            this.buttonMostrarJogadores = new System.Windows.Forms.Button();
            this.labelJogadores = new System.Windows.Forms.Label();
            this.listBoxJogadores = new System.Windows.Forms.ListBox();
            this.buttonEntrarPartida = new System.Windows.Forms.Button();
            this.buttonListarPartidas = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonVersao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxIdPartida = new System.Windows.Forms.TextBox();
            this.textBoxNomePartida = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxSenhaPartida = new System.Windows.Forms.TextBox();
            this.labelGrupo = new System.Windows.Forms.Label();
            this.buttonCriarPartida = new System.Windows.Forms.Button();
            this.labelPartidas = new System.Windows.Forms.Label();
            this.listBoxPartidas = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelIdJogador = new System.Windows.Forms.Label();
            this.labelSenhaJogador = new System.Windows.Forms.Label();
            this.labelDino = new System.Windows.Forms.Label();
            this.textBoxDinossauros = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelJogadorDaVez = new System.Windows.Forms.Label();
            this.labelDado = new System.Windows.Forms.Label();
            this.textBoxDino = new System.Windows.Forms.TextBox();
            this.textBoxCercado = new System.Windows.Forms.TextBox();
            this.buttonJogar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTabuleiro)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTabuleiro
            // 
            this.pictureBoxTabuleiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTabuleiro.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTabuleiro.Image")));
            this.pictureBoxTabuleiro.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTabuleiro.Name = "pictureBoxTabuleiro";
            this.pictureBoxTabuleiro.Size = new System.Drawing.Size(659, 600);
            this.pictureBoxTabuleiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTabuleiro.TabIndex = 0;
            this.pictureBoxTabuleiro.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.panelMenu.Controls.Add(this.label7);
            this.panelMenu.Controls.Add(this.label6);
            this.panelMenu.Controls.Add(this.buttonJogar);
            this.panelMenu.Controls.Add(this.textBoxCercado);
            this.panelMenu.Controls.Add(this.textBoxDino);
            this.panelMenu.Controls.Add(this.labelDado);
            this.panelMenu.Controls.Add(this.labelJogadorDaVez);
            this.panelMenu.Controls.Add(this.label5);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.textBoxDinossauros);
            this.panelMenu.Controls.Add(this.labelDino);
            this.panelMenu.Controls.Add(this.labelSenhaJogador);
            this.panelMenu.Controls.Add(this.labelIdJogador);
            this.panelMenu.Controls.Add(this.buttonIniciarPartida);
            this.panelMenu.Controls.Add(this.buttonMostrarJogadores);
            this.panelMenu.Controls.Add(this.labelJogadores);
            this.panelMenu.Controls.Add(this.listBoxJogadores);
            this.panelMenu.Controls.Add(this.buttonEntrarPartida);
            this.panelMenu.Controls.Add(this.buttonListarPartidas);
            this.panelMenu.Controls.Add(this.textBox3);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.textBox2);
            this.panelMenu.Controls.Add(this.buttonVersao);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.labelNome);
            this.panelMenu.Controls.Add(this.textBoxIdPartida);
            this.panelMenu.Controls.Add(this.textBoxNomePartida);
            this.panelMenu.Controls.Add(this.labelSenha);
            this.panelMenu.Controls.Add(this.textBoxSenhaPartida);
            this.panelMenu.Controls.Add(this.labelGrupo);
            this.panelMenu.Controls.Add(this.buttonCriarPartida);
            this.panelMenu.Controls.Add(this.labelPartidas);
            this.panelMenu.Controls.Add(this.listBoxPartidas);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(659, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(541, 600);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonIniciarPartida
            // 
            this.buttonIniciarPartida.BackColor = System.Drawing.Color.Silver;
            this.buttonIniciarPartida.Location = new System.Drawing.Point(299, 24);
            this.buttonIniciarPartida.Name = "buttonIniciarPartida";
            this.buttonIniciarPartida.Size = new System.Drawing.Size(106, 23);
            this.buttonIniciarPartida.TabIndex = 14;
            this.buttonIniciarPartida.Text = "Iniciar partida";
            this.buttonIniciarPartida.UseVisualStyleBackColor = false;
            this.buttonIniciarPartida.Click += new System.EventHandler(this.buttonIniciarPartida_Click);
            // 
            // buttonMostrarJogadores
            // 
            this.buttonMostrarJogadores.BackColor = System.Drawing.Color.Silver;
            this.buttonMostrarJogadores.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrarJogadores.Location = new System.Drawing.Point(146, 259);
            this.buttonMostrarJogadores.Name = "buttonMostrarJogadores";
            this.buttonMostrarJogadores.Size = new System.Drawing.Size(132, 23);
            this.buttonMostrarJogadores.TabIndex = 3;
            this.buttonMostrarJogadores.Text = "Mostrar jogadores";
            this.buttonMostrarJogadores.UseVisualStyleBackColor = false;
            this.buttonMostrarJogadores.Click += new System.EventHandler(this.buttonMostrarJogadores_Click);
            // 
            // labelJogadores
            // 
            this.labelJogadores.AutoSize = true;
            this.labelJogadores.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJogadores.Location = new System.Drawing.Point(160, 287);
            this.labelJogadores.Name = "labelJogadores";
            this.labelJogadores.Size = new System.Drawing.Size(70, 17);
            this.labelJogadores.TabIndex = 3;
            this.labelJogadores.Text = "Jogadores";
            // 
            // listBoxJogadores
            // 
            this.listBoxJogadores.FormattingEnabled = true;
            this.listBoxJogadores.ItemHeight = 16;
            this.listBoxJogadores.Location = new System.Drawing.Point(160, 309);
            this.listBoxJogadores.Name = "listBoxJogadores";
            this.listBoxJogadores.Size = new System.Drawing.Size(118, 196);
            this.listBoxJogadores.TabIndex = 12;
            this.listBoxJogadores.SelectedIndexChanged += new System.EventHandler(this.listBoxJogadores_SelectedIndexChanged);
            // 
            // buttonEntrarPartida
            // 
            this.buttonEntrarPartida.BackColor = System.Drawing.Color.LightGray;
            this.buttonEntrarPartida.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrarPartida.Location = new System.Drawing.Point(146, 201);
            this.buttonEntrarPartida.Name = "buttonEntrarPartida";
            this.buttonEntrarPartida.Size = new System.Drawing.Size(132, 23);
            this.buttonEntrarPartida.TabIndex = 8;
            this.buttonEntrarPartida.Text = "Entrar na Partida";
            this.buttonEntrarPartida.UseVisualStyleBackColor = false;
            this.buttonEntrarPartida.Click += new System.EventHandler(this.buttonEntrarPartida_Click);
            // 
            // buttonListarPartidas
            // 
            this.buttonListarPartidas.BackColor = System.Drawing.Color.LightGray;
            this.buttonListarPartidas.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListarPartidas.ForeColor = System.Drawing.Color.Black;
            this.buttonListarPartidas.Location = new System.Drawing.Point(6, 259);
            this.buttonListarPartidas.Name = "buttonListarPartidas";
            this.buttonListarPartidas.Size = new System.Drawing.Size(103, 23);
            this.buttonListarPartidas.TabIndex = 0;
            this.buttonListarPartidas.Text = "Listar Partidas";
            this.buttonListarPartidas.UseVisualStyleBackColor = false;
            this.buttonListarPartidas.Click += new System.EventHandler(this.buttonListarPartidas_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(98, 22);
            this.textBox3.TabIndex = 4;
            this.textBox3.UseSystemPasswordChar = true;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha da partida";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome do jogador";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonVersao
            // 
            this.buttonVersao.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonVersao.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVersao.ForeColor = System.Drawing.Color.Red;
            this.buttonVersao.Location = new System.Drawing.Point(12, 577);
            this.buttonVersao.Name = "buttonVersao";
            this.buttonVersao.Size = new System.Drawing.Size(100, 23);
            this.buttonVersao.TabIndex = 2;
            this.buttonVersao.Text = "1.0";
            this.buttonVersao.UseVisualStyleBackColor = false;
            this.buttonVersao.Click += new System.EventHandler(this.buttonVersao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID da Partida:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNome
            // 
            this.labelNome.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.Black;
            this.labelNome.Location = new System.Drawing.Point(12, 73);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(100, 23);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Nome da Partida";
            this.labelNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // textBoxIdPartida
            // 
            this.textBoxIdPartida.Location = new System.Drawing.Point(146, 35);
            this.textBoxIdPartida.Name = "textBoxIdPartida";
            this.textBoxIdPartida.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdPartida.TabIndex = 2;
            // 
            // textBoxNomePartida
            // 
            this.textBoxNomePartida.Location = new System.Drawing.Point(6, 100);
            this.textBoxNomePartida.Name = "textBoxNomePartida";
            this.textBoxNomePartida.Size = new System.Drawing.Size(103, 22);
            this.textBoxNomePartida.TabIndex = 4;
            // 
            // labelSenha
            // 
            this.labelSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.ForeColor = System.Drawing.Color.Black;
            this.labelSenha.Location = new System.Drawing.Point(6, 134);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(100, 23);
            this.labelSenha.TabIndex = 5;
            this.labelSenha.Text = "Senha";
            this.labelSenha.Click += new System.EventHandler(this.labelSenha_Click);
            // 
            // textBoxSenhaPartida
            // 
            this.textBoxSenhaPartida.Location = new System.Drawing.Point(6, 160);
            this.textBoxSenhaPartida.Name = "textBoxSenhaPartida";
            this.textBoxSenhaPartida.PasswordChar = '*';
            this.textBoxSenhaPartida.Size = new System.Drawing.Size(101, 22);
            this.textBoxSenhaPartida.TabIndex = 6;
            this.textBoxSenhaPartida.TextChanged += new System.EventHandler(this.textBoxSenhaPartida_TextChanged_1);
            // 
            // labelGrupo
            // 
            this.labelGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrupo.ForeColor = System.Drawing.Color.Black;
            this.labelGrupo.Location = new System.Drawing.Point(6, 35);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(128, 23);
            this.labelGrupo.TabIndex = 7;
            this.labelGrupo.Click += new System.EventHandler(this.labelGrupo_Click);
            // 
            // buttonCriarPartida
            // 
            this.buttonCriarPartida.BackColor = System.Drawing.Color.Silver;
            this.buttonCriarPartida.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriarPartida.Location = new System.Drawing.Point(6, 201);
            this.buttonCriarPartida.Name = "buttonCriarPartida";
            this.buttonCriarPartida.Size = new System.Drawing.Size(103, 23);
            this.buttonCriarPartida.TabIndex = 9;
            this.buttonCriarPartida.Text = "Criar Partida";
            this.buttonCriarPartida.UseVisualStyleBackColor = false;
            this.buttonCriarPartida.Click += new System.EventHandler(this.buttonCriarPartida_Click);
            // 
            // labelPartidas
            // 
            this.labelPartidas.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPartidas.ForeColor = System.Drawing.Color.Black;
            this.labelPartidas.Location = new System.Drawing.Point(12, 287);
            this.labelPartidas.Name = "labelPartidas";
            this.labelPartidas.Size = new System.Drawing.Size(100, 23);
            this.labelPartidas.TabIndex = 10;
            this.labelPartidas.Text = "Partidas";
            this.labelPartidas.Click += new System.EventHandler(this.labelPartidas_Click);
            // 
            // listBoxPartidas
            // 
            this.listBoxPartidas.ItemHeight = 16;
            this.listBoxPartidas.Location = new System.Drawing.Point(6, 311);
            this.listBoxPartidas.Name = "listBoxPartidas";
            this.listBoxPartidas.Size = new System.Drawing.Size(148, 196);
            this.listBoxPartidas.TabIndex = 11;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(1199, 305);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(8, 4);
            this.listBox1.TabIndex = 2;
            // 
            // labelIdJogador
            // 
            this.labelIdJogador.AutoSize = true;
            this.labelIdJogador.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdJogador.Location = new System.Drawing.Point(257, 520);
            this.labelIdJogador.Name = "labelIdJogador";
            this.labelIdJogador.Size = new System.Drawing.Size(98, 21);
            this.labelIdJogador.TabIndex = 15;
            this.labelIdJogador.Text = "ID Jogador:";
            this.labelIdJogador.Click += new System.EventHandler(this.labelIdJogador_Click);
            // 
            // labelSenhaJogador
            // 
            this.labelSenhaJogador.AutoSize = true;
            this.labelSenhaJogador.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenhaJogador.Location = new System.Drawing.Point(257, 541);
            this.labelSenhaJogador.Name = "labelSenhaJogador";
            this.labelSenhaJogador.Size = new System.Drawing.Size(133, 21);
            this.labelSenhaJogador.TabIndex = 16;
            this.labelSenhaJogador.Text = "Senha Jogador: ";
            this.labelSenhaJogador.Click += new System.EventHandler(this.labelSenhaJogador_Click);
            // 
            // labelDino
            // 
            this.labelDino.AutoSize = true;
            this.labelDino.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDino.Location = new System.Drawing.Point(281, 287);
            this.labelDino.Name = "labelDino";
            this.labelDino.Size = new System.Drawing.Size(82, 17);
            this.labelDino.TabIndex = 17;
            this.labelDino.Text = "Dinossauros";
            // 
            // textBoxDinossauros
            // 
            this.textBoxDinossauros.Location = new System.Drawing.Point(284, 311);
            this.textBoxDinossauros.Multiline = true;
            this.textBoxDinossauros.Name = "textBoxDinossauros";
            this.textBoxDinossauros.ReadOnly = true;
            this.textBoxDinossauros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDinossauros.Size = new System.Drawing.Size(135, 196);
            this.textBoxDinossauros.TabIndex = 19;
            this.textBoxDinossauros.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Grupo: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 558);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Versão DLL:";
            // 
            // labelJogadorDaVez
            // 
            this.labelJogadorDaVez.AutoSize = true;
            this.labelJogadorDaVez.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJogadorDaVez.Location = new System.Drawing.Point(296, 73);
            this.labelJogadorDaVez.Name = "labelJogadorDaVez";
            this.labelJogadorDaVez.Size = new System.Drawing.Size(101, 17);
            this.labelJogadorDaVez.TabIndex = 22;
            this.labelJogadorDaVez.Text = "Jogador Da Vez";
            // 
            // labelDado
            // 
            this.labelDado.AutoSize = true;
            this.labelDado.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDado.Location = new System.Drawing.Point(296, 102);
            this.labelDado.Name = "labelDado";
            this.labelDado.Size = new System.Drawing.Size(91, 17);
            this.labelDado.TabIndex = 23;
            this.labelDado.Text = "Face do Dado";
            // 
            // textBoxDino
            // 
            this.textBoxDino.Location = new System.Drawing.Point(299, 154);
            this.textBoxDino.Name = "textBoxDino";
            this.textBoxDino.Size = new System.Drawing.Size(93, 22);
            this.textBoxDino.TabIndex = 24;
            // 
            // textBoxCercado
            // 
            this.textBoxCercado.Location = new System.Drawing.Point(299, 203);
            this.textBoxCercado.Name = "textBoxCercado";
            this.textBoxCercado.Size = new System.Drawing.Size(93, 22);
            this.textBoxCercado.TabIndex = 25;
            // 
            // buttonJogar
            // 
            this.buttonJogar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJogar.Location = new System.Drawing.Point(299, 241);
            this.buttonJogar.Name = "buttonJogar";
            this.buttonJogar.Size = new System.Drawing.Size(95, 31);
            this.buttonJogar.TabIndex = 26;
            this.buttonJogar.Text = "Jogar";
            this.buttonJogar.UseVisualStyleBackColor = true;
            this.buttonJogar.Click += new System.EventHandler(this.buttonJogar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(296, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Dino";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(296, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cercado";
            // 
            // Form1
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBoxTabuleiro);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Projeto Integrador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTabuleiro)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        private TextBox textBoxIdPartida;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonEntrarPartida;
        private ListBox listBox1;
        private Label labelJogadores;
        private ListBox listBoxJogadores;
        private Button buttonMostrarJogadores;
        private Button buttonIniciarPartida;
        private Label labelSenhaJogador;
        private Label labelIdJogador;
        private Label labelDino;
        private TextBox textBoxDinossauros;
        private Label label4;
        private Label label5;
        private Label labelDado;
        private Label labelJogadorDaVez;
        private TextBox textBoxCercado;
        private TextBox textBoxDino;
        private Button buttonJogar;
        private Label label7;
        private Label label6;
    }
}