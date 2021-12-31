using Dominio;
using Dominio.Classes;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Teste
{
    public class Fase1Teste
    {

        [Fact]
        /*
        *Função responsável por impedir a análise caso não sejam informados 8 registros 
        */
        public void QTD_DIF_8()
        {
            //arrange
            var lista = new List<Filme>();
            lista.Add(new Filme { Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5 });
            lista.Add(new Filme { Id = "tt7784604", Titulo = "Hereditário", Ano = 2018, Nota = 7.8 });

            var comparaFilmes = new ComparaFilmes();
            var primeiraFase = new Fase1(comparaFilmes);

            //act / assert
            Assert.Throws<ArgumentException>(() => primeiraFase.DefinirFilmesVencedores(lista));

        }

        [Fact]
        /*
        *Função responsável pela análise e classificação de quatro filmes
        */
        public void AN_CLAS_4()
        {
            //arrange
            var Entrada = new List<Filme>();
            Entrada.Add(new Filme { Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5 }); //1
            Entrada.Add(new Filme { Id = "tt7784604", Titulo = "Hereditário", Ano = 2018, Nota = 7.8 });//2
            Entrada.Add(new Filme { Id = "tt4881806", Titulo = "Jurassic World: Reino Ameaçado 2", Ano = 2018, Nota = 6.7 });//3
            Entrada.Add(new Filme { Id = "tt5164214", Titulo = "Oito Mulheres e um Segredo", Ano = 2018, Nota = 6.3 });//4
            Entrada.Add(new Filme { Id = "tt5463162", Titulo = "Deadpool 2", Ano = 2018, Nota = 8.1 });//5
            Entrada.Add(new Filme { Id = "tt2854926", Titulo = "Te Peguei!", Ano = 2018, Nota = 7.1 });//6
            Entrada.Add(new Filme { Id = "tt1365519", Titulo = "Tomb Raider: A Origem", Ano = 2018, Nota = 6.5 });//7
            Entrada.Add(new Filme { Id = "tt1825683", Titulo = "Pantera Negra", Ano = 2018, Nota = 7.5 });//8

            var Saida = new List<Filme>();
            Saida.Add(new Filme { Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5 });
            Saida.Add(new Filme { Id = "tt7784604", Titulo = "Hereditário", Ano = 2018, Nota = 7.8 });
            Saida.Add(new Filme { Id = "tt2854926", Titulo = "Te Peguei!", Ano = 2018, Nota = 7.1 });
            Saida.Add(new Filme { Id = "tt5463162", Titulo = "Deadpool 2", Ano = 2018, Nota = 8.1 });

            var comparaFilmes = new ComparaFilmes();
            var primeiraFase = new Fase1(comparaFilmes);

            //act
            var resultado = primeiraFase.DefinirFilmesVencedores(Entrada);

            //assert
            Assert.Equal(4, resultado.Count);
            Assert.Equal(Saida[0].Id, resultado[0].Id);
            Assert.Equal(Saida[1].Id, resultado[1].Id);
            Assert.Equal(Saida[2].Id, resultado[2].Id);
            Assert.Equal(Saida[3].Id, resultado[3].Id);
        }
    }
}
