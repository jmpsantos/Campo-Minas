using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using G06.Minesweeper.Common.Diversos;
using G06.Minesweeper.Winform.ViewsWF;


namespace G06.Minesweeper.Winform.Views
{
    public partial class ViewPrincipal : Form, JanelaPrincipal
    {
        public event DelegadoVazio UserQuerSair;
        public event DelegadoVazio UserQuerAjuda;
        public event DelegadoINT UserQuerNovoJogo;
        public event DelegadoVazio UserQuerJogarOnline;
        public event DelegadoINT UserQuerConsultarMelhoresTempos;
        public event DelegadoVazio UserQuerConsultarTop10;
        public event DelegadoVazio EstadoLoginAlterado;

        private int contUS = 0;
        private int contDS = 0;
        private int contUM = 0;
        private int contDM = 0;

        public static int restrict = 0;
        public ControllerJogador C_Jogador { get; private set; }
        public ControllerCampo C_Campo { get; private set; }

        private int segundosTotal = 0;

        private int contPisca = 0;

        public ViewPrincipal()
        {
            InitializeComponent();

            Program.Modelo.EstadoLoginAlterado += Modelo_EstadoLoginAlterado;

        }

        private void Modelo_EstadoLoginAlterado()
        {
            if(EstadoLoginAlterado != null)
                if(Program.Modelo.EstadoLogin == 0)
                    menuStrip_Jogo_Top10.Enabled = false;
                else
                    menuStrip_Jogo_Top10.Enabled = true;
        }

        private void ViewPrincipal_Load(object sender, EventArgs e)
        {
            //Só deve iniciar quando clica numa mina
            timerCronometro.Enabled = true;
            timerPisca.Enabled = true;
        }

        private void timerCronometro_Tick(object sender, EventArgs e)
        {

            pictureBoxCronometro1.Image = imageListCronometro.Images[contDM];

            if (contDS > 5)
            {
                contDS = 0;
                contUM++;
            }

            if (contUM > 9)
            {
                contUM = 0;
                contDM++;
            }

            pictureBoxCronometro4.Image = imageListCronometro.Images[contDS];

            pictureBoxCronometro2.Image = imageListCronometro.Images[contUM];

            pictureBoxCronometro5.Image = imageListCronometro.Images[contUS];
            contUS++;

            if (contUS > 9)
            {
                contUS = 0;
                contDS++;
            }

            segundosTotal = (contUS + contDS * 10 + contUM * 60 + contDM * 600) - 1;
        }

        private void timerPisca_Tick(object sender, EventArgs e)
        {
            if (contPisca == 10)
            {
                pictureBoxCronometro3.Image = imageListPisca.Images[0];
                contPisca = 0;
            }
            else
            {
                pictureBoxCronometro3.Image = imageListPisca.Images[1];
                contPisca++;
            }
        }

