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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonJogar = new System.Windows.Forms.Button();
            this.textBoxCercado = new System.Windows.Forms.TextBox();
            this.textBoxDino = new System.Windows.Forms.TextBox();
            this.labelDado = new System.Windows.Forms.Label();
            this.labelJogadorDaVez = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDinossauros = new System.Windows.Forms.TextBox();
            this.labelDino = new System.Windows.Forms.Label();
            this.labelSenhaJogador = new System.Windows.Forms.Label();
            this.labelIdJogador = new System.Windows.Forms.Label();
            this.buttonIniciarPartida = new System.Windows.Forms.Button();
            this.buttonMostrarJogadores = new System.Windows.Forms.Button();
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
            this.listBoxPartidas = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTabuleiro)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel7.SuspendLayout();
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
            this.panelMenu.Controls.Add(this.panel7);
            this.panelMenu.Controls.Add(this.groupBox7);
            this.panelMenu.Controls.Add(this.groupBox6);
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.groupBox5);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.groupBox4);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.groupBox3);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.groupBox2);
            this.panelMenu.Controls.Add(this.panelContainer);
            this.panelMenu.Controls.Add(this.groupBox1);
            this.panelMenu.Controls.Add(this.label5);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.labelDino);
            this.panelMenu.Controls.Add(this.labelSenhaJogador);
            this.panelMenu.Controls.Add(this.labelIdJogador);
            this.panelMenu.Controls.Add(this.buttonVersao);
            this.panelMenu.Controls.Add(this.labelGrupo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(659, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(541, 600);
            this.panelMenu.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Código do Cercado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Código do Dino";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // buttonJogar
            // 
            this.buttonJogar.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonJogar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJogar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonJogar.Location = new System.Drawing.Point(15, 98);
            this.buttonJogar.Name = "buttonJogar";
            this.buttonJogar.Size = new System.Drawing.Size(229, 48);
            this.buttonJogar.TabIndex = 26;
            this.buttonJogar.Text = "Jogar";
            this.buttonJogar.UseVisualStyleBackColor = false;
            this.buttonJogar.Click += new System.EventHandler(this.buttonJogar_Click);
            // 
            // textBoxCercado
            // 
            this.textBoxCercado.Location = new System.Drawing.Point(142, 70);
            this.textBoxCercado.Name = "textBoxCercado";
            this.textBoxCercado.Size = new System.Drawing.Size(93, 22);
            this.textBoxCercado.TabIndex = 25;
            // 
            // textBoxDino
            // 
            this.textBoxDino.Location = new System.Drawing.Point(142, 29);
            this.textBoxDino.Name = "textBoxDino";
            this.textBoxDino.Size = new System.Drawing.Size(93, 22);
            this.textBoxDino.TabIndex = 24;
            // 
            // labelDado
            // 
            this.labelDado.AutoSize = true;
            this.labelDado.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDado.Location = new System.Drawing.Point(9, 71);
            this.labelDado.Name = "labelDado";
            this.labelDado.Size = new System.Drawing.Size(91, 17);
            this.labelDado.TabIndex = 23;
            this.labelDado.Text = "Face do Dado";
            // 
            // labelJogadorDaVez
            // 
            this.labelJogadorDaVez.AutoSize = true;
            this.labelJogadorDaVez.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJogadorDaVez.Location = new System.Drawing.Point(7, 45);
            this.labelJogadorDaVez.Name = "labelJogadorDaVez";
            this.labelJogadorDaVez.Size = new System.Drawing.Size(101, 17);
            this.labelJogadorDaVez.TabIndex = 22;
            this.labelJogadorDaVez.Text = "Jogador Da Vez";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 558);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Versão DLL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Grupo: ";
            // 
            // textBoxDinossauros
            // 
            this.textBoxDinossauros.Location = new System.Drawing.Point(0, 35);
            this.textBoxDinossauros.Multiline = true;
            this.textBoxDinossauros.Name = "textBoxDinossauros";
            this.textBoxDinossauros.ReadOnly = true;
            this.textBoxDinossauros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDinossauros.Size = new System.Drawing.Size(171, 111);
            this.textBoxDinossauros.TabIndex = 19;
            this.textBoxDinossauros.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelDino
            // 
            this.labelDino.AutoSize = true;
            this.labelDino.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDino.Location = new System.Drawing.Point(305, 368);
            this.labelDino.Name = "labelDino";
            this.labelDino.Size = new System.Drawing.Size(82, 17);
            this.labelDino.TabIndex = 17;
            this.labelDino.Text = "Dinossauros";
            this.labelDino.Click += new System.EventHandler(this.labelDino_Click);
            // 
            // labelSenhaJogador
            // 
            this.labelSenhaJogador.AutoSize = true;
            this.labelSenhaJogador.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenhaJogador.Location = new System.Drawing.Point(131, 558);
            this.labelSenhaJogador.Name = "labelSenhaJogador";
            this.labelSenhaJogador.Size = new System.Drawing.Size(106, 17);
            this.labelSenhaJogador.TabIndex = 16;
            this.labelSenhaJogador.Text = "Senha Jogador: ";
            this.labelSenhaJogador.Click += new System.EventHandler(this.labelSenhaJogador_Click);
            // 
            // labelIdJogador
            // 
            this.labelIdJogador.AutoSize = true;
            this.labelIdJogador.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdJogador.Location = new System.Drawing.Point(136, 577);
            this.labelIdJogador.Name = "labelIdJogador";
            this.labelIdJogador.Size = new System.Drawing.Size(78, 17);
            this.labelIdJogador.TabIndex = 15;
            this.labelIdJogador.Text = "ID Jogador:";
            this.labelIdJogador.Click += new System.EventHandler(this.labelIdJogador_Click);
            // 
            // buttonIniciarPartida
            // 
            this.buttonIniciarPartida.BackColor = System.Drawing.Color.Silver;
            this.buttonIniciarPartida.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciarPartida.Location = new System.Drawing.Point(136, 179);
            this.buttonIniciarPartida.Name = "buttonIniciarPartida";
            this.buttonIniciarPartida.Size = new System.Drawing.Size(106, 32);
            this.buttonIniciarPartida.TabIndex = 14;
            this.buttonIniciarPartida.Text = "Iniciar partida";
            this.buttonIniciarPartida.UseVisualStyleBackColor = false;
            this.buttonIniciarPartida.Click += new System.EventHandler(this.buttonIniciarPartida_Click);
            // 
            // buttonMostrarJogadores
            // 
            this.buttonMostrarJogadores.BackColor = System.Drawing.Color.Silver;
            this.buttonMostrarJogadores.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrarJogadores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMostrarJogadores.Location = new System.Drawing.Point(6, 6);
            this.buttonMostrarJogadores.Name = "buttonMostrarJogadores";
            this.buttonMostrarJogadores.Size = new System.Drawing.Size(132, 23);
            this.buttonMostrarJogadores.TabIndex = 3;
            this.buttonMostrarJogadores.Text = "Mostrar jogadores";
            this.buttonMostrarJogadores.UseVisualStyleBackColor = false;
            this.buttonMostrarJogadores.Click += new System.EventHandler(this.buttonMostrarJogadores_Click);
            // 
            // listBoxJogadores
            // 
            this.listBoxJogadores.FormattingEnabled = true;
            this.listBoxJogadores.ItemHeight = 16;
            this.listBoxJogadores.Location = new System.Drawing.Point(0, 33);
            this.listBoxJogadores.Name = "listBoxJogadores";
            this.listBoxJogadores.Size = new System.Drawing.Size(168, 116);
            this.listBoxJogadores.TabIndex = 12;
            this.listBoxJogadores.SelectedIndexChanged += new System.EventHandler(this.listBoxJogadores_SelectedIndexChanged);
            // 
            // buttonEntrarPartida
            // 
            this.buttonEntrarPartida.BackColor = System.Drawing.Color.LightGray;
            this.buttonEntrarPartida.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrarPartida.Location = new System.Drawing.Point(122, 173);
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
            this.buttonListarPartidas.Location = new System.Drawing.Point(6, 6);
            this.buttonListarPartidas.Name = "buttonListarPartidas";
            this.buttonListarPartidas.Size = new System.Drawing.Size(103, 23);
            this.buttonListarPartidas.TabIndex = 0;
            this.buttonListarPartidas.Text = "Listar Partidas";
            this.buttonListarPartidas.UseVisualStyleBackColor = false;
            this.buttonListarPartidas.Click += new System.EventHandler(this.buttonListarPartidas_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 128);
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
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha da partida";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome do jogador";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 84);
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
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID da Partida:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNome
            // 
            this.labelNome.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.Black;
            this.labelNome.Location = new System.Drawing.Point(2, 46);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(122, 23);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Nome da Partida";
            this.labelNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // textBoxIdPartida
            // 
            this.textBoxIdPartida.Location = new System.Drawing.Point(139, 34);
            this.textBoxIdPartida.Name = "textBoxIdPartida";
            this.textBoxIdPartida.Size = new System.Drawing.Size(98, 22);
            this.textBoxIdPartida.TabIndex = 2;
            // 
            // textBoxNomePartida
            // 
            this.textBoxNomePartida.Location = new System.Drawing.Point(133, 44);
            this.textBoxNomePartida.Name = "textBoxNomePartida";
            this.textBoxNomePartida.Size = new System.Drawing.Size(103, 22);
            this.textBoxNomePartida.TabIndex = 4;
            // 
            // labelSenha
            // 
            this.labelSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.ForeColor = System.Drawing.Color.Black;
            this.labelSenha.Location = new System.Drawing.Point(3, 69);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(100, 23);
            this.labelSenha.TabIndex = 5;
            this.labelSenha.Text = "Senha";
            this.labelSenha.Click += new System.EventHandler(this.labelSenha_Click);
            // 
            // textBoxSenhaPartida
            // 
            this.textBoxSenhaPartida.Location = new System.Drawing.Point(133, 72);
            this.textBoxSenhaPartida.Name = "textBoxSenhaPartida";
            this.textBoxSenhaPartida.PasswordChar = '*';
            this.textBoxSenhaPartida.Size = new System.Drawing.Size(101, 22);
            this.textBoxSenhaPartida.TabIndex = 6;
            this.textBoxSenhaPartida.TextChanged += new System.EventHandler(this.textBoxSenhaPartida_TextChanged_1);
            // 
            // labelGrupo
            // 
            this.labelGrupo.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrupo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelGrupo.Location = new System.Drawing.Point(360, 555);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(178, 36);
            this.labelGrupo.TabIndex = 7;
            this.labelGrupo.Click += new System.EventHandler(this.labelGrupo_Click);
            // 
            // buttonCriarPartida
            // 
            this.buttonCriarPartida.BackColor = System.Drawing.Color.Silver;
            this.buttonCriarPartida.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriarPartida.Location = new System.Drawing.Point(133, 100);
            this.buttonCriarPartida.Name = "buttonCriarPartida";
            this.buttonCriarPartida.Size = new System.Drawing.Size(103, 23);
            this.buttonCriarPartida.TabIndex = 9;
            this.buttonCriarPartida.Text = "Criar Partida";
            this.buttonCriarPartida.UseVisualStyleBackColor = false;
            this.buttonCriarPartida.Click += new System.EventHandler(this.buttonCriarPartida_Click);
            // 
            // listBoxPartidas
            // 
            this.listBoxPartidas.ItemHeight = 16;
            this.listBoxPartidas.Location = new System.Drawing.Point(0, 35);
            this.listBoxPartidas.Name = "listBoxPartidas";
            this.listBoxPartidas.Size = new System.Drawing.Size(168, 116);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonJogar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxDino);
            this.groupBox1.Controls.Add(this.textBoxCercado);
            this.groupBox1.Location = new System.Drawing.Point(277, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 152);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.SteelBlue;
            this.panelContainer.Controls.Add(this.label8);
            this.panelContainer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelContainer.Location = new System.Drawing.Point(277, 220);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(254, 34);
            this.panelContainer.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SteelBlue;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(8, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sua Jogada";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelJogadorDaVez);
            this.groupBox2.Controls.Add(this.labelDado);
            this.groupBox2.Location = new System.Drawing.Point(3, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 165);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label11);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(3, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 34);
            this.panel1.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SteelBlue;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(8, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Sua Jogada";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxIdPartida);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.buttonEntrarPartida);
            this.groupBox3.Location = new System.Drawing.Point(277, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 202);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label10);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(277, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 34);
            this.panel2.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SteelBlue;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(5, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Inserir Jogador";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Controls.Add(this.buttonCriarPartida);
            this.groupBox4.Controls.Add(this.buttonIniciarPartida);
            this.groupBox4.Controls.Add(this.labelNome);
            this.groupBox4.Controls.Add(this.textBoxNomePartida);
            this.groupBox4.Controls.Add(this.labelSenha);
            this.groupBox4.Controls.Add(this.textBoxSenhaPartida);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(270, 219);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.label9);
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 34);
            this.panel3.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SteelBlue;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(3, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Criar Partida";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.label12);
            this.panel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(3, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 34);
            this.panel4.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.SteelBlue;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(3, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Iniciar Partida";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBoxPartidas);
            this.groupBox5.Location = new System.Drawing.Point(3, 403);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(168, 152);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.buttonListarPartidas);
            this.panel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Location = new System.Drawing.Point(3, 403);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(168, 34);
            this.panel5.TabIndex = 32;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.panel6);
            this.groupBox6.Controls.Add(this.listBoxJogadores);
            this.groupBox6.Location = new System.Drawing.Point(181, 402);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(167, 152);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Controls.Add(this.buttonMostrarJogadores);
            this.panel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Location = new System.Drawing.Point(0, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(168, 34);
            this.panel6.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(9, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listar Dinossauros";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxDinossauros);
            this.groupBox7.Location = new System.Drawing.Point(358, 403);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(171, 152);
            this.groupBox7.TabIndex = 31;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SteelBlue;
            this.panel7.Controls.Add(this.button1);
            this.panel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel7.Location = new System.Drawing.Point(355, 403);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(174, 34);
            this.panel7.TabIndex = 34;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.panel7.ResumeLayout(false);
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
        private GroupBox groupBox1;
        private Panel panelContainer;
        private Label label8;
        private GroupBox groupBox2;
        private Panel panel1;
        private Label label11;
        private Panel panel2;
        private Label label10;
        private GroupBox groupBox3;
        private Panel panel3;
        private Label label9;
        private GroupBox groupBox4;
        private Panel panel4;
        private Label label12;
        private Panel panel5;
        private GroupBox groupBox5;
        private Button button1;
        private GroupBox groupBox6;
        private Panel panel6;
        private GroupBox groupBox7;
        private Panel panel7;
    }
}