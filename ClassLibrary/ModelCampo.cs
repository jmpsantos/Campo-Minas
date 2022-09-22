using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class ModelCampo
    {
        public ModelBomba[,] Campo;
        public int Dimensao;
        int NumMinasGeradas;
        int NumMinas;

        public bool GetIfBomba(int X, int Y)
        {
            return Campo[X, Y].flagMina;
        }

        public int GetCount(int X, int Y)
        {
            return Campo[X, Y].BombasVizinhas;
        }

        public void GerarMinas()
        {
            Random rng = new Random();
            int X, Y;
            while (NumMinasGeradas != 0)
            {
                X = rng.Next(0, Dimensao);
                Y = rng.Next(0, Dimensao);

                if (Campo[X, Y].flagMina == false)
                {
                    Campo[X, Y].flagMina = true;
                    int n1, n2;
                    for (int i = -1; i < 2; i++)
                    {
                        for (int j = -1; j < 2; j++)
                        {
                            n1 = X + i;
                            n2 = Y + j;
                            if (n1 >= 0 && n2 >= 0 && n1 < Dimensao && n2 < Dimensao)
                            {
                                Campo[X + i, Y + j].BombasVizinhas++;
                            }
                        }
                    }
                    NumMinasGeradas--;
                }
            }
        }

        public int GetNumMinas()
        {
            return NumMinas;
        }

        public bool GetFlag(int X, int Y)
        {
            return Campo[X, Y].flagBandeira;
        }

        public bool SetFlag(int X, int Y)
        {
            if (Campo[X, Y].flagBandeira == false)
            {
                Campo[X, Y].flagBandeira = true;
                if (Campo[X, Y].flagMina == true)
                {
                    NumMinas--;
                }

                return true;
            }
            else
            {
                Campo[X, Y].flagBandeira = false;
                if (Campo[X, Y].flagMina == true)
                {
                    NumMinas++;
                }

                return false;
            }
        }

        public void GerarCampo(int Dimensao, int NumMinas)
        {
            NumMinasGeradas = NumMinas;
            this.NumMinas = NumMinas;
            this.Dimensao = Dimensao;
            Campo = new ModelBomba[Dimensao, Dimensao];
            for (int i = 0; i < Dimensao; i++)
            {
                for (int j = 0; j < Dimensao; j++)
                {
                    Campo[i, j] = new ModelBomba();
                }
            }
            GerarMinas();
        }
    }
}

