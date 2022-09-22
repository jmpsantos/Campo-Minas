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

namespace G06.Minesweeper.Winform.ViewsWF
{
    public partial class ConsultarTop10 : Form, JanelaConsultarTop10
    {
        public ConsultarTop10()
        {
            InitializeComponent();
        }

        public event DelegadoVazio UserQuerSair;

        private void ConsultarTop10_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (UserQuerSair != null)
            {
                UserQuerSair();
            }
            else
            {
                MessageBox.Show("Tá Quieto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
