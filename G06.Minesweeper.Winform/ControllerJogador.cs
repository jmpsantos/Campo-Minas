using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G06.Minesweeper.Winform
{
    public class ControllerJogador
    {
        public void CriarJogador(string nome, int dif)
        {
            Program.Jogador.CriarJogador(nome, dif);
        }
        public string getNome()
        {
            return Program.Jogador.nomeJogador;
        }
        public int IncrementarTempo()
        {
            return Program.Jogador.IncrementarTempo();
        }

        public void LoadXML()
        {
            Program.Jogador.LoadXML();
        }

        public string GetPlayerRank1Nome()
        {
            return Program.Jogador.GetPlayerRank1Nome();
        }

        public string GetPlayerRank1Time()
        {
            return Program.Jogador.GetPlayerRank1Time();
        }

        public string GetPlayerRank2Nome()
        {
            return Program.Jogador.GetPlayerRank2Nome();
        }

        public string GetPlayerRank2Time()
        {
            return Program.Jogador.GetPlayerRank2Time();
        }

        public bool SaveXML()
        {
            return Program.Jogador.SaveXML();
        }

        public void Dispose() { }
    }
}
