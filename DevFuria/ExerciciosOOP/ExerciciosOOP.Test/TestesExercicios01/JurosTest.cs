using ExerciciosOOP.Exercicios00;
using System;
using Xunit;

namespace ExerciciosOOP.Test.TestesExercicios01
{
    public class JurosTest
    {

        [Fact]
        public void DeveRetornarOValorDoJuros()
        {
            var valorEsperado = 1000 * 0.05 * 2;
            var juros = new Juros();
            juros.Capital = 1000;
            juros.Taxa = 0.05;
            juros.Periodo = 2;
            var valorAtual = juros.CalculaJuros();
            Assert.Equal(valorEsperado, valorAtual);
        }
    }
}
