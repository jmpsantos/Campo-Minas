using G06.Minesweeper.Common.Diversos;
using System;
using System.Collections.Generic;
using System.Text;

namespace G06.Minesweeper.Common.Models
{
    public class Model
    {
        public event DelegadoVazio ValorIntAlterado;
        public event DelegadoVazio ValorStringAlterado;

        public event DelegadoVazio EstadoJogoAlterado;
        public event DelegadoVazio EstadoLoginAlterado;
        public event DelegadoVazio TipoConsultaAlterado;

        private int _valorInt;
        private string _valorString;
        private int _estadoJogo;
        private int _estadoLogin;
        private int _tipoConsulta;

        public int ValorInt
        {
            get
            {
                return _valorInt;
            }
            set
            {
                _valorInt = value;
                if (ValorIntAlterado != null)
                {
                    ValorIntAlterado();
                }
            }
        }

        public string ValorString
        {
            get
            {
                return _valorString;
            }
            set
            {
                _valorString = value;
                if (ValorStringAlterado != null)
                {
                    ValorStringAlterado();
                }
            }
        }

        public int EstadoLogin
        {
            get
            {
                return _estadoLogin;
            }
            set
            {
                _estadoLogin = value;
                if (EstadoLoginAlterado != null)
                {
                    EstadoLoginAlterado();
                }
            }
        }

        public int EstadoJogo
        {
            get
            {
                return _estadoJogo;
            }
            set
            {
                _estadoJogo = value;
                if (EstadoJogoAlterado != null)
                {
                    EstadoJogoAlterado();
                }
            }
        }

        public int TipoConsulta
        {
            get
            {
                return _tipoConsulta;
            }
            set
            {
                _tipoConsulta = value;
                if (TipoConsultaAlterado != null)
                {
                    TipoConsultaAlterado();
                }
            }
        }
    }
}
