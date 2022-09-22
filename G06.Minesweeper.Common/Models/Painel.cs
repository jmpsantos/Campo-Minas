using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace G06.Minesweeper.Common.Models
{
    public class Painel
    {
        public bool Mina { get; set; }
        public bool Clicked { get; set; }
        public bool Flagged { get; set; }
        public bool Ambiguo { get; set; }

        //Posição Painel
        public int Coluna { get; set; }
        public int Linha { get; set; }

        //Painéis Vizinhos (lista)
        public List<Painel> Vizinhos { get; set; }
        //Procura por minas na vizinhança

        public int MinasProximas => Vizinhos.Count(x => x.Mina);

        public Painel(int lin, int col)
        {
            Vizinhos = new List<Painel>(); //new List<Painel>();

            Linha = lin;
            Coluna = col;

        }






        //int linhas = -1;
        //int colunas = -1;
        //bool visitada = false;
        //bool bomba = false;
        //int vizinhos = 0;



        //public Painel(int lin, int col)
        //{
        //    linhas = lin;
        //    colunas = col;
        //}

        //public bool getVisitada()
        //{
        //    return visitada;
        //}

        //public bool getBomba()
        //{
        //    return bomba;
        //}

        //public int getVizinhos()
        //{
        //    return vizinhos;
        //}

        //public int getLinhas()
        //{
        //    return linhas;
        //}

        //public int getColunas()
        //{
        //    return colunas;
        //}

        ////SETS

        //public void setVisitada(bool vis)
        //{
        //    visitada = vis;
        //}

        //public void setBomba(bool b)
        //{
        //    bomba = b;
        //}

        //public void setVizinhos(int viz)
        //{
        //    vizinhos = viz;
        //}

        //public void setLinhas(int lin)
        //{
        //    linhas = lin;
        //}

        //public void setColunas(int col)
        //{
        //    colunas = col;
        //}
    }
}
