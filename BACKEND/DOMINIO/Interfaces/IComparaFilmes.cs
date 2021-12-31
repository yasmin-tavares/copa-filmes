using System.Collections.Generic;

namespace Dominio.Interfaces
{
    public interface IComparaFilmes
    {
        Filme Vencedor(Filme filmeA, Filme filmeB);
    }
}
