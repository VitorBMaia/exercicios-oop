using ExerciciosOOP.Exercicios01;
using System;
using Xunit;

namespace ExerciciosOOP.Test
{
    public class AreaQuadradaTest
    {
        [Fact]
        public void DeveRetornarOValorDaArea()
        {
            var valorEsperado = 8;
            var areaQuadrada = new AreaQuadrada();

            areaQuadrada.Altura = 2;
            areaQuadrada.Base = 4;

            var valorRecebido = areaQuadrada.CalculaArea();
            Assert.Equal(valorEsperado, valorRecebido);

        }
    }
}
