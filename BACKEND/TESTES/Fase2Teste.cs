using Dominio;
using Dominio.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace Teste
{
    public class SegundaFaseTeste
    {

        [Fact]
        /*
        *Função responsável por impedir a análise caso não sejam informados 4 registros 
        */
        public void QTD_DIF_4()
        {
            //arrange
            var lista = new List<Filme>();
            lista.Add(new Filme { Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5 });
            lista.Add(new Filme { Id = "tt7784604", Titulo = "Hereditário", Ano = 2018, Nota = 7.8 });

            var comparaFilmes = new ComparaFilmes();
            var segundaFase = new Fase2(comparaFilmes);

            //act / assert
            Assert.Throws<ArgumentException>(() => segundaFase.DefinirFilmesVencedores(lista));
        }

        /*
                *Função responsável pela análise e classificação de quatro filmes
                */

        [Fact]
        public void AN_CLAS_2()
        {
            //arrange
            var Entrada = new List<Filme>();
            Entrada.Add(new Filme { Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5 });
            Entrada.Add(new Filme { Id = "tt7784604", Titulo = "Hereditário", Ano = 2018, Nota = 7.8 });
            Entrada.Add(new Filme { Id = "tt2854926", Titulo = "Te Peguei!", Ano = 2018, Nota = 7.1 });
            Entrada.Add(new Filme { Id = "tt5463162", Titulo = "Deadpool 2", Ano = 2018, Nota = 8.1 });

            var Saida = new List<Filme>();
            Saida.Add(new Filme { Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5 });
            Saida.Add(new Filme { Id = "tt5463162", Titulo = "Deadpool 2", Ano = 2018, Nota = 8.1 });

            var comparaFilmes = new ComparaFilmes();
            var segundafase = new Fase2(comparaFilmes);

            //act
            var resultado = segundafase.DefinirFilmesVencedores(Entrada);

            //assert
            Assert.Equal(2, resultado.Count);
            Assert.Equal(Saida[0].Id, resultado[0].Id);
            Assert.Equal(Saida[1].Id, resultado[1].Id);
        }
    }
}
