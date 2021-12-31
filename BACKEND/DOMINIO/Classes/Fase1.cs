using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dominio.Classes
{
    public class Fase1 : IFase1
    {
        private readonly IComparaFilmes _comparaFilmes;
        public Fase1(IComparaFilmes comparaFilmes)
        {
            _comparaFilmes = comparaFilmes;
        }
        public List<Filme> DefinirFilmesVencedores(List<Filme> filmes)
        {
            if (filmes.Count != 8)
                throw new ArgumentException("A disputa só terá início quando 8 filmes forem selecionados");

            var Vencedores = new List<Filme>();
            Vencedores.Add(_comparaFilmes.Vencedor(filmes.ElementAt(0), filmes.ElementAt(7)));
            Vencedores.Add(_comparaFilmes.Vencedor(filmes.ElementAt(1), filmes.ElementAt(6)));
            Vencedores.Add(_comparaFilmes.Vencedor(filmes.ElementAt(2), filmes.ElementAt(5)));
            Vencedores.Add(_comparaFilmes.Vencedor(filmes.ElementAt(3), filmes.ElementAt(4)));

            return Vencedores;
        }
    }
}
