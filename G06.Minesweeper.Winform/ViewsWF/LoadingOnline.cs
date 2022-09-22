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
    public partial class LoadingOnline : Form, JanelaLoadingOnline
    {
        public LoadingOnline()
        {
            InitializeComponent();
        }

        private int count_bar = 0;

        private int num_al_time;
        private int num_al_bar;

        private Random rnd_bar, rnd_time;

        public event DelegadoVazio IniciarJanelaLogin;

        private void LoadingOnline_Load(object sender, EventArgs e)
        {
            timerLoadingOnline.Enabled = true;
        }

        private void timerLoadingOnline_Tick(object sender, EventArgs e)
        {
            rnd_time = new Random();
            rnd_bar = new Random();

            num_al_time = rnd_time.Next(1, 50);
            num_al_bar = rnd_bar.Next(0, 10);

            timerLoadingOnline.Interval = num_al_time;

            count_bar += num_al_bar;

            panelFront.Width = count_bar;
            
            if(count_bar > 499)
            {
                timerLoadingOnline.Stop();
                
                Hide();

                if(IniciarJanelaLogin != null)
                {
                    IniciarJanelaLogin();
                }
                else
                {
                    MessageBox.Show("Tá Quieto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                Close();
            }
        }
    }
}
