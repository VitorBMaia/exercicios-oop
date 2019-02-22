using ExerciciosOOP.Exercicios02;
using System;
using Xunit;

namespace ExerciciosOOP.Test.TestesExercicios02
{
    public class BhaskaraTeste
    {
        [Fact(DisplayName = "Deve Retornar as duas solucoes da equacao")]
        public void DeveRetornarAsDuasSolucoesDaEquacao()
        {
            var valorEsperado = (2,2);
            var equacao = new Bhaskara();
            var valorAtual = equacao.Calcular(1, -4, 4);
            Assert.Equal(valorEsperado, valorAtual);
        }
    }
}
