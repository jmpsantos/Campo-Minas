namespace G06.Minesweeper.Winform.Views
{
    partial class ViewLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLogin));
            this.linkLabelRecoverPassword = new System.Windows.Forms.LinkLabel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonRegistar = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelPW = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelE_Mail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelRecoverPassword
            // 
            this.linkLabelRecoverPassword.AutoSize = true;
            this.linkLabelRecoverPassword.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelRecoverPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRecoverPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkLabelRecoverPassword.Location = new System.Drawing.Point(26, 310);
            this.linkLabelRecoverPassword.Name = "linkLabelRecoverPassword";
            this.linkLabelRecoverPassword.Size = new System.Drawing.Size(170, 17);
            this.linkLabelRecoverPassword.TabIndex = 0;
            this.linkLabelRecoverPassword.TabStop = true;
            this.linkLabelRecoverPassword.Text = "Recuperar Palavra-passe";
            this.linkLabelRecoverPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRecoverPassword_LinkClicked);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.buttonRegistar);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.labelPW);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.labelE_Mail);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Controls.Add(this.textBoxEmail);
            this.panelLogin.Controls.Add(this.labelLogin);
            this.panelLogin.Controls.Add(this.linkLabelRecoverPassword);
            this.panelLogin.Location = new System.Drawing.Point(122, 23);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(301, 424);
            this.panelLogin.TabIndex = 1;
            // 
            // buttonRegistar
            // 
            this.buttonRegistar.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistar.ForeColor = System.Drawing.Color.Navy;
            this.buttonRegistar.Location = new System.Drawing.Point(171, 352);
            this.buttonRegistar.Name = "buttonRegistar";
            this.buttonRegistar.Size = new System.Drawing.Size(108, 38);
            this.buttonRegistar.TabIndex = 8;
            this.buttonRegistar.Text = "Registar";
            this.buttonRegistar.UseVisualStyleBackColor = false;
            this.buttonRegistar.Click += new System.EventHandler(this.buttonRegistar_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Navy;
            this.buttonLogin.Location = new System.Drawing.Point(26, 352);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(108, 38);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Entrar";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelPW
            // 
            this.labelPW.AutoSize = true;
            this.labelPW.BackColor = System.Drawing.Color.Transparent;
            this.labelPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPW.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelPW.Location = new System.Drawing.Point(22, 258);
            this.labelPW.Name = "labelPW";
            this.labelPW.Size = new System.Drawing.Size(129, 20);
            this.labelPW.TabIndex = 6;
            this.labelPW.Text = "Palavra-passe";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(26, 282);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(253, 27);
            this.textBoxPassword.TabIndex = 5;
            // 
            // labelE_Mail
            // 
            this.labelE_Mail.AutoSize = true;
            this.labelE_Mail.BackColor = System.Drawing.Color.Transparent;
            this.labelE_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelE_Mail.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelE_Mail.Location = new System.Drawing.Point(22, 205);
            this.labelE_Mail.Name = "labelE_Mail";
            this.labelE_Mail.Size = new System.Drawing.Size(56, 20);
            this.labelE_Mail.TabIndex = 4;
            this.labelE_Mail.Text = "Email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::G06.Minesweeper.Winform.Properties.Resources.login_icon_removeb;
            this.pictureBox1.Location = new System.Drawing.Point(100, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(26, 229);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(253, 22);
            this.textBoxEmail.TabIndex = 2;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelLogin.Location = new System.Drawing.Point(105, 150);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(91, 32);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Login";
            // 
            // ViewLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::G06.Minesweeper.Winform.Properties.Resources.MinesweeperMod;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(561, 506);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewLogin_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelRecoverPassword;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPW;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelE_Mail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegistar;
    }
}