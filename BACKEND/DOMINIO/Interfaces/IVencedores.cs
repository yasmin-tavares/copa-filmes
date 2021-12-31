using System.Collections.Generic;

namespace Dominio.Interfaces
{
    public interface IVencedores
    {
        List<Filme> DefinirFilmesVencedores(List<Filme> filmes);
    }
}
