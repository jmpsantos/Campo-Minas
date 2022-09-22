using System;
using System.Collections.Generic;
using System.Text;

namespace G06.Minesweeper.Common.Diversos
{
    public interface JanelaPrincipal
    {
        event DelegadoVazio UserQuerAjuda;
        event DelegadoINT UserQuerNovoJogo;
        event DelegadoVazio UserQuerJogarOnline;
        event DelegadoINT UserQuerConsultarMelhoresTempos;
        event DelegadoVazio UserQuerSair;
        event DelegadoVazio UserQuerConsultarTop10;
        event DelegadoVazio EstadoLoginAlterado;
    }

    public interface JanelaAjuda
    {
        event DelegadoVazio UserQuerSair;
        //event DelegadoVazio UserQuerConsultarYT;
        //event DelegadoVazio UserQuerConsultarWikipedia;
    }

    public interface JanelaConsultarMelhoresTempos
    {
        event DelegadoVazio UserQuerSair;
    }

    public interface JanelaConsultarTop10
    {
        event DelegadoVazio UserQuerSair;
    }

    public interface JanelaRegistar
    {
        event DelegadoRegisto UserQuerRegistar;
        event DelegadoVazio UserQuerSair;
    }

    public interface JanelaDadosVencedor
    {
        event DelegadoVencedor UserQuerRegistarNome;
        event DelegadoVazio UserNabo;
    }

    public interface JanelaLoadingOnline
    {
        event DelegadoVazio IniciarJanelaLogin;
    }

    public interface JanelaLogin
    {
        event DelegadoLogin UserQuerFazerLogin;
        event DelegadoVazio UserQuerSair;
        event DelegadoVazio UserQuerFazerRegisto;
    }
}
