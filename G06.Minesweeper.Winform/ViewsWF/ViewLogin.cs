using G06.Minesweeper.Common.Diversos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G06.Minesweeper.Winform.Views
{
    public partial class ViewLogin : Form, JanelaLogin
    {
        public ViewLogin()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }

        public event DelegadoLogin UserQuerFazerLogin;
        public event DelegadoVazio UserQuerSair;
        public event DelegadoVazio UserQuerFazerRegisto;

        private void linkLabelRecoverPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewRecuperarPassword FormRecuperarPassword;
            FormRecuperarPassword = new ViewRecuperarPassword();

            FormRecuperarPassword.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panelLogin.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void buttonRegistar_Click(object sender, EventArgs e)
        {
            ViewRegister FormRegister;
            FormRegister = new ViewRegister();

            FormRegister.ShowDialog();

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //if login com sucesso
            Program.Modelo.EstadoLogin = 1;

            if (textBoxEmail.Text != null && textBoxPassword != null)
            {
                if(UserQuerFazerLogin != null)
                {
                    UserQuerFazerLogin(textBoxEmail.Text, textBoxPassword.Text);
                }
                else
                {
                    MessageBox.Show("Errou Miseravéuuullll", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha Todos os Campos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void ViewLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (UserQuerSair != null)
            {
                UserQuerSair();
            }
            else
            {
                MessageBox.Show("Errou Miseravéuuullll", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
