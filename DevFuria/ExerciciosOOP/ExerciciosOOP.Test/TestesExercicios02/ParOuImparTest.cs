using ExerciciosOOP.Exercicios02;
using System;
using Xunit;

namespace ExerciciosOOP.Test.TestesExercicios02
{
    public class ParOuImparTest
    {
        [Fact]
        public void DeveRetornarSeONumeroEPar()
        {
            var valorEsperado = true;
            ParOuImpar parOuImpar = new ParOuImpar();
            parOuImpar.Numero = 2;
            var valorAtual = parOuImpar.IsPar();
            Assert.Equal(valorEsperado, valorAtual);

        }
    }
}
