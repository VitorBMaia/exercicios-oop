using ExerciciosOOP.Exercicios01;
using System;
using Xunit;

namespace ExerciciosOOP.Test
{
    public class TrocaVariaveisTest
    {
        [Fact]
        public void DadoQueAsVariaveisRecebemIntsTestarSeOsValoresRetornamTrocados()
        {
            var valorEsperado1 = 2;
            var valorEsperado2 = 1;
            
            var trocaValor = new TrocaVariaveis();
            trocaValor.valor1 = 1;
            trocaValor.valor2 = 2;
            trocaValor.TrocaValor();

            Assert.Equal(valorEsperado1, trocaValor.valor1);
            Assert.Equal(valorEsperado2, trocaValor.valor2);

        }
    }
}