        private void pictureBoxSmile_Click(object sender, EventArgs e)
        {
            if (UserQuerNovoJogo != null)
            {
                UserQuerNovoJogo(0);
            }
            else
            {
                MessageBox.Show("Tá Quieto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxSmile_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Show("Começar Novo Jogo", pictureBoxSmile);
            pictureBoxSmile.Image = imageListSmile.Images[0];
        }

        private void pictureBoxSmile_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxSmile.Image = imageListSmile.Images[3];
        }

        private void dificuldadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerCronometro.Stop();
            timerPisca.Stop();
            pictureBoxCronometro3.Image = imageListPisca.Images[0];
            MessageBox.Show("Você Perdeu! Deseja Jogar Novamente?", "Fim do Jogo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void menuStrip_Jogo_MT_Facil_Click(object sender, EventArgs e)
        {

            if (UserQuerConsultarMelhoresTempos != null)
            {
                UserQuerConsultarMelhoresTempos(0);
            }
            else
            {
                MessageBox.Show("Tá Quieto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void menuStrip_Jogo_MT_Medio_Click(object sender, EventArgs e)
        {
            if (UserQuerConsultarMelhoresTempos != null)
            {
                UserQuerConsultarMelhoresTempos(1);
            }
            else
            {
                MessageBox.Show("Tá Quieto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void menuStrip_JogarOnline_Click(object sender, EventArgs e)
        {
            timerCronometro.Stop();
            timerPisca.Stop();
            pictureBoxCronometro3.Image = imageListPisca.Images[0];

            if ((MessageBox.Show("Deseja perder o progresso e passar para o Modo Online?", "Jogo Online", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.No)
            {
                timerCronometro.Start();
                timerPisca.Start();
            }
            else if (UserQuerJogarOnline != null)
            {
                UserQuerJogarOnline();
            }
            else
            {
                MessageBox.Show("Tá Quieto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuStrip_Ajuda_Click(object sender, EventArgs e)
        {
            if (UserQuerAjuda != null)
            {
                UserQuerAjuda();
            }
            else
            {
                MessageBox.Show("Tá Quieto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuStrip_Jogo_Sair_Click(object sender, EventArgs e)
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

        private void menuStrip_Jogo_Top10_Click(object sender, EventArgs e)
        {
            if (UserQuerConsultarTop10 != null)
            {
                UserQuerConsultarTop10();
            }
            else
            {
                MessageBox.Show("Tá Quieto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuStrip_Jogo_Facil_Click(object sender, EventArgs e)
        {
            int TabDim = 9;
            int Bombas = 10;

            C_Campo.GerarCampo(TabDim, Bombas);
            CriarPainel();
        }

        private void menuStrip_Jogo_Medio_Click(object sender, EventArgs e)
        {
            int TabDim = 16;
            int Bombas = 40;

            C_Campo.GerarCampo(TabDim, Bombas);
            CriarPainel();
        }


        public void AbrirVizinhos(int X, int Y)
        {
            int n1, n2;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    n1 = X + i;
                    n2 = Y + j;
                    if (n1 >= 0 && n2 >= 0 && n1 < C_Campo.GetDimCampo() && n2 < C_Campo.GetDimCampo())
                    {
                        if (!(i == 0 && j == 0))
                        {
                            if (!C_Campo.GetIfBomba(n1, n2))
                            {
                                Control[] c = Controls.Find(n1 + ";" + n2, true);
                                Button b = (Button)c[0];
                                b.PerformClick();
                            }
                        }
                    }
                }
            }
        }

        public void CriarPainel()
        {
            for (int i = 0; i < C_Campo.GetDimCampo(); i++)
            {
                for (int j = 0; j < C_Campo.GetDimCampo(); j++)
                {
                    Button button = new Button();
                    button.Name = i + ";" + j;
                    button.Location = new Point(15 + (j * 24), 100 + (i * 24));
                    button.Size = new Size(26, 26);


                    button.Click += (sender, args) =>
                    {
                        int X = Int32.Parse(button.Name.Split(';')[0]);
                        int Y = Int32.Parse(button.Name.Split(';')[1]);
                        if (Form.ModifierKeys == Keys.Control)
                        {

                            if (C_Campo.SetFlag(X, Y))
                            {
                                button.BackgroundImageLayout = ImageLayout.Stretch;
                                button.BackgroundImage = Properties.Resources.Bandeira;
                                if (C_Campo.GetNumMinas() == 0)
                                {
                                    timerCronometro.Stop();

                                    DadosVencedor FormDadosVencedor;
                                    FormDadosVencedor = new DadosVencedor();

                                    FormDadosVencedor.ShowDialog();
                                    
                                    //Falta eventos para funcionar

                                    //textBoxInserirNome.Text = C_Jogador.getNome();
                                    //buttonSubmeterVencedor = C_Jogador.SaveXML();
                                    
                                   
                                    if (C_Jogador.SaveXML())
                                    {
                                        MessageBox.Show("Novo Recorde!!");
                                    }

                                }
                            }
                            else { button.BackgroundImage = Properties.Resources.Painel; }
                            return;
                        }

                        if (C_Campo.GetFlag(X, Y)) { return; }

                        if (C_Campo.GetIfBomba(X, Y))
                        {
                            button.BackgroundImageLayout = ImageLayout.Stretch;
                            button.BackgroundImage = Properties.Resources.Bomba;
                            MessageBox.Show("Bomba Encontrada! Perdeu Jogo!");
                            this.Close();
                        }
                        else
                        {
                            if (C_Campo.GetCount(X, Y) != 0)
                            {
                                button.BackgroundImageLayout = ImageLayout.Stretch;
                                button.Text = C_Campo.GetCount(X, Y).ToString();
                                switch (button.Text)
                                {
                                    case "1":
                                        button.BackgroundImage = Properties.Resources.um;
                                        break;
                                    case "2":

                                        button.BackgroundImage = Properties.Resources.Dois;
                                        break;
                                    case "3":

                                        button.BackgroundImage = Properties.Resources.tres;
                                        break;
                                    case "4":
                                        button.BackgroundImage = Properties.Resources.Quatro;
                                        break;

                                }
                                button.Enabled = false;
                            }
                            else { button.Text = " "; button.Enabled = false; }
                            if (C_Campo.GetCount(X, Y) == 0)
                            {
                                AbrirVizinhos(X, Y);
                            }
                        }


                    };

                    Controls.Add(button);
                }
            }
        }
    }
}


