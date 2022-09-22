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
    public partial class ViewRegister : Form, JanelaRegistar
    {
        Bitmap imagem; 
        public ViewRegister()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }

        public event DelegadoRegisto UserQuerRegistar;
        public event DelegadoVazio UserQuerSair;

        private string imagemBase64;

        private void Register_Load(object sender, EventArgs e)
        {
            panelLogin.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Ficheiros JPG(*.jpg)|*.jpg|Ficheiros PNG(*.png)|*.png|Todos os Ficheiros|*.*";
                dlg.CheckFileExists = true;
                dlg.Multiselect = false;


                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    imagem = new Bitmap(dlg.FileName);
                    pictureBoxFoto.Image = imagem;

                    byte[] arrayImagem = System.IO.File.ReadAllBytes(dlg.FileName);
                    string Base64 = Convert.ToBase64String(arrayImagem);

                    imagemBase64 = Base64;
                }
            }
            catch
            {
                MessageBox.Show("Erro ao abrir o ficheiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonCriarConta_Click(object sender, EventArgs e)
        {
            if (UserQuerRegistar != null)
            {
                UserQuerRegistar(textBoxNom.Text, textBoxUsername.Text, textBoxEMail.Text, textBoxPassword.Text, comboBoxPaises.Text, imagemBase64);
                UserQuerSair();
            }
            else
            {
                MessageBox.Show("Tente novamente ou volte mais tarde!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
