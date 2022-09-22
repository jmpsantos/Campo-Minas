using G06.Minesweeper.Common.Diversos;
using System.Windows.Forms;

namespace G06.Minesweeper.Winform.Views
{
    public partial class ConsultaMelhoresTempos : Form, JanelaConsultarMelhoresTempos
    {
        public ConsultaMelhoresTempos()
        {
            InitializeComponent();

            Program.Modelo.TipoConsultaAlterado += Modelo_TipoConsultaAlterado;
        }

        public event DelegadoVazio UserQuerSair;

        private void Modelo_TipoConsultaAlterado()
        {
            if (Program.Modelo.TipoConsulta == 0)
            {
                labelDificuldade.Text = "【F】【á】【c】【i】【l】";
                pictureBoxBackground.Image = Properties.Resources.gif_dab_winner;
            }
            else
            {
                labelDificuldade.Text = "【M】【é】【d】【i】【o】";
                pictureBoxBackground.Image = Properties.Resources.gif_boss_winner;
            }
        }
    }
}
