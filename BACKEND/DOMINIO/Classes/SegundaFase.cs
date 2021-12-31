using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Classes
{
    public class SegundaFase : ISegundaFase
    {
        private readonly IComparaFilmes _comparaFilmes;
        public SegundaFase(IComparaFilmes comparaFilmes)
        {
            _comparaFilmes = comparaFilmes;
        }
        public List<Filme> DefinirFilmesVencedores(List<Filme> filmes)
        {
            if (filmes.Count != 4)
                throw new ArgumentException("A disputa a partir daqui utiliza 4 filmes");

            var Vencedores = new List<Filme>();
            Vencedores.Add(_comparaFilmes.Vencedor(filmes.ElementAt(0), filmes.ElementAt(1)));
            Vencedores.Add(_comparaFilmes.Vencedor(filmes.ElementAt(2), filmes.ElementAt(3)));

            return Vencedores;
        }
    }
}
