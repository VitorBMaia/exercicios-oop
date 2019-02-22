using ExerciciosOOP.Exercicios00;
using System;
using Xunit;

namespace ExerciciosOOP.Test.TestesExercicios01
{
    public class SalarioTest
    {
        [Fact]
        public void DadaUmaTaxaDeveReajustarOSalario()
        {
            var valorEsperado = 2000;
            var salario = new Salario();
            salario.Valor = 1000;
            salario.Reajuste(1);
            Assert.Equal(valorEsperado, salario.Valor);
        }

    }
}
