using ExerciciosOOP.Exercicios01;
using System;
using Xunit;

namespace ExerciciosOOP.Test
{
    public class CalculaDiasTest
    {
        [Fact]
        public void DeveRetornarAQuantidadeDeDias()
        {
            var valorEsperado = 90;
            CalculaDias calcula = new CalculaDias();
            calcula.Meses = 3;
            var valorAtual = calcula.CalcularDias();
            Assert.Equal(valorEsperado, valorAtual);

        }
    }
}
