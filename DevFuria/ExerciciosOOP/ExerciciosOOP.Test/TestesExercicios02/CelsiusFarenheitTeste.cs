using System;
using Xunit;
using ExerciciosOOP.Exercicios02;

namespace ExerciciosOOP.Test.TestesExercicios02
{
    public class CelsiusFarenheitTeste
    {
        [Fact(DisplayName = "Deve retornar o valor em farenheit")]
        public void ParaFarenheit()
        {
            var valorEsperado = 32;
            var valorAtual = CelsiusFarenheit.ParaFarenheit(0);
            Assert.Equal(valorEsperado, valorAtual);
            
        }

        [Fact(DisplayName = "Deve retornar o valor em Celsius")]
        public void ParaCelsius()
        {
            var valorEsperado = 0;
            var valorAtual = CelsiusFarenheit.ParaCelsius(32);
            Assert.Equal(valorEsperado, valorAtual);
        }
    }
}
