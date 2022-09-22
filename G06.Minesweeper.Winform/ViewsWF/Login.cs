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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }

        private void linkLabelRecoverPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewRecuperarPassword FormRecuperarPassword;
            FormRecuperarPassword = new ViewRecuperarPassword();

            FormRecuperarPassword.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
    }
}
