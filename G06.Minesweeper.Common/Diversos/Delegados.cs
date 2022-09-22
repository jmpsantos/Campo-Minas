using System;
using System.Collections.Generic;
using System.Text;

namespace G06.Minesweeper.Common.Diversos
{
        public delegate void DelegadoVazio();
        public delegate void DelegadoINT(int valor);
        public delegate void DelegadoSTRING(string str);
        public delegate void DelegadoRegisto(string nome, string username, string email, string password, string pais, string imagem);
        public delegate void DelegadoLogin(string email, string password);
        public delegate void DelegadoVencedor(string nome, int email);
}
