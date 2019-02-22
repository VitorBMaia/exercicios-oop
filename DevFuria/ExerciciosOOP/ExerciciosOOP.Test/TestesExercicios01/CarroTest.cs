using ExerciciosOOP.Exercicios01;
using System;
using Xunit;

namespace ExerciciosOOP.Test.TestesExercicios01
{
    public class CarroTest
    {
        [Fact]
        public void DeveRetornarOValorFinal()
        {
            var valorEsperado = 1000 * (1 + 0.28 + 0.45);
            Carro carro = new Carro();
            carro.Valor = 1000;
            var valorAtual = carro.CustoFinal();
            Assert.Equal(valorEsperado, valorAtual);
        }
    }
}
