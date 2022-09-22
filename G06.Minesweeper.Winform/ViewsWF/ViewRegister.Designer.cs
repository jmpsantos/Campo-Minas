namespace G06.Minesweeper.Winform.Views
{
    partial class ViewRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRegister));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.labelFotografia = new System.Windows.Forms.Label();
            this.labelPais = new System.Windows.Forms.Label();
            this.comboBoxPaises = new System.Windows.Forms.ComboBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.buttonCriarConta = new System.Windows.Forms.Button();
            this.labelPW = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelE_Mail = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelRegisto = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.buttonBrowse);
            this.panelLogin.Controls.Add(this.pictureBoxFoto);
            this.panelLogin.Controls.Add(this.labelFotografia);
            this.panelLogin.Controls.Add(this.labelPais);
            this.panelLogin.Controls.Add(this.comboBoxPaises);
            this.panelLogin.Controls.Add(this.labelNome);
            this.panelLogin.Controls.Add(this.labelUsername);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.textBoxUsername);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.textBoxEMail);
            this.panelLogin.Controls.Add(this.buttonCriarConta);
            this.panelLogin.Controls.Add(this.labelPW);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.labelE_Mail);
            this.panelLogin.Controls.Add(this.textBoxNom);
            this.panelLogin.Controls.Add(this.labelRegisto);
            this.panelLogin.Location = new System.Drawing.Point(59, 47);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(655, 411);
            this.panelLogin.TabIndex = 2;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.Transparent;
            this.buttonBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.ForeColor = System.Drawing.Color.Navy;
            this.buttonBrowse.Location = new System.Drawing.Point(528, 186);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(93, 61);
            this.buttonBrowse.TabIndex = 19;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(354, 156);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(144, 129);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto.TabIndex = 18;
            this.pictureBoxFoto.TabStop = false;
            // 
            // labelFotografia
            // 
            this.labelFotografia.AutoSize = true;
            this.labelFotografia.BackColor = System.Drawing.Color.Transparent;
            this.labelFotografia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFotografia.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelFotografia.Location = new System.Drawing.Point(351, 131);
            this.labelFotografia.Name = "labelFotografia";
            this.labelFotografia.Size = new System.Drawing.Size(94, 20);
            this.labelFotografia.TabIndex = 17;
            this.labelFotografia.Text = "Fotografia";
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.BackColor = System.Drawing.Color.Transparent;
            this.labelPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPais.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelPais.Location = new System.Drawing.Point(350, 78);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(46, 20);
            this.labelPais.TabIndex = 16;
            this.labelPais.Text = "País";
            // 
            // comboBoxPaises
            // 
            this.comboBoxPaises.FormattingEnabled = true;
            this.comboBoxPaises.Items.AddRange(new object[] {
            "    Afeganistão",
            "    África do Sul",
            "    Akrotiri",
            "    Albânia",
            "    Alemanha",
            "    Andorra",
            "    Angola",
            "    Anguila",
            "    Antárctida",
            "    Antígua e Barbuda",
            "    Arábia Saudita",
            "    Arctic Ocean",
            "    Argélia",
            "    Argentina",
            "    Arménia",
            "    Aruba",
            "    Ashmore and Cartier Islands",
            "    Atlantic Ocean",
            "    Austrália",
            "    Áustria",
            "    Azerbaijão",
            "    Baamas",
            "    Bangladeche",
            "    Barbados",
            "    Barém",
            "    Bélgica",
            "    Belize",
            "    Benim",
            "    Bermudas",
            "    Bielorrússia",
            "    Birmânia",
            "    Bolívia",
            "    Bósnia e Herzegovina",
            "    Botsuana",
            "    Brasil",
            "    Brunei",
            "    Bulgária",
            "    Burquina Faso",
            "    Burúndi",
            "    Butão",
            "    Cabo Verde",
            "    Camarões",
            "    Camboja",
            "    Canadá",
            "    Catar",
            "    Cazaquistão",
            "    Chade",
            "    Chile",
            "    China",
            "    Chipre",
            "    Clipperton Island",
            "    Colômbia",
            "    Comores",
            "    Congo-Brazzaville",
            "    Congo-Kinshasa",
            "    Coral Sea Islands",
            "    Coreia do Norte",
            "    Coreia do Sul",
            "    Costa do Marfim",
            "    Costa Rica",
            "    Croácia",
            "    Cuba",
            "    Curacao",
            "    Dhekelia",
            "    Dinamarca",
            "    Domínica",
            "    Egipto",
            "    Emiratos Árabes Unidos",
            "    Equador",
            "    Eritreia",
            "    Eslováquia",
            "    Eslovénia",
            "    Espanha",
            "    Estados Unidos",
            "    Estónia",
            "    Etiópia",
            "    Faroé",
            "    Fiji",
            "    Filipinas",
            "    Finlândia",
            "    França",
            "    Gabão",
            "    Gâmbia",
            "    Gana",
            "    Gaza Strip",
            "    Geórgia",
            "    Geórgia do Sul e Sandwich do Sul",
            "    Gibraltar",
            "    Granada",
            "    Grécia",
            "    Gronelândia",
            "    Guame",
            "    Guatemala",
            "    Guernsey",
            "    Guiana",
            "    Guiné",
            "    Guiné Equatorial",
            "    Guiné-Bissau",
            "    Haiti",
            "    Honduras",
            "    Hong Kong",
            "    Hungria",
            "    Iémen",
            "    Ilha Bouvet",
            "    Ilha do Natal",
            "    Ilha Norfolk",
            "    Ilhas Caimão",
            "    Ilhas Cook",
            "    Ilhas dos Cocos",
            "    Ilhas Falkland",
            "    Ilhas Heard e McDonald",
            "    Ilhas Marshall",
            "    Ilhas Salomão",
            "    Ilhas Turcas e Caicos",
            "    Ilhas Virgens Americanas",
            "    Ilhas Virgens Britânicas",
            "    Índia",
            "    Indian Ocean",
            "    Indonésia",
            "    Irão",
            "    Iraque",
            "    Irlanda",
            "    Islândia",
            "    Israel",
            "    Itália",
            "    Jamaica",
            "    Jan Mayen",
            "    Japão",
            "    Jersey",
            "    Jibuti",
            "    Jordânia",
            "    Kosovo",
            "    Kuwait",
            "    Laos",
            "    Lesoto",
            "    Letónia",
            "    Líbano",
            "    Libéria",
            "    Líbia",
            "    Listenstaine",
            "    Lituânia",
            "    Luxemburgo",
            "    Macau",
            "    Macedónia",
            "    Madagáscar",
            "    Malásia",
            "    Malávi",
            "    Maldivas",
            "    Mali",
            "    Malta",
            "    Man, Isle of",
            "    Marianas do Norte",
            "    Marrocos",
            "    Maurícia",
            "    Mauritânia",
            "    México",
            "    Micronésia",
            "    Moçambique",
            "    Moldávia",
            "    Mónaco",
            "    Mongólia",
            "    Monserrate",
            "    Montenegro",
            "    Mundo",
            "    Namíbia",
            "    Nauru",
            "    Navassa Island",
            "    Nepal",
            "    Nicarágua",
            "    Níger",
            "    Nigéria",
            "    Niue",
            "    Noruega",
            "    Nova Caledónia",
            "    Nova Zelândia",
            "    Omã",
            "    Pacific Ocean",
            "    Países Baixos",
            "    Palau",
            "    Panamá",
            "    Papua-Nova Guiné",
            "    Paquistão",
            "    Paracel Islands",
            "    Paraguai",
            "    Peru",
            "    Pitcairn",
            "    Polinésia Francesa",
            "    Polónia",
            "    Porto Rico",
            "    Portugal",
            "    Quénia",
            "    Quirguizistão",
            "    Quiribáti",
            "    Reino Unido",
            "    República Centro-Africana",
            "    República Dominicana",
            "    Roménia",
            "    Ruanda",
            "    Rússia",
            "    Salvador",
            "    Samoa",
            "    Samoa Americana",
            "    Santa Helena",
            "    Santa Lúcia",
            "    São Bartolomeu",
            "    São Cristóvão e Neves",
            "    São Marinho",
            "    São Martinho",
            "    São Pedro e Miquelon",
            "    São Tomé e Príncipe",
            "    São Vicente e Granadinas",
            "    Sara Ocidental",
            "    Seicheles",
            "    Senegal",
            "    Serra Leoa",
            "    Sérvia",
            "    Singapura",
            "    Sint Maarten",
            "    Síria",
            "    Somália",
            "    Southern Ocean",
            "    Spratly Islands",
            "    Sri Lanca",
            "    Suazilândia",
            "    Sudão",
            "    Sudão do Sul",
            "    Suécia",
            "    Suíça",
            "    Suriname",
            "    Svalbard e Jan Mayen",
            "    Tailândia",
            "    Taiwan",
            "    Tajiquistão",
            "    Tanzânia",
            "    Território Britânico do Oceano Índico",
            "    Territórios Austrais Franceses",
            "    Timor Leste",
            "    Togo",
            "    Tokelau",
            "    Tonga",
            "    Trindade e Tobago",
            "    Tunísia",
            "    Turquemenistão",
            "    Turquia",
            "    Tuvalu",
            "    Ucrânia",
            "    Uganda",
            "    União Europeia",
            "    Uruguai",
            "    Usbequistão",
            "    Vanuatu",
            "    Vaticano",
            "    Venezuela",
            "    Vietname",
            "    Wake Island",
            "    Wallis e Futuna",
            "    West Bank",
            "    Zâmbia",
            "    Zimbabué",
            ""});
            this.comboBoxPaises.Location = new System.Drawing.Point(354, 99);
            this.comboBoxPaises.Name = "comboBoxPaises";
            this.comboBoxPaises.Size = new System.Drawing.Size(282, 24);
            this.comboBoxPaises.TabIndex = 15;
            this.comboBoxPaises.Text = "(Selecione um País)";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelNome.Location = new System.Drawing.Point(18, 78);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(57, 20);
            this.labelNome.TabIndex = 14;
            this.labelNome.Text = "Nome";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelUsername.Location = new System.Drawing.Point(18, 129);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(94, 20);
            this.labelUsername.TabIndex = 13;
            this.labelUsername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(25, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 12;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(22, 154);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(282, 22);
            this.textBoxUsername.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(25, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 10;
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.Location = new System.Drawing.Point(22, 209);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(282, 22);
            this.textBoxEMail.TabIndex = 9;
            // 
            // buttonCriarConta
            // 
            this.buttonCriarConta.BackColor = System.Drawing.Color.Transparent;
            this.buttonCriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriarConta.ForeColor = System.Drawing.Color.Navy;
            this.buttonCriarConta.Location = new System.Drawing.Point(244, 327);
            this.buttonCriarConta.Name = "buttonCriarConta";
            this.buttonCriarConta.Size = new System.Drawing.Size(166, 48);
            this.buttonCriarConta.TabIndex = 8;
            this.buttonCriarConta.Text = "Criar Conta";
            this.buttonCriarConta.UseVisualStyleBackColor = false;
            this.buttonCriarConta.Click += new System.EventHandler(this.buttonCriarConta_Click);
            // 
            // labelPW
            // 
            this.labelPW.AutoSize = true;
            this.labelPW.BackColor = System.Drawing.Color.Transparent;
            this.labelPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPW.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelPW.Location = new System.Drawing.Point(18, 239);
            this.labelPW.Name = "labelPW";
            this.labelPW.Size = new System.Drawing.Size(129, 20);
            this.labelPW.TabIndex = 6;
            this.labelPW.Text = "Palavra-passe";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(22, 263);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(282, 27);
            this.textBoxPassword.TabIndex = 5;
            // 
            // labelE_Mail
            // 
            this.labelE_Mail.AutoSize = true;
            this.labelE_Mail.BackColor = System.Drawing.Color.Transparent;
            this.labelE_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelE_Mail.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelE_Mail.Location = new System.Drawing.Point(18, 186);
            this.labelE_Mail.Name = "labelE_Mail";
            this.labelE_Mail.Size = new System.Drawing.Size(56, 20);
            this.labelE_Mail.TabIndex = 4;
            this.labelE_Mail.Text = "Email";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(22, 101);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(282, 22);
            this.textBoxNom.TabIndex = 2;
            // 
            // labelRegisto
            // 
            this.labelRegisto.AutoSize = true;
            this.labelRegisto.BackColor = System.Drawing.Color.Transparent;
            this.labelRegisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisto.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelRegisto.Location = new System.Drawing.Point(268, 30);
            this.labelRegisto.Name = "labelRegisto";
            this.labelRegisto.Size = new System.Drawing.Size(119, 32);
            this.labelRegisto.TabIndex = 1;
            this.labelRegisto.Text = "Registo";
            // 
            // ViewRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::G06.Minesweeper.Winform.Properties.Resources.MinesweeperMod;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 505);
            this.Controls.Add(this.panelLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button buttonCriarConta;
        private System.Windows.Forms.Label labelPW;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelE_Mail;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelRegisto;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEMail;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Label labelFotografia;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.ComboBox comboBoxPaises;
    }
}