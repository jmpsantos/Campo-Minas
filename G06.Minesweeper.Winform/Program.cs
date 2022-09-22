using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using G06.Minesweeper.Winform.Controllers;
using G06.Minesweeper.Common.Models;
using ClassLibrary;
//Para não ter que especificar sempre a pasta

using G06.Minesweeper.Winform.ViewsWF;
using G06.Minesweeper.Common.Diversos;
using G06.Minesweeper.Winform.Views;

namespace G06.Minesweeper.Winform
{
    static class Program
    {

        public static ModelCampo Campo { get; private set; }
        public static ModelJogador Jogador { get; private set; }
        public static ModelBomba Mina { get; private set; }
        public static Model Modelo { get; private set; }
        public static JanelaPrincipal V_Principal { get; private set; }
        public static JanelaDadosVencedor V_DadosVencedor { get; private set; }
        public static JanelaAjuda V_Ajuda { get; private set; }
        public static JanelaConsultarMelhoresTempos V_CMT { get; private set; }
        public static JanelaConsultarTop10 V_CT10 { get; private set; }
        public static JanelaLoadingOnline V_LoadingOnline { get; private set; }
        public static JanelaLogin V_Login { get; private set; }
        public static ViewRecuperarPassword V_RecuperarPassword { get; private set; }
        public static JanelaRegistar V_Register { get; private set; }
        public static ControllerWF C_WF { get; private set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Modelo = new Model();

            Campo = new ModelCampo();
            Jogador = new ModelJogador();
            Mina = new ModelBomba();

            V_Principal = new ViewPrincipal();
            V_DadosVencedor = new DadosVencedor();
            V_Ajuda = new Ajuda();
            V_CMT = new ConsultaMelhoresTempos();
            V_CT10 = new ConsultarTop10();
            V_LoadingOnline = new LoadingOnline();
            V_Login = new ViewLogin();
            V_RecuperarPassword = new ViewRecuperarPassword();
            V_Register = new ViewRegister();
           
            C_WF = new ControllerWF();

            
            Application.Run(V_Principal as Form);
        }
    }
}
