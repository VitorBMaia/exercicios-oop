using ExerciciosOOP.Exercicios02;
using ExerciciosOOP.Exercicios02.Extensions;
using System;
using Xunit;

namespace ExerciciosOOP.Test.TestesExercicios02
{
    public class PositivoOuNegativoTest
    {
        [Fact(DisplayName = "Deve retornar se o numero é Negativo")]
        public void DeveretornarSeONumeroENegativo()
        {
            var valorEsperado = true;
            //var negativoOuPositivo = new NegativoOuPositivo();
            //negativoOuPositivo.Numero = 10;
            //var valorAtual = negativoOuPositivo.IsPositivo();
            var valorAtual = 10.EPositivo();

            Assert.Equal(valorEsperado, valorAtual);

        }
    }
}
