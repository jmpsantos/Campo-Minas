namespace G06.Minesweeper.Winform.ViewsWF
{
    partial class DadosVencedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DadosVencedor));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelTempoVencedor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNomeVencedor = new System.Windows.Forms.Label();
            this.textBoxInserirNome = new System.Windows.Forms.TextBox();
            this.panelVenceu = new System.Windows.Forms.Panel();
            this.buttonSubmeterVencedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelVenceu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::G06.Minesweeper.Winform.Properties.Resources.party;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(436, 205);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // labelTempoVencedor
            // 
            this.labelTempoVencedor.AutoSize = true;
            this.labelTempoVencedor.BackColor = System.Drawing.Color.White;
            this.labelTempoVencedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempoVencedor.ForeColor = System.Drawing.Color.Black;
            this.labelTempoVencedor.Location = new System.Drawing.Point(125, 124);
            this.labelTempoVencedor.Name = "labelTempoVencedor";
            this.labelTempoVencedor.Size = new System.Drawing.Size(81, 20);
            this.labelTempoVencedor.TabIndex = 7;
            this.labelTempoVencedor.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::G06.Minesweeper.Winform.Properties.Resources.cronometro_draw_removebg;
            this.pictureBox1.Location = new System.Drawing.Point(38, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // labelNomeVencedor
            // 
            this.labelNomeVencedor.AutoSize = true;
            this.labelNomeVencedor.BackColor = System.Drawing.Color.White;
            this.labelNomeVencedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeVencedor.ForeColor = System.Drawing.Color.Black;
            this.labelNomeVencedor.Location = new System.Drawing.Point(59, 44);
            this.labelNomeVencedor.Name = "labelNomeVencedor";
            this.labelNomeVencedor.Size = new System.Drawing.Size(162, 20);
            this.labelNomeVencedor.TabIndex = 5;
            this.labelNomeVencedor.Text = "Insira o seu Nome";
            // 
            // textBoxInserirNome
            // 
            this.textBoxInserirNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInserirNome.Location = new System.Drawing.Point(62, 72);
            this.textBoxInserirNome.Name = "textBoxInserirNome";
            this.textBoxInserirNome.Size = new System.Drawing.Size(316, 27);
            this.textBoxInserirNome.TabIndex = 4;
            // 
            // panelVenceu
            // 
            this.panelVenceu.Controls.Add(this.buttonSubmeterVencedor);
            this.panelVenceu.Controls.Add(this.pictureBox1);
            this.panelVenceu.Location = new System.Drawing.Point(29, 24);
            this.panelVenceu.Name = "panelVenceu";
            this.panelVenceu.Size = new System.Drawing.Size(383, 148);
            this.panelVenceu.TabIndex = 8;
            // 
            // buttonSubmeterVencedor
            // 
            this.buttonSubmeterVencedor.Location = new System.Drawing.Point(218, 89);
            this.buttonSubmeterVencedor.Name = "buttonSubmeterVencedor";
            this.buttonSubmeterVencedor.Size = new System.Drawing.Size(131, 41);
            this.buttonSubmeterVencedor.TabIndex = 7;
            this.buttonSubmeterVencedor.Text = "Submeter";
            this.buttonSubmeterVencedor.UseVisualStyleBackColor = true;
            this.buttonSubmeterVencedor.Click += new System.EventHandler(this.buttonSubmeterVencedor_Click);
            // 
            // DadosVencedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 205);
            this.Controls.Add(this.labelNomeVencedor);
            this.Controls.Add(this.textBoxInserirNome);
            this.Controls.Add(this.labelTempoVencedor);
            this.Controls.Add(this.panelVenceu);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DadosVencedor";
            this.Text = "Venceu a Partida!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DadosVencedor_FormClosed);
            this.Load += new System.EventHandler(this.DadosVencedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelVenceu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelTempoVencedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNomeVencedor;
        private System.Windows.Forms.TextBox textBoxInserirNome;
        private System.Windows.Forms.Panel panelVenceu;
        private System.Windows.Forms.Button buttonSubmeterVencedor;
    }
}