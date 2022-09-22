using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G06.Minesweeper.Winform
{
    public class ControllerCampo
    {
        public bool GetIfBomba(int X, int Y)
        {
            return Program.Campo.GetIfBomba(X, Y);
        }

        public int GetNumMinas()
        {
            return Program.Campo.GetNumMinas();
        }

        public int GetDimCampo()
        {
            return Program.Campo.Dimensao;
        }

        public void GerarCampo(int TabDim, int NumMinas)
        {
            Program.Campo.GerarCampo(TabDim, NumMinas);
        }

        public int GetCount(int X, int Y)
        {
            return Program.Campo.GetCount(X, Y);
        }

        public bool GetFlag(int X, int Y)
        {
            return Program.Campo.GetFlag(X, Y);
        }

        public bool SetFlag(int X, int Y)
        {
            return Program.Campo.SetFlag(X, Y);
        }

        public void Dispose() { }
    }
}

