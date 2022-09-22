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
    public partial class DadosVencedor : Form, JanelaDadosVencedor
    {
        
        public DadosVencedor()
        {
            InitializeComponent();
        }

        public event DelegadoVencedor UserQuerRegistarNome;
        public event DelegadoVazio UserNabo;

        private void DadosVencedor_Load(object sender, EventArgs e)
        {
            panelVenceu.BackColor = Color.White;
        }

        public void buttonSubmeterVencedor_Click(object sender, EventArgs e)
        {
            if(UserQuerRegistarNome != null)
            {
                UserQuerRegistarNome(textBoxInserirNome.Text, 0);
            }
            else
            {
                MessageBox.Show("Tente novamente ou volte mais tarde!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DadosVencedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (UserNabo != null)
                UserNabo();
            else
                MessageBox.Show("Tente novamente ou volte mais tarde!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
