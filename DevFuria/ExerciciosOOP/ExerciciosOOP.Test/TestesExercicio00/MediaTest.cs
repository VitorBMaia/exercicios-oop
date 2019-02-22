using ExerciciosOOP.Exercicios01;
using System;
using Xunit;

namespace ExerciciosOOP.Test
{
    public class MediaTest
    {
        [Fact]
        public void DeveRetornarAMediaDosvalores()
        {
            var valorEsperado = 10;
            var media = new Media();
            media.PrimeiroNumero = 9;
            media.SegundoNumero = 10;
            media.TerceiroNumero = 11;

            var valorAtual = media.CalculaMedia();
            Assert.Equal(valorAtual, valorEsperado);
        }
    }
}
