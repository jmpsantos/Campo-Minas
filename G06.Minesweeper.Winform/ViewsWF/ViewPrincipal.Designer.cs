namespace G06.Minesweeper.Winform.Views
{
    partial class ViewPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPrincipal));
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuStrip_Jogo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Jogo_Facil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Jogo_Medio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Jogo_Break1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip_Jogo_MT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Jogo_MT_Facil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Jogo_MT_Medio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Jogo_Break2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip_Jogo_Top10 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Jogo_Break3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip_Jogo_Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_JogarOnline = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Ajuda = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListSmile = new System.Windows.Forms.ImageList(this.components);
            this.imageListCronometro = new System.Windows.Forms.ImageList(this.components);
            this.imageListPisca = new System.Windows.Forms.ImageList(this.components);
            this.timerCronometro = new System.Windows.Forms.Timer(this.components);
            this.timerPisca = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxTimer = new System.Windows.Forms.PictureBox();
            this.pictureBoxFlags1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFlags2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCronometro3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCronometro4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCronometro1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCronometro2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCronometro5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSmile = new System.Windows.Forms.PictureBox();
            this.pictureBoxFlag = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fácilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlags1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlags2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCronometro3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCronometro4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCronometro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCronometro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCronometro5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Jogo,
            this.menuStrip_JogarOnline,
            this.menuStrip_Ajuda});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStripPrincipal.Size = new System.Drawing.Size(787, 30);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // menuStrip_Jogo
            // 
            this.menuStrip_Jogo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Jogo_Facil,
            this.menuStrip_Jogo_Medio,
            this.menuStrip_Jogo_Break1,
            this.menuStrip_Jogo_MT,
            this.menuStrip_Jogo_Break2,
            this.menuStrip_Jogo_Top10,
            this.menuStrip_Jogo_Break3,
            this.menuStrip_Jogo_Sair});
            this.menuStrip_Jogo.Name = "menuStrip_Jogo";
            this.menuStrip_Jogo.Size = new System.Drawing.Size(55, 26);
            this.menuStrip_Jogo.Text = "Jogo";
            // 
            // menuStrip_Jogo_Facil
            // 
            this.menuStrip_Jogo_Facil.Name = "menuStrip_Jogo_Facil";
            this.menuStrip_Jogo_Facil.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.menuStrip_Jogo_Facil.Size = new System.Drawing.Size(298, 26);
            this.menuStrip_Jogo_Facil.Text = "Fácil (9x9)";
            // 
            // menuStrip_Jogo_Medio
            // 
            this.menuStrip_Jogo_Medio.Name = "menuStrip_Jogo_Medio";
            this.menuStrip_Jogo_Medio.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.menuStrip_Jogo_Medio.Size = new System.Drawing.Size(298, 26);
            this.menuStrip_Jogo_Medio.Text = "Médio (16x16)";
            this.menuStrip_Jogo_Medio.Click += new System.EventHandler(this.menuStrip_Jogo_Medio_Click);
            // 
            // menuStrip_Jogo_Break1
            // 
            this.menuStrip_Jogo_Break1.Name = "menuStrip_Jogo_Break1";
            this.menuStrip_Jogo_Break1.Size = new System.Drawing.Size(295, 6);
            // 
            // menuStrip_Jogo_MT
            // 
            this.menuStrip_Jogo_MT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Jogo_MT_Facil,
            this.menuStrip_Jogo_MT_Medio});
            this.menuStrip_Jogo_MT.Name = "menuStrip_Jogo_MT";
            this.menuStrip_Jogo_MT.Size = new System.Drawing.Size(298, 26);
            this.menuStrip_Jogo_MT.Text = "Melhores Tempos (Standalone)";
            // 
            // menuStrip_Jogo_MT_Facil
            // 
            this.menuStrip_Jogo_MT_Facil.Name = "menuStrip_Jogo_MT_Facil";
            this.menuStrip_Jogo_MT_Facil.Size = new System.Drawing.Size(224, 26);
            this.menuStrip_Jogo_MT_Facil.Text = "Fácil";
            this.menuStrip_Jogo_MT_Facil.Click += new System.EventHandler(this.menuStrip_Jogo_MT_Facil_Click);
            // 
            // menuStrip_Jogo_MT_Medio
            // 
            this.menuStrip_Jogo_MT_Medio.Name = "menuStrip_Jogo_MT_Medio";
            this.menuStrip_Jogo_MT_Medio.Size = new System.Drawing.Size(224, 26);
            this.menuStrip_Jogo_MT_Medio.Text = "Médio";
            this.menuStrip_Jogo_MT_Medio.Click += new System.EventHandler(this.menuStrip_Jogo_MT_Medio_Click);
            // 
            // menuStrip_Jogo_Break2
            // 
            this.menuStrip_Jogo_Break2.Name = "menuStrip_Jogo_Break2";
            this.menuStrip_Jogo_Break2.Size = new System.Drawing.Size(295, 6);
            // 
            // menuStrip_Jogo_Top10
            // 
            this.menuStrip_Jogo_Top10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fácilToolStripMenuItem,
            this.médioToolStripMenuItem});
            this.menuStrip_Jogo_Top10.Enabled = false;
            this.menuStrip_Jogo_Top10.Name = "menuStrip_Jogo_Top10";
            this.menuStrip_Jogo_Top10.Size = new System.Drawing.Size(298, 26);
            this.menuStrip_Jogo_Top10.Text = "Leaderboard";
            this.menuStrip_Jogo_Top10.Click += new System.EventHandler(this.menuStrip_Jogo_Top10_Click);
            // 
            // menuStrip_Jogo_Break3
            // 
            this.menuStrip_Jogo_Break3.Name = "menuStrip_Jogo_Break3";
            this.menuStrip_Jogo_Break3.Size = new System.Drawing.Size(295, 6);
            // 
            // menuStrip_Jogo_Sair
            // 
            this.menuStrip_Jogo_Sair.Name = "menuStrip_Jogo_Sair";
            this.menuStrip_Jogo_Sair.Size = new System.Drawing.Size(298, 26);
            this.menuStrip_Jogo_Sair.Text = "Sair";
            this.menuStrip_Jogo_Sair.Click += new System.EventHandler(this.menuStrip_Jogo_Sair_Click);
            // 
            // menuStrip_JogarOnline
            // 
            this.menuStrip_JogarOnline.Name = "menuStrip_JogarOnline";
            this.menuStrip_JogarOnline.Size = new System.Drawing.Size(106, 26);
            this.menuStrip_JogarOnline.Text = "Jogar Online";
            this.menuStrip_JogarOnline.Click += new System.EventHandler(this.menuStrip_JogarOnline_Click);
            // 
            // menuStrip_Ajuda
            // 
            this.menuStrip_Ajuda.Name = "menuStrip_Ajuda";
            this.menuStrip_Ajuda.Size = new System.Drawing.Size(62, 26);
            this.menuStrip_Ajuda.Text = "Ajuda";
            this.menuStrip_Ajuda.Click += new System.EventHandler(this.menuStrip_Ajuda_Click);
            // 
            // imageListSmile
            // 
            this.imageListSmile.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmile.ImageStream")));
            this.imageListSmile.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmile.Images.SetKeyName(0, "emoji_click.jpg");
            this.imageListSmile.Images.SetKeyName(1, "emoji_ko.jpg");
            this.imageListSmile.Images.SetKeyName(2, "emoji_oculos.jpg");
            this.imageListSmile.Images.SetKeyName(3, "emoji_sorriso.jpg");
            // 
            // imageListCronometro
            // 
            this.imageListCronometro.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCronometro.ImageStream")));
            this.imageListCronometro.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCronometro.Images.SetKeyName(0, "timer0.png");
            this.imageListCronometro.Images.SetKeyName(1, "timer1.png");
            this.imageListCronometro.Images.SetKeyName(2, "timer2.png");
            this.imageListCronometro.Images.SetKeyName(3, "timer3.png");
            this.imageListCronometro.Images.SetKeyName(4, "timer4.png");
            this.imageListCronometro.Images.SetKeyName(5, "timer5.png");
            this.imageListCronometro.Images.SetKeyName(6, "timer6.png");
            this.imageListCronometro.Images.SetKeyName(7, "timer7.png");
            this.imageListCronometro.Images.SetKeyName(8, "timer8.png");
            this.imageListCronometro.Images.SetKeyName(9, "timer9.png");
            // 
            // imageListPisca
            // 
            this.imageListPisca.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPisca.ImageStream")));
            this.imageListPisca.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPisca.Images.SetKeyName(0, "timer2pontos.png");
            this.imageListPisca.Images.SetKeyName(1, "timer2pontosBLANK.png");
            // 
            // timerCronometro
            // 
            this.timerCronometro.Interval = 1000;
            this.timerCronometro.Tick += new System.EventHandler(this.timerCronometro_Tick);
            // 
            // timerPisca
            // 
            this.timerPisca.Tick += new System.EventHandler(this.timerPisca_Tick);
            // 
            // pictureBoxTimer
            // 
            this.pictureBoxTimer.Image = global::G06.Minesweeper.Winform.Properties.Resources.cronometro_draw_removebg;
            this.pictureBoxTimer.Location = new System.Drawing.Point(733, 33);
            this.pictureBoxTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxTimer.Name = "pictureBoxTimer";
            this.pictureBoxTimer.Size = new System.Drawing.Size(45, 43);
            this.pictureBoxTimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTimer.TabIndex = 11;
            this.pictureBoxTimer.TabStop = false;
            // 
            // pictureBoxFlags1
            // 
            this.pictureBoxFlags1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBoxFlags1.Image = global::G06.Minesweeper.Winform.Properties.Resources.timer0;
            this.pictureBoxFlags1.InitialImage = global::G06.Minesweeper.Winform.Properties.Resources.timer0;
            this.pictureBoxFlags1.Location = new System.Drawing.Point(16, 31);
            this.pictureBoxFlags1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFlags1.Name = "pictureBoxFlags1";
            this.pictureBoxFlags1.Size = new System.Drawing.Size(27, 44);
            this.pictureBoxFlags1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFlags1.TabIndex = 10;
            this.pictureBoxFlags1.TabStop = false;
            // 
            // pictureBoxFlags2
            // 
            this.pictureBoxFlags2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBoxFlags2.Image = global::G06.Minesweeper.Winform.Properties.Resources.timer0;
            this.pictureBoxFlags2.Location = new System.Drawing.Point(43, 31);
            this.pictureBoxFlags2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFlags2.Name = "pictureBoxFlags2";
            this.pictureBoxFlags2.Size = new System.Drawing.Size(27, 44);
            this.pictureBoxFlags2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFlags2.TabIndex = 9;
            this.pictureBoxFlags2.TabStop = false;
            // 
            // pictureBoxCronometro3
            // 
            this.pictureBoxCronometro3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxCronometro3.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBoxCronometro3.Image = global::G06.Minesweeper.Winform.Properties.Resources.timer2pontos;
            this.pictureBoxCronometro3.Location = new System.Drawing.Point(664, 32);
            this.pictureBoxCronometro3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCronometro3.Name = "pictureBoxCronometro3";
            this.pictureBoxCronometro3.Size = new System.Drawing.Size(11, 44);
            this.pictureBoxCronometro3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCronometro3.TabIndex = 8;
            this.pictureBoxCronometro3.TabStop = false;
            // 
            // pictureBoxCronometro4
            // 
            this.pictureBoxCronometro4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxCronometro4.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBoxCronometro4.Image = global::G06.Minesweeper.Winform.Properties.Resources.timer0;
            this.pictureBoxCronometro4.Location = new System.Drawing.Point(675, 32);
            this.pictureBoxCronometro4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCronometro4.Name = "pictureBoxCronometro4";
            this.pictureBoxCronometro4.Size = new System.Drawing.Size(27, 44);
            this.pictureBoxCronometro4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCronometro4.TabIndex = 7;
            this.pictureBoxCronometro4.TabStop = false;
            // 
            // pictureBoxCronometro1
            // 
            this.pictureBoxCronometro1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxCronometro1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBoxCronometro1.Image = global::G06.Minesweeper.Winform.Properties.Resources.timer0;
            this.pictureBoxCronometro1.InitialImage = global::G06.Minesweeper.Winform.Properties.Resources.timer0;
            this.pictureBoxCronometro1.Location = new System.Drawing.Point(608, 32);
            this.pictureBoxCronometro1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCronometro1.Name = "pictureBoxCronometro1";
            this.pictureBoxCronometro1.Size = new System.Drawing.Size(27, 44);
            this.pictureBoxCronometro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCronometro1.TabIndex = 6;
            this.pictureBoxCronometro1.TabStop = false;
            // 
            // pictureBoxCronometro2
            // 
            this.pictureBoxCronometro2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxCronometro2.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBoxCronometro2.Image = global::G06.Minesweeper.Winform.Properties.Resources.timer0;
            this.pictureBoxCronometro2.Location = new System.Drawing.Point(636, 32);
            this.pictureBoxCronometro2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCronometro2.Name = "pictureBoxCronometro2";
            this.pictureBoxCronometro2.Size = new System.Drawing.Size(27, 44);
            this.pictureBoxCronometro2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCronometro2.TabIndex = 5;
            this.pictureBoxCronometro2.TabStop = false;
            // 
            // pictureBoxCronometro5
            // 
            this.pictureBoxCronometro5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxCronometro5.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBoxCronometro5.Image = global::G06.Minesweeper.Winform.Properties.Resources.timer0;
            this.pictureBoxCronometro5.Location = new System.Drawing.Point(701, 32);
            this.pictureBoxCronometro5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCronometro5.Name = "pictureBoxCronometro5";
            this.pictureBoxCronometro5.Size = new System.Drawing.Size(27, 44);
            this.pictureBoxCronometro5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCronometro5.TabIndex = 4;
            this.pictureBoxCronometro5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(903, -180);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 44);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxSmile
            // 
            this.pictureBoxSmile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxSmile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSmile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxSmile.Image = global::G06.Minesweeper.Winform.Properties.Resources.emoji_sorriso;
            this.pictureBoxSmile.Location = new System.Drawing.Point(352, 32);
            this.pictureBoxSmile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSmile.Name = "pictureBoxSmile";
            this.pictureBoxSmile.Size = new System.Drawing.Size(47, 43);
            this.pictureBoxSmile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSmile.TabIndex = 2;
            this.pictureBoxSmile.TabStop = false;
            this.pictureBoxSmile.Click += new System.EventHandler(this.pictureBoxSmile_Click);
            this.pictureBoxSmile.MouseLeave += new System.EventHandler(this.pictureBoxSmile_MouseLeave);
            this.pictureBoxSmile.MouseHover += new System.EventHandler(this.pictureBoxSmile_MouseHover);
            // 
            // pictureBoxFlag
            // 
            this.pictureBoxFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFlag.Image = global::G06.Minesweeper.Winform.Properties.Resources.FlagSolo_removebg_preview;
            this.pictureBoxFlag.Location = new System.Drawing.Point(75, 32);
            this.pictureBoxFlag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFlag.Name = "pictureBoxFlag";
            this.pictureBoxFlag.Size = new System.Drawing.Size(46, 44);
            this.pictureBoxFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFlag.TabIndex = 13;
            this.pictureBoxFlag.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(43, 110);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(691, 375);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // fácilToolStripMenuItem
            // 
            this.fácilToolStripMenuItem.Name = "fácilToolStripMenuItem";
            this.fácilToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fácilToolStripMenuItem.Text = "Fácil";
            // 
            // médioToolStripMenuItem
            // 
            this.médioToolStripMenuItem.Name = "médioToolStripMenuItem";
            this.médioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.médioToolStripMenuItem.Text = "Médio";
            // 
            // ViewPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 513);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBoxFlag);
            this.Controls.Add(this.pictureBoxTimer);
            this.Controls.Add(this.pictureBoxFlags1);
            this.Controls.Add(this.pictureBoxFlags2);
            this.Controls.Add(this.pictureBoxCronometro3);
            this.Controls.Add(this.pictureBoxCronometro4);
            this.Controls.Add(this.pictureBoxCronometro1);
            this.Controls.Add(this.pictureBoxCronometro2);
            this.Controls.Add(this.pictureBoxCronometro5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxSmile);
            this.Controls.Add(this.menuStripPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.ViewPrincipal_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlags1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlags2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCronometro3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCronometro4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCronometro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCronometro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCronometro5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSmile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Jogo;
        private System.Windows.Forms.ImageList imageListSmile;
        private System.Windows.Forms.PictureBox pictureBoxSmile;
        private System.Windows.Forms.ImageList imageListCronometro;
        private System.Windows.Forms.ImageList imageListPisca;
        private System.Windows.Forms.Timer timerCronometro;
        private System.Windows.Forms.Timer timerPisca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxCronometro5;
        private System.Windows.Forms.PictureBox pictureBoxCronometro2;
        private System.Windows.Forms.PictureBox pictureBoxCronometro1;
        private System.Windows.Forms.PictureBox pictureBoxCronometro4;
        private System.Windows.Forms.PictureBox pictureBoxCronometro3;
        private System.Windows.Forms.PictureBox pictureBoxFlags1;
        private System.Windows.Forms.PictureBox pictureBoxFlags2;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Jogo_Facil;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Jogo_Medio;
        private System.Windows.Forms.ToolStripSeparator menuStrip_Jogo_Break1;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Jogo_MT;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Jogo_MT_Facil;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Jogo_MT_Medio;
        private System.Windows.Forms.ToolStripSeparator menuStrip_Jogo_Break3;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Jogo_Sair;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Ajuda;
        private System.Windows.Forms.PictureBox pictureBoxTimer;
        private System.Windows.Forms.PictureBox pictureBoxFlag;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_JogarOnline;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripSeparator menuStrip_Jogo_Break2;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_Jogo_Top10;
        private System.Windows.Forms.ToolStripMenuItem fácilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médioToolStripMenuItem;
    }
}