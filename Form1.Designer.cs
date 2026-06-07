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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonPausarTimer = new System.Windows.Forms.Button();
            this.buttonAcompanhar = new System.Windows.Forms.Button();
            this.buttonExportarHistorico = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBoxTabuleiro = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelTurno = new System.Windows.Forms.Label();
            this.labelJogadorDaVez = new System.Windows.Forms.Label();
            this.labelDado = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxDinossauros = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonMostrarJogadores = new System.Windows.Forms.Button();
            this.listBoxJogadores = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonListarPartidas = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBoxPartidas = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCriarPartida = new System.Windows.Forms.Button();
            this.buttonIniciarPartida = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNomePartida = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxSenhaPartida = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdPartida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeJogador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.senhaPartida = new System.Windows.Forms.TextBox();
            this.buttonEntrarPartida = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonJogar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDino = new System.Windows.Forms.TextBox();
            this.textBoxCercado = new System.Windows.Forms.TextBox();
            this.labelDino = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSenhaJogador = new System.Windows.Forms.Label();
            this.labelIdJogador = new System.Windows.Forms.Label();
            this.buttonVersao = new System.Windows.Forms.Button();
            this.labelGrupo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMT = new System.Windows.Forms.Panel();
            this.panelPA = new System.Windows.Forms.Panel();
            this.panelCD = new System.Windows.Forms.Panel();
            this.panelRS = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelFI = new System.Windows.Forms.Panel();
            this.panelIS = new System.Windows.Forms.Panel();
            this.panelTabuleiro = new System.Windows.Forms.Panel();
            this.panelRIO = new System.Windows.Forms.Panel();
            this.pictureBoxTabuleiro = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelTabuleiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTabuleiro)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSize = true;
            this.panelMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.panelMenu.Controls.Add(this.buttonPausarTimer);
            this.panelMenu.Controls.Add(this.buttonAcompanhar);
            this.panelMenu.Controls.Add(this.buttonExportarHistorico);
            this.panelMenu.Controls.Add(this.panel8);
            this.panelMenu.Controls.Add(this.groupBox8);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.groupBox2);
            this.panelMenu.Controls.Add(this.panel7);
            this.panelMenu.Controls.Add(this.groupBox7);
            this.panelMenu.Controls.Add(this.groupBox6);
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.groupBox5);
            this.panelMenu.Controls.Add(this.panel4);
            this.panelMenu.Controls.Add(this.groupBox4);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.groupBox3);
            this.panelMenu.Controls.Add(this.panelContainer);
            this.panelMenu.Controls.Add(this.groupBox1);
            this.panelMenu.Controls.Add(this.label5);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.labelSenhaJogador);
            this.panelMenu.Controls.Add(this.labelIdJogador);
            this.panelMenu.Controls.Add(this.buttonVersao);
            this.panelMenu.Controls.Add(this.labelGrupo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(951, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(542, 753);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonPausarTimer
            // 
            this.buttonPausarTimer.Location = new System.Drawing.Point(326, 689);
            this.buttonPausarTimer.Name = "buttonPausarTimer";
            this.buttonPausarTimer.Size = new System.Drawing.Size(75, 23);
            this.buttonPausarTimer.TabIndex = 42;
            this.buttonPausarTimer.Text = "StopStart";
            this.buttonPausarTimer.UseVisualStyleBackColor = true;
            this.buttonPausarTimer.Click += new System.EventHandler(this.buttonPausarTimer_Click);
            // 
            // buttonAcompanhar
            // 
            this.buttonAcompanhar.Location = new System.Drawing.Point(30, 689);
            this.buttonAcompanhar.Name = "buttonAcompanhar";
            this.buttonAcompanhar.Size = new System.Drawing.Size(112, 23);
            this.buttonAcompanhar.TabIndex = 41;
            this.buttonAcompanhar.Text = "Acompanhar Partida";
            this.buttonAcompanhar.UseVisualStyleBackColor = true;
            this.buttonAcompanhar.Click += new System.EventHandler(this.buttonAcompanhar_Click);
            // 
            // buttonExportarHistorico
            // 
            this.buttonExportarHistorico.Location = new System.Drawing.Point(196, 689);
            this.buttonExportarHistorico.Name = "buttonExportarHistorico";
            this.buttonExportarHistorico.Size = new System.Drawing.Size(75, 23);
            this.buttonExportarHistorico.TabIndex = 40;
            this.buttonExportarHistorico.Text = "Exportar";
            this.buttonExportarHistorico.UseVisualStyleBackColor = true;
            this.buttonExportarHistorico.Click += new System.EventHandler(this.buttonExportarHistorico_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SteelBlue;
            this.panel8.Controls.Add(this.button2);
            this.panel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel8.Location = new System.Drawing.Point(272, 276);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(263, 28);
            this.panel8.TabIndex = 38;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(9, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 22);
            this.button2.TabIndex = 0;
            this.button2.Text = "Meu tabuleiro";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBoxTabuleiro);
            this.groupBox8.Location = new System.Drawing.Point(272, 274);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(263, 118);
            this.groupBox8.TabIndex = 37;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "groupBox8";
            // 
            // textBoxTabuleiro
            // 
            this.textBoxTabuleiro.Location = new System.Drawing.Point(0, 31);
            this.textBoxTabuleiro.Multiline = true;
            this.textBoxTabuleiro.Name = "textBoxTabuleiro";
            this.textBoxTabuleiro.ReadOnly = true;
            this.textBoxTabuleiro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTabuleiro.Size = new System.Drawing.Size(263, 85);
            this.textBoxTabuleiro.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label11);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(277, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 34);
            this.panel1.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SteelBlue;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(8, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Jogadores";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelTurno);
            this.groupBox2.Controls.Add(this.labelJogadorDaVez);
            this.groupBox2.Controls.Add(this.labelDado);
            this.groupBox2.Location = new System.Drawing.Point(277, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 111);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // labelTurno
            // 
            this.labelTurno.AutoSize = true;
            this.labelTurno.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurno.Location = new System.Drawing.Point(9, 79);
            this.labelTurno.Name = "labelTurno";
            this.labelTurno.Size = new System.Drawing.Size(43, 17);
            this.labelTurno.TabIndex = 24;
            this.labelTurno.Text = "Turno";
            // 
            // labelJogadorDaVez
            // 
            this.labelJogadorDaVez.AutoSize = true;
            this.labelJogadorDaVez.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJogadorDaVez.Location = new System.Drawing.Point(6, 37);
            this.labelJogadorDaVez.Name = "labelJogadorDaVez";
            this.labelJogadorDaVez.Size = new System.Drawing.Size(101, 17);
            this.labelJogadorDaVez.TabIndex = 22;
            this.labelJogadorDaVez.Text = "Jogador Da Vez";
            // 
            // labelDado
            // 
            this.labelDado.AutoSize = true;
            this.labelDado.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDado.Location = new System.Drawing.Point(6, 58);
            this.labelDado.Name = "labelDado";
            this.labelDado.Size = new System.Drawing.Size(91, 17);
            this.labelDado.TabIndex = 23;
            this.labelDado.Text = "Face do Dado";
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(9, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dinossauros em mão";
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
            // textBoxDinossauros
            // 
            this.textBoxDinossauros.Location = new System.Drawing.Point(0, 35);
            this.textBoxDinossauros.Multiline = true;
            this.textBoxDinossauros.Name = "textBoxDinossauros";
            this.textBoxDinossauros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDinossauros.Size = new System.Drawing.Size(171, 84);
            this.textBoxDinossauros.TabIndex = 19;
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
            // buttonMostrarJogadores
            // 
            this.buttonMostrarJogadores.BackColor = System.Drawing.Color.Silver;
            this.buttonMostrarJogadores.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrarJogadores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMostrarJogadores.Location = new System.Drawing.Point(6, 6);
            this.buttonMostrarJogadores.Name = "buttonMostrarJogadores";
            this.buttonMostrarJogadores.Size = new System.Drawing.Size(132, 23);
            this.buttonMostrarJogadores.TabIndex = 3;
            this.buttonMostrarJogadores.Text = "jogadores";
            this.buttonMostrarJogadores.UseVisualStyleBackColor = false;
            this.buttonMostrarJogadores.Click += new System.EventHandler(this.buttonMostrarJogadores_Click);
            // 
            // listBoxJogadores
            // 
            this.listBoxJogadores.FormattingEnabled = true;
            this.listBoxJogadores.ItemHeight = 16;
            this.listBoxJogadores.Location = new System.Drawing.Point(0, 33);
            this.listBoxJogadores.Name = "listBoxJogadores";
            this.listBoxJogadores.Size = new System.Drawing.Size(168, 84);
            this.listBoxJogadores.TabIndex = 12;
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
            // buttonListarPartidas
            // 
            this.buttonListarPartidas.BackColor = System.Drawing.Color.LightGray;
            this.buttonListarPartidas.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListarPartidas.ForeColor = System.Drawing.Color.Black;
            this.buttonListarPartidas.Location = new System.Drawing.Point(6, 6);
            this.buttonListarPartidas.Name = "buttonListarPartidas";
            this.buttonListarPartidas.Size = new System.Drawing.Size(103, 23);
            this.buttonListarPartidas.TabIndex = 0;
            this.buttonListarPartidas.Text = " Partidas";
            this.buttonListarPartidas.UseVisualStyleBackColor = false;
            this.buttonListarPartidas.Click += new System.EventHandler(this.buttonListarPartidas_Click);
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
            // listBoxPartidas
            // 
            this.listBoxPartidas.ItemHeight = 16;
            this.listBoxPartidas.Location = new System.Drawing.Point(0, 35);
            this.listBoxPartidas.Name = "listBoxPartidas";
            this.listBoxPartidas.Size = new System.Drawing.Size(168, 84);
            this.listBoxPartidas.TabIndex = 11;
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
            this.label12.Size = new System.Drawing.Size(122, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Iniciar Partida";
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
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
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
            this.label9.Size = new System.Drawing.Size(112, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Criar Partida";
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
            // labelNome
            // 
            this.labelNome.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.Black;
            this.labelNome.Location = new System.Drawing.Point(2, 46);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(122, 23);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Nome da Partida";
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
            // 
            // textBoxSenhaPartida
            // 
            this.textBoxSenhaPartida.Location = new System.Drawing.Point(133, 72);
            this.textBoxSenhaPartida.Name = "textBoxSenhaPartida";
            this.textBoxSenhaPartida.PasswordChar = '*';
            this.textBoxSenhaPartida.Size = new System.Drawing.Size(101, 22);
            this.textBoxSenhaPartida.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label10);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(277, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 31);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxIdPartida);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.nomeJogador);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.senhaPartida);
            this.groupBox3.Controls.Add(this.buttonEntrarPartida);
            this.groupBox3.Location = new System.Drawing.Point(278, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 148);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID da Partida:";
            // 
            // textBoxIdPartida
            // 
            this.textBoxIdPartida.Location = new System.Drawing.Point(150, 23);
            this.textBoxIdPartida.Name = "textBoxIdPartida";
            this.textBoxIdPartida.Size = new System.Drawing.Size(98, 22);
            this.textBoxIdPartida.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome do jogador";
            // 
            // nomeJogador
            // 
            this.nomeJogador.Location = new System.Drawing.Point(150, 47);
            this.nomeJogador.Name = "nomeJogador";
            this.nomeJogador.Size = new System.Drawing.Size(98, 22);
            this.nomeJogador.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha da partida";
            // 
            // senhaPartida
            // 
            this.senhaPartida.AcceptsReturn = true;
            this.senhaPartida.Location = new System.Drawing.Point(150, 73);
            this.senhaPartida.Name = "senhaPartida";
            this.senhaPartida.Size = new System.Drawing.Size(98, 22);
            this.senhaPartida.TabIndex = 4;
            this.senhaPartida.UseSystemPasswordChar = true;
            // 
            // buttonEntrarPartida
            // 
            this.buttonEntrarPartida.BackColor = System.Drawing.Color.LightGray;
            this.buttonEntrarPartida.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrarPartida.Location = new System.Drawing.Point(66, 105);
            this.buttonEntrarPartida.Name = "buttonEntrarPartida";
            this.buttonEntrarPartida.Size = new System.Drawing.Size(132, 32);
            this.buttonEntrarPartida.TabIndex = 8;
            this.buttonEntrarPartida.Text = "Entrar na Partida";
            this.buttonEntrarPartida.UseVisualStyleBackColor = false;
            this.buttonEntrarPartida.Click += new System.EventHandler(this.buttonEntrarPartida_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.SteelBlue;
            this.panelContainer.Controls.Add(this.label8);
            this.panelContainer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelContainer.Location = new System.Drawing.Point(6, 228);
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
            this.label8.Visible = false;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonJogar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxDino);
            this.groupBox1.Controls.Add(this.textBoxCercado);
            this.groupBox1.Controls.Add(this.labelDino);
            this.groupBox1.Location = new System.Drawing.Point(6, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 152);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
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
            this.buttonJogar.UseCompatibleTextRendering = true;
            this.buttonJogar.UseVisualStyleBackColor = false;
            this.buttonJogar.Visible = false;
            this.buttonJogar.Click += new System.EventHandler(this.buttonJogar_Click);
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
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            this.label7.Visible = false;
            // 
            // textBoxDino
            // 
            this.textBoxDino.Location = new System.Drawing.Point(142, 29);
            this.textBoxDino.Name = "textBoxDino";
            this.textBoxDino.Size = new System.Drawing.Size(93, 22);
            this.textBoxDino.TabIndex = 24;
            this.textBoxDino.Visible = false;
            this.textBoxDino.TextChanged += new System.EventHandler(this.textBoxDino_TextChanged);
            // 
            // textBoxCercado
            // 
            this.textBoxCercado.Location = new System.Drawing.Point(142, 70);
            this.textBoxCercado.Name = "textBoxCercado";
            this.textBoxCercado.Size = new System.Drawing.Size(93, 22);
            this.textBoxCercado.TabIndex = 25;
            this.textBoxCercado.Visible = false;
            // 
            // labelDino
            // 
            this.labelDino.AutoSize = true;
            this.labelDino.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDino.Location = new System.Drawing.Point(40, 114);
            this.labelDino.Name = "labelDino";
            this.labelDino.Size = new System.Drawing.Size(82, 17);
            this.labelDino.TabIndex = 17;
            this.labelDino.Text = "Dinossauros";
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
            this.label4.Location = new System.Drawing.Point(301, 577);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Grupo: ";
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
            // 
            // labelIdJogador
            // 
            this.labelIdJogador.AutoSize = true;
            this.labelIdJogador.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdJogador.Location = new System.Drawing.Point(136, 583);
            this.labelIdJogador.Name = "labelIdJogador";
            this.labelIdJogador.Size = new System.Drawing.Size(78, 17);
            this.labelIdJogador.TabIndex = 15;
            this.labelIdJogador.Text = "ID Jogador:";
            // 
            // buttonVersao
            // 
            this.buttonVersao.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonVersao.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVersao.ForeColor = System.Drawing.Color.Red;
            this.buttonVersao.Location = new System.Drawing.Point(12, 577);
            this.buttonVersao.Name = "buttonVersao";
            this.buttonVersao.Size = new System.Drawing.Size(100, 29);
            this.buttonVersao.TabIndex = 2;
            this.buttonVersao.Text = "1.0";
            this.buttonVersao.UseVisualStyleBackColor = false;
            // 
            // labelGrupo
            // 
            this.labelGrupo.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrupo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelGrupo.Location = new System.Drawing.Point(360, 555);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(178, 36);
            this.labelGrupo.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelMT
            // 
            this.panelMT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMT.BackgroundImage")));
            this.panelMT.Location = new System.Drawing.Point(108, 295);
            this.panelMT.Name = "panelMT";
            this.panelMT.Size = new System.Drawing.Size(139, 114);
            this.panelMT.TabIndex = 3;
            // 
            // panelPA
            // 
            this.panelPA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPA.BackgroundImage")));
            this.panelPA.Location = new System.Drawing.Point(174, 521);
            this.panelPA.Name = "panelPA";
            this.panelPA.Size = new System.Drawing.Size(120, 127);
            this.panelPA.TabIndex = 4;
            // 
            // panelCD
            // 
            this.panelCD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCD.BackgroundImage")));
            this.panelCD.Location = new System.Drawing.Point(740, 507);
            this.panelCD.Name = "panelCD";
            this.panelCD.Size = new System.Drawing.Size(124, 99);
            this.panelCD.TabIndex = 5;
            // 
            // panelRS
            // 
            this.panelRS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRS.BackgroundImage")));
            this.panelRS.Location = new System.Drawing.Point(646, 75);
            this.panelRS.Name = "panelRS";
            this.panelRS.Size = new System.Drawing.Size(97, 51);
            this.panelRS.TabIndex = 7;
            // 
            // panelFI
            // 
            this.panelFI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFI.BackgroundImage")));
            this.panelFI.Location = new System.Drawing.Point(114, 59);
            this.panelFI.Name = "panelFI";
            this.panelFI.Size = new System.Drawing.Size(180, 114);
            this.panelFI.TabIndex = 4;
            // 
            // panelIS
            // 
            this.panelIS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelIS.BackgroundImage")));
            this.panelIS.Location = new System.Drawing.Point(658, 318);
            this.panelIS.Name = "panelIS";
            this.panelIS.Size = new System.Drawing.Size(139, 114);
            this.panelIS.TabIndex = 4;
            // 
            // panelTabuleiro
            // 
            this.panelTabuleiro.Controls.Add(this.panelRIO);
            this.panelTabuleiro.Controls.Add(this.panelPA);
            this.panelTabuleiro.Controls.Add(this.panelIS);
            this.panelTabuleiro.Controls.Add(this.panelFI);
            this.panelTabuleiro.Controls.Add(this.panelMT);
            this.panelTabuleiro.Controls.Add(this.panelRS);
            this.panelTabuleiro.Controls.Add(this.panelCD);
            this.panelTabuleiro.Controls.Add(this.pictureBoxTabuleiro);
            this.panelTabuleiro.Location = new System.Drawing.Point(0, 0);
            this.panelTabuleiro.Name = "panelTabuleiro";
            this.panelTabuleiro.Size = new System.Drawing.Size(948, 753);
            this.panelTabuleiro.TabIndex = 2;
            // 
            // panelRIO
            // 
            this.panelRIO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRIO.BackgroundImage")));
            this.panelRIO.Location = new System.Drawing.Point(448, 546);
            this.panelRIO.Name = "panelRIO";
            this.panelRIO.Size = new System.Drawing.Size(172, 129);
            this.panelRIO.TabIndex = 8;
            this.panelRIO.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRIO_Paint);
            // 
            // pictureBoxTabuleiro
            // 
            this.pictureBoxTabuleiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTabuleiro.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTabuleiro.Image")));
            this.pictureBoxTabuleiro.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTabuleiro.Name = "pictureBoxTabuleiro";
            this.pictureBoxTabuleiro.Size = new System.Drawing.Size(948, 753);
            this.pictureBoxTabuleiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTabuleiro.TabIndex = 0;
            this.pictureBoxTabuleiro.TabStop = false;
            this.pictureBoxTabuleiro.Click += new System.EventHandler(this.pictureBoxTabuleiro_Click);
            // 
            // Form1
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1493, 753);
            this.Controls.Add(this.panelTabuleiro);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Projeto Integrador";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelTabuleiro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTabuleiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox textBoxIdPartida;
        private TextBox nomeJogador;
        private TextBox senhaPartida;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonEntrarPartida;
        private ListBox listBoxJogadores;
        private Button buttonMostrarJogadores;
        private Button buttonIniciarPartida;
        private Label labelSenhaJogador;
        private Label labelIdJogador;
        private Label labelDino;
        private TextBox textBoxDinossauros;
        private Label label4;
        private Label label5;
        private TextBox textBoxCercado;
        private TextBox textBoxDino;
        private Label label7;
        private Label label6;
        private GroupBox groupBox1;
        private Panel panelContainer;
        private Label label8;
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
        private Timer timer1;
        private Panel panel1;
        private Label label11;
        private GroupBox groupBox2;
        private Label labelTurno;
        private Label labelJogadorDaVez;
        private Label labelDado;
        private Panel panel8;
        private Button button2;
        private GroupBox groupBox8;
        private TextBox textBoxTabuleiro;
        private Panel panelMT;
        private Panel panelPA;
        private Panel panelCD;
        private Panel panelRS;
        private Button buttonExportarHistorico;
        private Timer timer2;
        private Button buttonAcompanhar;
        private Panel panelFI;
        private Panel panelIS;
        private Panel panelTabuleiro;
        private PictureBox pictureBoxTabuleiro;
        private Panel panelRIO;
        private Button buttonJogar;
        private Button buttonPausarTimer;
    }
}