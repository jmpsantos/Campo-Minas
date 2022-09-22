using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G06.Minesweeper.Winform.Controllers
{
    public class ControllerWF
    {
        public ControllerWF()
        {
            Program.V_Principal.UserQuerAjuda += V_Principal_UserQuerAjuda;
            Program.V_Principal.UserQuerSair += V_Principal_UserQuerSair;
            Program.V_Principal.UserQuerNovoJogo += V_Principal_UserQuerNovoJogo;
            Program.V_Principal.UserQuerJogarOnline += V_Principal_UserQuerJogarOnline;
            Program.V_Principal.UserQuerConsultarMelhoresTempos += V_Principal_UserQuerConsultarMelhoresTempos;
            Program.V_Principal.UserQuerConsultarTop10 += V_Principal_UserQuerConsultarTop10;

            Program.V_LoadingOnline.IniciarJanelaLogin += V_LoadingOnline_IniciarJanelaLogin;

            Program.V_Ajuda.UserQuerSair += V_Ajuda_UserQuerSair;

            Program.V_Login.UserQuerSair += V_Login_UserQuerSair;
            Program.V_Login.UserQuerFazerLogin += V_Login_UserQuerFazerLogin;
            Program.V_Login.UserQuerFazerRegisto += V_Login_UserQuerFazerRegisto;

            Program.V_Register.UserQuerRegistar += V_Register_UserQuerRegistar;
            Program.V_Register.UserQuerSair += V_Register_UserQuerSair;

            Program.V_DadosVencedor.UserNabo += V_DadosVencedor_UserNabo;
            Program.V_DadosVencedor.UserQuerRegistarNome += V_DadosVencedor_UserQuerRegistarNome;

            Program.V_CT10.UserQuerSair += V_CT10_UserQuerSair;

            Program.Modelo.ValorInt = 0;
            Program.Modelo.ValorString = "-";

            Program.Modelo.EstadoLogin = 0;
            Program.Modelo.EstadoJogo = 0;
            Program.Modelo.TipoConsulta = 0;
        }

        private void V_Principal_UserQuerConsultarTop10()
        {
        }

        private void V_CT10_UserQuerSair()
        {
            (Program.V_CT10 as Form).Close();
        }

        private void V_DadosVencedor_UserQuerRegistarNome(string str, int tempo)
        {
            (Program.V_DadosVencedor as Form).Hide();
            (Program.V_Principal as Form).ShowDialog();
            (Program.V_DadosVencedor as Form).Close();
        }

        private void V_DadosVencedor_UserNabo()
        {
            Application.Exit();
        }

        private void V_Register_UserQuerSair()
        {
            (Program.V_Register as Form).Hide();
            (Program.V_Login as Form).ShowDialog();
            (Program.V_Register as Form).Close();
        }

        private void V_Register_UserQuerRegistar(string nome, string username, string email, string password, string pais, string imagem)
        {
            throw new NotImplementedException();
        }

        private void V_Login_UserQuerFazerRegisto()
        {
            (Program.V_Login as Form).Hide();
            (Program.V_Register as Form).ShowDialog();
            (Program.V_Login as Form).Close();
        }

        private void V_Login_UserQuerFazerLogin(string email, string password)
        {
            Program.Modelo.EstadoLogin = 1;
        }

        private void V_Login_UserQuerSair()
        {
            (Program.V_Login as Form).Hide();
            //Application.Restart();
            (Program.V_Principal as Form).ShowDialog();
            (Program.V_Login as Form).Close();
        }

        private void V_Ajuda_UserQuerSair()
        {
            (Program.V_Principal as Form).Show();
        }

        private void V_LoadingOnline_IniciarJanelaLogin()
        {
            (Program.V_LoadingOnline as Form).Hide();
            (Program.V_Login as Form).ShowDialog();
            (Program.V_LoadingOnline as Form).Close();
        }

        private void V_Principal_UserQuerConsultarMelhoresTempos(int valor)
        {
            Program.Modelo.TipoConsulta = valor;
            (Program.V_CMT as Form).ShowDialog();
        }

        private void V_Principal_UserQuerJogarOnline()
        {
            (Program.V_Principal as Form).Hide();
            (Program.V_LoadingOnline as Form).ShowDialog();
            (Program.V_Principal as Form).Close();
        }

        private void V_Principal_UserQuerNovoJogo(int valor)
        {
            throw new NotImplementedException();
        }

        private void V_Principal_UserQuerSair()
        {
            Application.Exit();
        }

        private void V_Principal_UserQuerAjuda()
        {
            (Program.V_Principal as Form).Hide();
            (Program.V_Ajuda as Form).ShowDialog();
        }
    }
}
