using ExerciciosOOP.Exercicios01;
using System;
using Xunit;

namespace ExerciciosOOP.Test
{
    public class VizinhosTest
    {

        [Fact]
        public void DeveRetornarOSucessor()
        {
            var valorEsperado = 10;
            var vizinhos = new Vizinhos();
            vizinhos.Numero = 9;
            var valorAtual = vizinhos.Sucessor();
            Assert.Equal(valorEsperado, valorAtual);
        }

        [Fact]
        public void DeveRetornarOAntecessor()
        {
            var valorEsperado = 10;
            var vizinhos = new Vizinhos();
            vizinhos.Numero = 11;
            var valorAtual = vizinhos.Antecessor();
            Assert.Equal(valorEsperado, valorAtual);


        }
    }
}
