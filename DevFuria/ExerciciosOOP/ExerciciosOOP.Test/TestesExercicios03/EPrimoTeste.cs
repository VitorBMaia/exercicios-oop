using System;
using Xunit;
using ExerciciosOOP.Exercicios03.Extensoes;

namespace ExerciciosOOP.Test.TestesExercicios03
{
    public class EPrimoTeste
    {
        [Fact(DisplayName = "Deve retornar se o numero e primo")]
        public void DeveRetornarSeONumeroEPrimo()
        {
            var valorEsperado = true;
            var valorAtual = 3.EPrimo();
            Assert.Equal(valorEsperado, valorAtual);
        }
    }
}
