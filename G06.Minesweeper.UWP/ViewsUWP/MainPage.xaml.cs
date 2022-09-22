using G06.Minesweeper.Common.Models;
using G06.Minesweeper.UWP.ViewsUWP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.ApplicationModel.DataTransfer;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace G06.Minesweeper.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Painel> listaPaineis = new List<Painel>();
        private List<Button> listaButoes = new List<Button>();
        private SolidColorBrush lGray = new SolidColorBrush(Colors.LightGray);
        private SolidColorBrush lsGray = new SolidColorBrush(Colors.LightSlateGray);
        private SolidColorBrush Black = new SolidColorBrush(Colors.Black);

        private int linhas;
        private int colunas;
        private int totalMinas;
        private int totalMinasOrig;
        private int i = 0;

        private string jogoEstado;
        private bool jogoAtivo = true;
        public MainPage()
        {
            this.InitializeComponent();
            this.ConsultarMelhoresTemposFlyoutItem.Click += ConsultarMelhoresTemposFlyoutItem_Click;
        }

        private void ConsultarMelhoresTemposFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MelhoresTemposUWP));
        }

        private void restartGame()
        {
            statusTextBlock.Text = "";
            jogoAtivo = true;
            if (listaPaineis.Count != 0)
                listaPaineis.Clear();

            if (listaButoes.Count != 0)
                listaButoes.Clear();

            if (gridJogo.ColumnDefinitions.Count() != 0 && gridJogo.RowDefinitions.Count() != 0)
                gridJogo.Children.Clear();
        }

        private void facilFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            linhas = colunas = 9;
            totalMinas = 10;
            totalMinasOrig = totalMinas;


            mineCounterTextBlock.Text = $"{totalMinas}";

            restartGame();
            geradorPaineis();
            geradorGrid();

            DispatcherTimer dtf = new DispatcherTimer();
            dtf.Interval = TimeSpan.FromSeconds(1);
            dtf.Tick += Dt_TickFacil;
            dtf.Start();

            i = 0;
        }

        private void medioFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            linhas = colunas = 16;
            totalMinas = 40;
            totalMinasOrig = totalMinas;

            mineCounterTextBlock.Text = $"{totalMinas}";

            restartGame();
            geradorPaineis();
            geradorGrid();

            DispatcherTimer dtm = new DispatcherTimer();
            dtm.Interval = TimeSpan.FromSeconds(1);
            dtm.Tick += Dt_TickMedio;
            dtm.Start();

            i = 0;
        }

        #region Gerador de Paineis
        private void geradorPaineis()
        {
            preencherListaPaineis();
            gerarMinas();
            gerarVizinhos();
        } 

        private void preencherListaPaineis()
        {
            Painel painel;

            for(int i = 0; i < linhas; i++)
            {
                for(int j = 0; j < colunas; j++)
                {
                    painel = new Painel(i, j);
                    listaPaineis.Add(painel);
                }
            }
        }

        private void gerarMinas()
        {
            Random rng = new Random();

            while (listaPaineis.FindAll(x => x.Mina).Count() < totalMinas)
            {
                int linRNG = rng.Next(linhas);
                int colRNG = rng.Next(colunas);

                if(!(listaPaineis.Find(x => x.Linha == linRNG && x.Coluna == colRNG).Mina))
                {
                    listaPaineis.Find(x => x.Linha == linRNG && x.Coluna == colRNG).Mina = true;
                }
            }
        }

        private void gerarVizinhos()
        {
            Painel painel;

            for(int i = 0; i < linhas; i++)
            {
                for(int j = 0; j < colunas; j++)
                {
                    painel = listaPaineis.Find(x => x.Linha == i && x.Coluna == j);

                    //-----------------
                    //S
                    if(i + 1 < colunas)
                    {
                        painel.Vizinhos.Add(listaPaineis.Find(x => x.Linha == (i + 1) && x.Coluna == j));
                    }
                    //------------------
                    //S
                    if (i - 1 >= 0)
                    {
                        painel.Vizinhos.Add(listaPaineis.Find(x => x.Linha == (i - 1) && x.Coluna == j));
                    }
                    //-------------------
                    //E
                    if (j + 1 < colunas )
                    {
                        painel.Vizinhos.Add(listaPaineis.Find(x => x.Linha == i && x.Coluna == (j + 1)));
                    }
                    //-------------------
                    //O
                    if (j - 1 >= 0)
                    {
                        painel.Vizinhos.Add(listaPaineis.Find(x => x.Linha == i && x.Coluna == (j - 1)));
                    }
                    //-------------------
                    //SE
                    if (i + 1 < linhas && j + 1 < colunas)
                    {
                        painel.Vizinhos.Add(listaPaineis.Find(x => x.Linha == (i + 1) && x.Coluna == (j + 1)));
                    }
                    //-------------------
                    //NE
                    if (i - 1 >= 0 && j + 1 < colunas)
                    {
                        painel.Vizinhos.Add(listaPaineis.Find(x => x.Linha == (i - 1) && x.Coluna == (j + 1)));
                    }
                    //-------------------
                    //SO
                    if (i + 1 < linhas && j - 1 >= 0)
                    {
                        painel.Vizinhos.Add(listaPaineis.Find(x => x.Linha == (i + 1) && x.Coluna == (j - 1)));
                    }
                    //-------------------
                    //NO
                    if (i - 1 >= 0 && j - 1 >= 0)
                    {
                        painel.Vizinhos.Add(listaPaineis.Find(x => x.Linha == (i - 1) && x.Coluna == (j - 1)));
                    }
                }
            }
        }
        #endregion

        #region Butao
        private void geradorButoes()
        {
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Button b = new Button();

                    b.Tapped += B_Tapped;
                    b.RightTapped += B_RightTapped;

                    listaButoes.Add(b);
                    gridJogo.Children.Add(b);

                    Grid.SetRow(b, i);
                    Grid.SetColumn(b, j);
                }
            }
        }
        #endregion

        #region Gerador de Grid

        private void geradorGrid()
        {
            RowDefinition rowDef;
            ColumnDefinition colDef;

            for (int i = 0; i < linhas; i++)
            {
                rowDef = new RowDefinition();
                gridJogo.RowDefinitions.Add(rowDef);
            }

            for (int i = 0; i < colunas; i++)
            {
                colDef = new ColumnDefinition();
                gridJogo.ColumnDefinitions.Add(colDef);
            }

            geradorButoes();

            //Mostra as Minas

            //foreach (Button item in listaButoes)
            //{
            //    if(listaPaineis.ElementAt(listaButoes.IndexOf(item)).Mina)
            //    {
            //        item.Background = new SolidColorBrush(Colors.Red);
            //    }
            //}
        }


        #endregion

        #region Eventos Butao

        private void B_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Button b = (Button)sender;
            int indice = listaButoes.IndexOf(b);
            Painel p = listaPaineis.ElementAt(indice);

            if (jogoAtivo && !(p.Flagged) && !(p.Ambiguo) && !(p.Clicked))
            {
                if(!(p.Mina))
                {
                    NotMina_Click((Button)sender, p, indice);
                }
                else
                {
                    Mina_Click((Button)sender, indice);
                }
            }
        }

        private void B_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            Button b = (Button)sender;
            int indice = listaButoes.IndexOf(b);
            Painel p = listaPaineis.ElementAt(indice);

            if(jogoAtivo && !(p.Clicked))
            {
                if(!(p.Flagged) && !(p.Ambiguo))
                {
                    b.Content = "F"; //Foto aqui
                    p.Flagged = true;
                    totalMinas--;
                    mineCounterTextBlock.Text = $"{totalMinas}";
                }
                else if(p.Flagged && !(p.Ambiguo))
                {
                    b.Content = "?"; //Foto aqui
                    p.Flagged = false;
                    p.Ambiguo = true;
                    totalMinas++;
                    mineCounterTextBlock.Text = $"{totalMinas}";
                }
                else
                {
                    b.Content = ""; //Foto aqui
                    p.Flagged = false;
                    p.Ambiguo = false;
                }
            }

            if(p.Clicked && p.Vizinhos.Count(x => x.Ambiguo) == 0 && p.MinasProximas != 0 && p.Mina && p.Vizinhos.Count(x => x.Flagged) == p.MinasProximas && jogoAtivo )
            {
                foreach (Painel item in p.Vizinhos)
                {
                    if(item.MinasProximas != 0 && !item.Flagged)
                    {
                        listaButoes.ElementAt(listaPaineis.IndexOf(item)).Background = lGray;
                        listaButoes.ElementAt(listaPaineis.IndexOf(item)).Content = $"{item.MinasProximas}";
                        item.Clicked = true;
                    }
                    else if (item.MinasProximas == 0)
                    {
                        listaButoes.ElementAt(listaPaineis.IndexOf(item)).Background = lGray;
                    }
                    else
                    {

                    }
                }
            }
            else if(p.Clicked && p.Vizinhos.Count(x => x.Ambiguo) == 0 && !p.Mina && p.MinasProximas != 0 && p.Vizinhos.Count(x => x.Mina) != 0 && jogoAtivo)
            {
                foreach  (Painel item in p.Vizinhos)
                {
                    if (item.Mina)
                    {
                        Mina_Click(listaButoes.ElementAt(listaPaineis.IndexOf(item)), listaPaineis.IndexOf(item));
                    }
                }
            }
        }

        #endregion

        #region B_Tapped Logica

        private void floodFill(Painel p)
        {
            foreach(Painel Item in p.Vizinhos)
            {
                if (Item.Coluna >= 0 && p.Coluna < colunas && p.Linha >= 0 && p.Linha < linhas && !(Item.Clicked))
                {
                    if(Item.MinasProximas == 0)
                    {
                        listaButoes.ElementAt(listaPaineis.IndexOf(Item)).Background = lGray;
                        Item.Clicked = true;
                        floodFill(Item);
                    }
                    else if (Item.MinasProximas > 0)
                    {
                        listaButoes.ElementAt(listaPaineis.IndexOf(Item)).Background = lGray;
                        listaButoes.ElementAt(listaPaineis.IndexOf(Item)).Content = $"{Item.MinasProximas}";
                        Item.Clicked = true;

                    }
                }
            }
        }

        private void Venceu()
        {
            jogoEstado = "Venceu!";
            statusTextBlock.Text = jogoEstado;
            jogoAtivo = false;

            mineCounterTextBlock.Text = "0";

            Frame.Navigate(typeof(DadosVencedorUWP));
        }

        private void NotMina_Click(Button b, Painel p, int indice)
        {
            b.Background = lGray;

            if(p.MinasProximas != 0)
            {
                b.Content = $"{p.MinasProximas}";
                p.Clicked = true;
            }
            else if(p.MinasProximas == 0)
                floodFill(p);
            
            if(listaPaineis.FindAll(x => x.Clicked && !x.Mina).Count() == (listaPaineis.Count() - totalMinasOrig))
                Venceu();
        }

        private void Mina_Click(Button b, int indice)
        {

            foreach (Button item in listaButoes)
            {
                Painel p = listaPaineis.ElementAt(listaButoes.IndexOf(item));
                if (p.Mina)
                {
                    item.Background = Black;
                }
                else if (p.MinasProximas != 0 && !(p.Mina))
                {
                    item.Background = lGray;
                    item.Content = $"{p.MinasProximas}";
                }
                else
                {
                    item.Background = lGray;
                }
            }

            jogoEstado = "Perdi o Jogo!";
            statusTextBlock.Text = jogoEstado;
            jogoAtivo = false;
        }




        #endregion


        private void AjudaFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AjudaUWP));
        }
        private void JogarOnlineFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(LoginUWP));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
        }

        
        private void Dt_TickFacil(object sender, object e)
        {
            i++;

            timerTextBlock.Text = i.ToString();
        }

        private void Dt_TickMedio(object sender, object e)
        {
            i++;

            timerTextBlock.Text = i.ToString();
        }
    }



}
