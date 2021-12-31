using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Classes
{
    public class Classificacao : IClassificacao
    {

        public List<Filme> ClassificacaoFinal(List<Filme> filmes)
        {
            if (filmes.Count != 2)
                throw new ArgumentException("Para a classificação final são necessários 2 filmes");

            List<Filme> ResultadoOrdenado;

            if (filmes.ElementAt(0).Nota > filmes.ElementAt(1).Nota || filmes.ElementAt(1).Nota > filmes.ElementAt(0).Nota)
                ResultadoOrdenado = filmes.OrderByDescending(x => x.Nota).ToList();
            else
                ResultadoOrdenado = filmes.OrderBy(x => x.Titulo).ToList();

            return ResultadoOrdenado;
        }
    }
}
