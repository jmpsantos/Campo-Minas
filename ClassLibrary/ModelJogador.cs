using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class ModelJogador
    {
        public string nomeJogador;
        int dificuldade;
        int tempo;
        ModelRanking RankPlayer1;
        ModelRanking RankPlayer2;
        XDocument XML;


        public string GetPlayerRank1Nome()
        {
            return RankPlayer1.nomeJogador;
        }

        public string GetPlayerRank1Time()
        {
            return RankPlayer1.tempo.ToString();
        }

        public string GetPlayerRank2Nome()
        {
            return RankPlayer2.nomeJogador;
        }

        public string GetPlayerRank2Time()
        {
            return RankPlayer2.tempo.ToString();
        }

        public void CriarJogador(string nomeJogador, int dificuldade)
        {
            this.nomeJogador = nomeJogador;
            this.dificuldade = dificuldade;
        }
        public int IncrementarTempo()
        {
            tempo++;
            return tempo;
        }

        public void LoadXML()
        {
            RankPlayer1 = new ModelRanking();
            RankPlayer2 = new ModelRanking();
            XML = XDocument.Load(@"savedata.xml");
            RankPlayer1.dificuldade = 1;
            RankPlayer1.nomeJogador = XML.Root.Element("Fácil").Attribute("Nome").Value;
            RankPlayer1.tempo = Int32.Parse(XML.Root.Element("Fácil").Attribute("Tempo").Value);
            RankPlayer2.dificuldade = 2;
            RankPlayer2.nomeJogador = XML.Root.Element("Difícil").Attribute("Nome").Value;
            RankPlayer2.tempo = Int32.Parse(XML.Root.Element("Difícil").Attribute("Tempo").Value);
        }

        public bool SaveXML()
        {
            XML = XDocument.Load(@"savedata.xml");
            if (dificuldade == 1 && tempo < Int32.Parse(XML.Root.Element("Fácil").Attribute("Tempo").Value))
            {
                XML.Root.Element("Fácil").Attribute("Nome").Value = nomeJogador;
                XML.Root.Element("Fácil").Attribute("Tempo").Value = tempo.ToString();
                XML.Save("savedata.xml");
                return true;
            }
            if (dificuldade == 2 && tempo < Int32.Parse(XML.Root.Element("Difícil").Attribute("Tempo").Value))
            {
                XML.Root.Element("Difícil").Attribute("Nome").Value = nomeJogador;
                XML.Root.Element("Difícil").Attribute("Tempo").Value = tempo.ToString();
                XML.Save("savedata.xml");
                return true;
            }
            return false;
        }
    }
}
