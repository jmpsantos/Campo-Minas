namespace G06.Minesweeper.Winform.Views
{
    partial class Ajuda
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
            System.Windows.Forms.Button buttonAjuda_Wiki;
            System.Windows.Forms.Button buttonAjuda_YT;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajuda));
            this.webBrowserTutorial = new System.Windows.Forms.WebBrowser();
            buttonAjuda_Wiki = new System.Windows.Forms.Button();
            buttonAjuda_YT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAjuda_Wiki
            // 
            buttonAjuda_Wiki.Anchor = System.Windows.Forms.AnchorStyles.Top;
            buttonAjuda_Wiki.BackgroundImage = global::G06.Minesweeper.Winform.Properties.Resources.Wikipedia_Logo;
            buttonAjuda_Wiki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            buttonAjuda_Wiki.Location = new System.Drawing.Point(445, 3);
            buttonAjuda_Wiki.Name = "buttonAjuda_Wiki";
            buttonAjuda_Wiki.Size = new System.Drawing.Size(227, 46);
            buttonAjuda_Wiki.TabIndex = 1;
            buttonAjuda_Wiki.UseVisualStyleBackColor = true;
            buttonAjuda_Wiki.Click += new System.EventHandler(this.buttonAjuda_Wiki_Click);
            // 
            // buttonAjuda_YT
            // 
            buttonAjuda_YT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            buttonAjuda_YT.BackgroundImage = global::G06.Minesweeper.Winform.Properties.Resources.YT_Logo1_removebg;
            buttonAjuda_YT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            buttonAjuda_YT.Location = new System.Drawing.Point(129, 3);
            buttonAjuda_YT.Name = "buttonAjuda_YT";
            buttonAjuda_YT.Size = new System.Drawing.Size(227, 46);
            buttonAjuda_YT.TabIndex = 2;
            buttonAjuda_YT.UseVisualStyleBackColor = true;
            buttonAjuda_YT.Click += new System.EventHandler(this.buttonAjuda_YT_Click);
            // 
            // webBrowserTutorial
            // 
            this.webBrowserTutorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserTutorial.Location = new System.Drawing.Point(0, 54);
            this.webBrowserTutorial.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserTutorial.Name = "webBrowserTutorial";
            this.webBrowserTutorial.Size = new System.Drawing.Size(800, 396);
            this.webBrowserTutorial.TabIndex = 0;
            this.webBrowserTutorial.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Ajuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(buttonAjuda_YT);
            this.Controls.Add(buttonAjuda_Wiki);
            this.Controls.Add(this.webBrowserTutorial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ajuda";
            this.Text = "Ajuda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.webBrowser_Form_Closed);
            this.Load += new System.EventHandler(this.Ajuda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserTutorial;
    }
}