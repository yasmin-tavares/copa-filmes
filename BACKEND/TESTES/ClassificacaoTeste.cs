using Dominio;
using Dominio.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Teste
{
    public class ClassificacaoTeste
    {

        [Fact]
        public void QTD_DIF_2()
        {
            //arrange
            var lista = new List<Filme>();
            lista.Add(new Filme { Id = "tt7784604", Titulo = "Hereditário", Ano = 2018, Nota = 7.8 });

            var classificacao = new Classificacao();

            //act / assert
            Assert.Throws<ArgumentException>(() => classificacao.ClassificacaoFinal(lista));
        }

        [Fact]
        public void Resultado()
        {
            //arrange
            var Entrada = new List<Filme>();
            Entrada.Add(new Filme { Id = "tt5463162", Titulo = "Deadpool 2", Ano = 2018, Nota = 8.1 });
            Entrada.Add(new Filme { Id = "tt3606756", Titulo = "Os Incríveis 2", Ano = 2018, Nota = 8.5 });

            //act
            var classificacao = new Classificacao();

            var resultado = classificacao.ClassificacaoFinal(listaEntrada);

            //assert          
            Assert.Equal(2, resultado.Count);
            Assert.Equal(Entrada[1].Id, resultado[0].Id);
            Assert.Equal(Entrada[0].Id, resultado[1].Id);


        }

    }
}
