using System;
using Xunit;
using ExerciciosOOP.Exercicios02.Extensions;

namespace ExerciciosOOP.Test.TestesExercicios02
{
    public class MaiorQueDezTeste
    {
        [Fact(DisplayName = "Deve retornar se o numero e maior que dez")]
        public void DeveRetornarSeONumeroEMaiorQueDez()
        {
            var valorEsperado = true;
            var valorAtual = 11.EMaiorQueDez();
            Assert.Equal(valorEsperado, valorAtual);
        }
    }
}
