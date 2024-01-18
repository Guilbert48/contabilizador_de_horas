namespace contabilizador_de_horas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnIniciar = new Button();
            btnPausar = new Button();
            txtTimer = new Label();
            btnParar = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novaToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            salvarComoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            visualizarImpressãoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            desfazerToolStripMenuItem = new ToolStripMenuItem();
            refazerToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            recortarToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            colarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selecionarTudoToolStripMenuItem = new ToolStripMenuItem();
            ferramentasToolStripMenuItem = new ToolStripMenuItem();
            personalizarToolStripMenuItem = new ToolStripMenuItem();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sumárioToolStripMenuItem = new ToolStripMenuItem();
            índiceToolStripMenuItem = new ToolStripMenuItem();
            pesquisarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            registrosToolStripMenuItem = new ToolStripMenuItem();
            arquivoToolStripMenuItem1 = new ToolStripMenuItem();
            novaToolStripMenuItem1 = new ToolStripMenuItem();
            abrirToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            salvarToolStripMenuItem1 = new ToolStripMenuItem();
            salvarComoToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            imprimirToolStripMenuItem1 = new ToolStripMenuItem();
            visualizarImpressãoToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            sairToolStripMenuItem1 = new ToolStripMenuItem();
            editarToolStripMenuItem1 = new ToolStripMenuItem();
            desfazerToolStripMenuItem1 = new ToolStripMenuItem();
            refazerToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator9 = new ToolStripSeparator();
            recortarToolStripMenuItem1 = new ToolStripMenuItem();
            copiarToolStripMenuItem1 = new ToolStripMenuItem();
            colarToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator10 = new ToolStripSeparator();
            selecionarTudoToolStripMenuItem1 = new ToolStripMenuItem();
            ferramentasToolStripMenuItem1 = new ToolStripMenuItem();
            personalizarToolStripMenuItem1 = new ToolStripMenuItem();
            opçõesToolStripMenuItem1 = new ToolStripMenuItem();
            ajudaToolStripMenuItem1 = new ToolStripMenuItem();
            sumárioToolStripMenuItem1 = new ToolStripMenuItem();
            índiceToolStripMenuItem1 = new ToolStripMenuItem();
            pesquisarToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator11 = new ToolStripSeparator();
            sobreToolStripMenuItem1 = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.SeaGreen;
            btnIniciar.ForeColor = SystemColors.Control;
            btnIniciar.Location = new Point(164, 304);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(275, 109);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnPausar
            // 
            btnPausar.BackColor = Color.DarkOrange;
            btnPausar.ForeColor = SystemColors.Control;
            btnPausar.Location = new Point(164, 436);
            btnPausar.Name = "btnPausar";
            btnPausar.Size = new Size(275, 107);
            btnPausar.TabIndex = 1;
            btnPausar.Text = "Pausar";
            btnPausar.UseVisualStyleBackColor = false;
            // 
            // txtTimer
            // 
            txtTimer.AutoSize = true;
            txtTimer.Font = new Font("Stencil", 80.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimer.Location = new Point(62, 125);
            txtTimer.Name = "txtTimer";
            txtTimer.Size = new Size(490, 127);
            txtTimer.TabIndex = 2;
            txtTimer.Text = "00:00:00";
            // 
            // btnParar
            // 
            btnParar.BackColor = Color.DarkRed;
            btnParar.ForeColor = SystemColors.Control;
            btnParar.Location = new Point(164, 566);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(275, 107);
            btnParar.TabIndex = 3;
            btnParar.Text = "Parar";
            btnParar.UseVisualStyleBackColor = false;
            btnParar.Click += btnParar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(559, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGoldenrod;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 55);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(152, 9);
            label2.Name = "label2";
            label2.Size = new Size(324, 40);
            label2.TabIndex = 6;
            label2.Text = "Ponto eletrônico";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem, ferramentasToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 58);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(252, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaToolStripMenuItem, abrirToolStripMenuItem, toolStripSeparator, salvarToolStripMenuItem, salvarComoToolStripMenuItem, toolStripSeparator1, imprimirToolStripMenuItem, visualizarImpressãoToolStripMenuItem, toolStripSeparator2, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // novaToolStripMenuItem
            // 
            novaToolStripMenuItem.Image = (Image)resources.GetObject("novaToolStripMenuItem.Image");
            novaToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            novaToolStripMenuItem.Name = "novaToolStripMenuItem";
            novaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            novaToolStripMenuItem.Size = new Size(180, 22);
            novaToolStripMenuItem.Text = "&Nova";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Image = (Image)resources.GetObject("abrirToolStripMenuItem.Image");
            abrirToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            abrirToolStripMenuItem.Size = new Size(180, 22);
            abrirToolStripMenuItem.Text = "&Abrir";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(177, 6);
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Image = (Image)resources.GetObject("salvarToolStripMenuItem.Image");
            salvarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            salvarToolStripMenuItem.Size = new Size(180, 22);
            salvarToolStripMenuItem.Text = "&Salvar";
            // 
            // salvarComoToolStripMenuItem
            // 
            salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            salvarComoToolStripMenuItem.Size = new Size(180, 22);
            salvarComoToolStripMenuItem.Text = "Salvar &Como";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Image = (Image)resources.GetObject("imprimirToolStripMenuItem.Image");
            imprimirToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            imprimirToolStripMenuItem.Size = new Size(180, 22);
            imprimirToolStripMenuItem.Text = "&Imprimir";
            // 
            // visualizarImpressãoToolStripMenuItem
            // 
            visualizarImpressãoToolStripMenuItem.Image = (Image)resources.GetObject("visualizarImpressãoToolStripMenuItem.Image");
            visualizarImpressãoToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            visualizarImpressãoToolStripMenuItem.Name = "visualizarImpressãoToolStripMenuItem";
            visualizarImpressãoToolStripMenuItem.Size = new Size(180, 22);
            visualizarImpressãoToolStripMenuItem.Text = "Visualizar Im&pressão";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "S&air";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { desfazerToolStripMenuItem, refazerToolStripMenuItem, toolStripSeparator3, recortarToolStripMenuItem, copiarToolStripMenuItem, colarToolStripMenuItem, toolStripSeparator4, selecionarTudoToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "&Editar";
            // 
            // desfazerToolStripMenuItem
            // 
            desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            desfazerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            desfazerToolStripMenuItem.Size = new Size(159, 22);
            desfazerToolStripMenuItem.Text = "&Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            refazerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            refazerToolStripMenuItem.Size = new Size(159, 22);
            refazerToolStripMenuItem.Text = "&Refazer";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(156, 6);
            // 
            // recortarToolStripMenuItem
            // 
            recortarToolStripMenuItem.Image = (Image)resources.GetObject("recortarToolStripMenuItem.Image");
            recortarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            recortarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            recortarToolStripMenuItem.Size = new Size(159, 22);
            recortarToolStripMenuItem.Text = "Recor&tar";
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Image = (Image)resources.GetObject("copiarToolStripMenuItem.Image");
            copiarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copiarToolStripMenuItem.Size = new Size(159, 22);
            copiarToolStripMenuItem.Text = "&Copiar";
            // 
            // colarToolStripMenuItem
            // 
            colarToolStripMenuItem.Image = (Image)resources.GetObject("colarToolStripMenuItem.Image");
            colarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            colarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            colarToolStripMenuItem.Size = new Size(159, 22);
            colarToolStripMenuItem.Text = "&Colar";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(156, 6);
            // 
            // selecionarTudoToolStripMenuItem
            // 
            selecionarTudoToolStripMenuItem.Name = "selecionarTudoToolStripMenuItem";
            selecionarTudoToolStripMenuItem.Size = new Size(159, 22);
            selecionarTudoToolStripMenuItem.Text = "Selecionar &Tudo";
            // 
            // ferramentasToolStripMenuItem
            // 
            ferramentasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personalizarToolStripMenuItem, opçõesToolStripMenuItem });
            ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            ferramentasToolStripMenuItem.Size = new Size(84, 20);
            ferramentasToolStripMenuItem.Text = "&Ferramentas";
            // 
            // personalizarToolStripMenuItem
            // 
            personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            personalizarToolStripMenuItem.Size = new Size(137, 22);
            personalizarToolStripMenuItem.Text = "&Personalizar";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(137, 22);
            opçõesToolStripMenuItem.Text = "&Opções";
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sumárioToolStripMenuItem, índiceToolStripMenuItem, pesquisarToolStripMenuItem, toolStripSeparator5, sobreToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // sumárioToolStripMenuItem
            // 
            sumárioToolStripMenuItem.Name = "sumárioToolStripMenuItem";
            sumárioToolStripMenuItem.Size = new Size(124, 22);
            sumárioToolStripMenuItem.Text = "&Sumário";
            // 
            // índiceToolStripMenuItem
            // 
            índiceToolStripMenuItem.Name = "índiceToolStripMenuItem";
            índiceToolStripMenuItem.Size = new Size(124, 22);
            índiceToolStripMenuItem.Text = "&Índice";
            // 
            // pesquisarToolStripMenuItem
            // 
            pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            pesquisarToolStripMenuItem.Size = new Size(124, 22);
            pesquisarToolStripMenuItem.Text = "&Pesquisar";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(121, 6);
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(124, 22);
            sobreToolStripMenuItem.Text = "&Sobre...";
            // 
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Items.AddRange(new ToolStripItem[] { registrosToolStripMenuItem, arquivoToolStripMenuItem1, editarToolStripMenuItem1, ferramentasToolStripMenuItem1, ajudaToolStripMenuItem1 });
            menuStrip2.Location = new Point(0, 51);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(594, 31);
            menuStrip2.TabIndex = 10;
            menuStrip2.Text = "menuStrip2";
            // 
            // registrosToolStripMenuItem
            // 
            registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            registrosToolStripMenuItem.Size = new Size(67, 27);
            registrosToolStripMenuItem.Text = "Registros";
            // 
            // arquivoToolStripMenuItem1
            // 
            arquivoToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { novaToolStripMenuItem1, abrirToolStripMenuItem1, toolStripSeparator6, salvarToolStripMenuItem1, salvarComoToolStripMenuItem1, toolStripSeparator7, imprimirToolStripMenuItem1, visualizarImpressãoToolStripMenuItem1, toolStripSeparator8, sairToolStripMenuItem1 });
            arquivoToolStripMenuItem1.Name = "arquivoToolStripMenuItem1";
            arquivoToolStripMenuItem1.Size = new Size(61, 27);
            arquivoToolStripMenuItem1.Text = "&Arquivo";
            // 
            // novaToolStripMenuItem1
            // 
            novaToolStripMenuItem1.Image = (Image)resources.GetObject("novaToolStripMenuItem1.Image");
            novaToolStripMenuItem1.ImageTransparentColor = Color.Magenta;
            novaToolStripMenuItem1.Name = "novaToolStripMenuItem1";
            novaToolStripMenuItem1.Size = new Size(180, 22);
            novaToolStripMenuItem1.Text = "&Nova";
            // 
            // abrirToolStripMenuItem1
            // 
            abrirToolStripMenuItem1.Image = (Image)resources.GetObject("abrirToolStripMenuItem1.Image");
            abrirToolStripMenuItem1.ImageTransparentColor = Color.Magenta;
            abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            abrirToolStripMenuItem1.Size = new Size(180, 22);
            abrirToolStripMenuItem1.Text = "&Abrir";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(177, 6);
            // 
            // salvarToolStripMenuItem1
            // 
            salvarToolStripMenuItem1.Image = (Image)resources.GetObject("salvarToolStripMenuItem1.Image");
            salvarToolStripMenuItem1.ImageTransparentColor = Color.Magenta;
            salvarToolStripMenuItem1.Name = "salvarToolStripMenuItem1";
            salvarToolStripMenuItem1.Size = new Size(180, 22);
            salvarToolStripMenuItem1.Text = "&Salvar";
            // 
            // salvarComoToolStripMenuItem1
            // 
            salvarComoToolStripMenuItem1.Name = "salvarComoToolStripMenuItem1";
            salvarComoToolStripMenuItem1.Size = new Size(180, 22);
            salvarComoToolStripMenuItem1.Text = "Salvar &Como";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(177, 6);
            // 
            // imprimirToolStripMenuItem1
            // 
            imprimirToolStripMenuItem1.Image = (Image)resources.GetObject("imprimirToolStripMenuItem1.Image");
            imprimirToolStripMenuItem1.ImageTransparentColor = Color.Magenta;
            imprimirToolStripMenuItem1.Name = "imprimirToolStripMenuItem1";
            imprimirToolStripMenuItem1.Size = new Size(180, 22);
            imprimirToolStripMenuItem1.Text = "&Imprimir";
            // 
            // visualizarImpressãoToolStripMenuItem1
            // 
            visualizarImpressãoToolStripMenuItem1.Image = (Image)resources.GetObject("visualizarImpressãoToolStripMenuItem1.Image");
            visualizarImpressãoToolStripMenuItem1.ImageTransparentColor = Color.Magenta;
            visualizarImpressãoToolStripMenuItem1.Name = "visualizarImpressãoToolStripMenuItem1";
            visualizarImpressãoToolStripMenuItem1.Size = new Size(180, 22);
            visualizarImpressãoToolStripMenuItem1.Text = "Visualizar Im&pressão";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(177, 6);
            // 
            // sairToolStripMenuItem1
            // 
            sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            sairToolStripMenuItem1.Size = new Size(180, 22);
            sairToolStripMenuItem1.Text = "S&air";
            // 
            // editarToolStripMenuItem1
            // 
            editarToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { desfazerToolStripMenuItem1, refazerToolStripMenuItem1, toolStripSeparator9, recortarToolStripMenuItem1, copiarToolStripMenuItem1, colarToolStripMenuItem1, toolStripSeparator10, selecionarTudoToolStripMenuItem1 });
            editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            editarToolStripMenuItem1.Size = new Size(49, 27);
            editarToolStripMenuItem1.Text = "&Editar";
            // 
            // desfazerToolStripMenuItem1
            // 
            desfazerToolStripMenuItem1.Name = "desfazerToolStripMenuItem1";
            desfazerToolStripMenuItem1.Size = new Size(158, 22);
            desfazerToolStripMenuItem1.Text = "&Desfazer";
            // 
            // refazerToolStripMenuItem1
            // 
            refazerToolStripMenuItem1.Name = "refazerToolStripMenuItem1";
            refazerToolStripMenuItem1.Size = new Size(158, 22);
            refazerToolStripMenuItem1.Text = "&Refazer";
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(155, 6);
            // 
            // recortarToolStripMenuItem1
            // 
            recortarToolStripMenuItem1.Image = (Image)resources.GetObject("recortarToolStripMenuItem1.Image");
            recortarToolStripMenuItem1.ImageTransparentColor = Color.Magenta;
            recortarToolStripMenuItem1.Name = "recortarToolStripMenuItem1";
            recortarToolStripMenuItem1.Size = new Size(158, 22);
            recortarToolStripMenuItem1.Text = "Recor&tar";
            // 
            // copiarToolStripMenuItem1
            // 
            copiarToolStripMenuItem1.Image = (Image)resources.GetObject("copiarToolStripMenuItem1.Image");
            copiarToolStripMenuItem1.ImageTransparentColor = Color.Magenta;
            copiarToolStripMenuItem1.Name = "copiarToolStripMenuItem1";
            copiarToolStripMenuItem1.Size = new Size(158, 22);
            copiarToolStripMenuItem1.Text = "&Copiar";
            // 
            // colarToolStripMenuItem1
            // 
            colarToolStripMenuItem1.Image = (Image)resources.GetObject("colarToolStripMenuItem1.Image");
            colarToolStripMenuItem1.ImageTransparentColor = Color.Magenta;
            colarToolStripMenuItem1.Name = "colarToolStripMenuItem1";
            colarToolStripMenuItem1.Size = new Size(158, 22);
            colarToolStripMenuItem1.Text = "&Colar";
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(155, 6);
            // 
            // selecionarTudoToolStripMenuItem1
            // 
            selecionarTudoToolStripMenuItem1.Name = "selecionarTudoToolStripMenuItem1";
            selecionarTudoToolStripMenuItem1.Size = new Size(158, 22);
            selecionarTudoToolStripMenuItem1.Text = "Selecionar &Tudo";
            // 
            // ferramentasToolStripMenuItem1
            // 
            ferramentasToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { personalizarToolStripMenuItem1, opçõesToolStripMenuItem1 });
            ferramentasToolStripMenuItem1.Name = "ferramentasToolStripMenuItem1";
            ferramentasToolStripMenuItem1.Size = new Size(84, 27);
            ferramentasToolStripMenuItem1.Text = "&Ferramentas";
            // 
            // personalizarToolStripMenuItem1
            // 
            personalizarToolStripMenuItem1.Name = "personalizarToolStripMenuItem1";
            personalizarToolStripMenuItem1.Size = new Size(137, 22);
            personalizarToolStripMenuItem1.Text = "&Personalizar";
            // 
            // opçõesToolStripMenuItem1
            // 
            opçõesToolStripMenuItem1.Name = "opçõesToolStripMenuItem1";
            opçõesToolStripMenuItem1.Size = new Size(137, 22);
            opçõesToolStripMenuItem1.Text = "&Opções";
            // 
            // ajudaToolStripMenuItem1
            // 
            ajudaToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { sumárioToolStripMenuItem1, índiceToolStripMenuItem1, pesquisarToolStripMenuItem1, toolStripSeparator11, sobreToolStripMenuItem1 });
            ajudaToolStripMenuItem1.Name = "ajudaToolStripMenuItem1";
            ajudaToolStripMenuItem1.Size = new Size(50, 27);
            ajudaToolStripMenuItem1.Text = "&Ajuda";
            // 
            // sumárioToolStripMenuItem1
            // 
            sumárioToolStripMenuItem1.Name = "sumárioToolStripMenuItem1";
            sumárioToolStripMenuItem1.Size = new Size(124, 22);
            sumárioToolStripMenuItem1.Text = "&Sumário";
            // 
            // índiceToolStripMenuItem1
            // 
            índiceToolStripMenuItem1.Name = "índiceToolStripMenuItem1";
            índiceToolStripMenuItem1.Size = new Size(124, 22);
            índiceToolStripMenuItem1.Text = "&Índice";
            // 
            // pesquisarToolStripMenuItem1
            // 
            pesquisarToolStripMenuItem1.Name = "pesquisarToolStripMenuItem1";
            pesquisarToolStripMenuItem1.Size = new Size(124, 22);
            pesquisarToolStripMenuItem1.Text = "&Pesquisar";
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new Size(121, 6);
            // 
            // sobreToolStripMenuItem1
            // 
            sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            sobreToolStripMenuItem1.Size = new Size(124, 22);
            sobreToolStripMenuItem1.Text = "&Sobre...";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(594, 803);
            Controls.Add(panel1);
            Controls.Add(btnParar);
            Controls.Add(txtTimer);
            Controls.Add(menuStrip2);
            Controls.Add(btnPausar);
            Controls.Add(btnIniciar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Button btnPausar;
        private Label txtTimer;
        private Button btnParar;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novaToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem salvarComoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem visualizarImpressãoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem desfazerToolStripMenuItem;
        private ToolStripMenuItem refazerToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem recortarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selecionarTudoToolStripMenuItem;
        private ToolStripMenuItem ferramentasToolStripMenuItem;
        private ToolStripMenuItem personalizarToolStripMenuItem;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sumárioToolStripMenuItem;
        private ToolStripMenuItem índiceToolStripMenuItem;
        private ToolStripMenuItem pesquisarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem registrosToolStripMenuItem;
        private ToolStripMenuItem arquivoToolStripMenuItem1;
        private ToolStripMenuItem novaToolStripMenuItem1;
        private ToolStripMenuItem abrirToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem salvarToolStripMenuItem1;
        private ToolStripMenuItem salvarComoToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem imprimirToolStripMenuItem1;
        private ToolStripMenuItem visualizarImpressãoToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem sairToolStripMenuItem1;
        private ToolStripMenuItem editarToolStripMenuItem1;
        private ToolStripMenuItem desfazerToolStripMenuItem1;
        private ToolStripMenuItem refazerToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem recortarToolStripMenuItem1;
        private ToolStripMenuItem copiarToolStripMenuItem1;
        private ToolStripMenuItem colarToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem selecionarTudoToolStripMenuItem1;
        private ToolStripMenuItem ferramentasToolStripMenuItem1;
        private ToolStripMenuItem personalizarToolStripMenuItem1;
        private ToolStripMenuItem opçõesToolStripMenuItem1;
        private ToolStripMenuItem ajudaToolStripMenuItem1;
        private ToolStripMenuItem sumárioToolStripMenuItem1;
        private ToolStripMenuItem índiceToolStripMenuItem1;
        private ToolStripMenuItem pesquisarToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripMenuItem sobreToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
    }
}
