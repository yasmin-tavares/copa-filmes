using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Classes
{
    public class ResultadoFinal : IResultadoFinal
    {
        private readonly IFase1 _fase1;
        private readonly IFase2 _fase2;
        private readonly IClassificacao _classificacao;
        public ResultadoFinal(IFase1 primeiraFase, IFase2 segundaFase, IClassificacao classificacao)
        {
            _fase1 = primeiraFase;
            _fase2 = segundaFase;
            _classificacao = classificacao;
        }
        public List<Filme> DefinirFilmesVencedores(List<Filme> filmes)
        {
            var listaOrdenada = filmes.OrderBy(x => x.Titulo).ToList();

            var resultadoPrimeiraFase = _fase1.DefinirFilmesVencedores(listaOrdenada);

            var resultadoSegundaFase = _fase2.DefinirFilmesVencedores(resultadoPrimeiraFase);

            var resultadoFinal = _classificacao.ClassificacaoFinal(resultadoSegundaFase);

            return resultadoFinal;
        }


    }
}
