using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IServicoFilmes
    {
        Task<IEnumerable<Filme>> ObterFilmes();
    }
}
