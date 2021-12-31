using System.Collections.Generic;

namespace Dominio.Interfaces
{
    public interface IClassificacao
    {
        List<Filme> ClassificacaoFinal(List<Filme> filmes);
    }
}
