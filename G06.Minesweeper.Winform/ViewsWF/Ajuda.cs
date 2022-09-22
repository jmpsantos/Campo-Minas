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
    public partial class Ajuda : Form, JanelaAjuda
    {
        public Ajuda()
        {
            InitializeComponent();
        }

        public event DelegadoVazio UserQuerSair;

        private void Ajuda_Load(object sender, EventArgs e)
        {
            webBrowserTutorial.Navigate("https://www.youtube.com/watch?v=7B85WbEiYf4");
        }

        private void webBrowser_Form_Closed(object sender, FormClosingEventArgs e)
        {
            webBrowserTutorial.Stop();
            webBrowserTutorial.GoHome();

            if (UserQuerSair != null)
            {
                UserQuerSair();
            }else
            {
                MessageBox.Show("Tente novamente ou volte mais tarde!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAjuda_YT_Click(object sender, EventArgs e)
        {
            webBrowserTutorial.Navigate("https://www.youtube.com/watch?v=7B85WbEiYf4");
        }

        private void buttonAjuda_Wiki_Click(object sender, EventArgs e)
        {
            webBrowserTutorial.Navigate("https://pt.wikipedia.org/wiki/Campo_minado");
        }
    }
}
