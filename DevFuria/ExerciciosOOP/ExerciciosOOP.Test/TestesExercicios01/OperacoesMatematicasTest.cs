using ExerciciosOOP.Exercicios01;
using System;
using Xunit;

namespace ExerciciosOOP.Test.TestesExercicios01
{
    public class OperacoesMatematicasTest
    {
        [Fact]
        public void DeveRetornarASomaDosValores()
        {
            var valorEsperado = 10;
            OperacoesMatematicas operacoes = new OperacoesMatematicas();
            var valorAtual = operacoes.Somar(7, 3);
            Assert.Equal(valorEsperado, valorAtual);
        }

        [Fact]
        public void DeveRetornarASubtracaoDosValores()
        {
            var valorEsperado = 10;
            OperacoesMatematicas operacoes = new OperacoesMatematicas();
            var valorAtual = operacoes.Subtrair(20, 10);
            Assert.Equal(valorEsperado, valorAtual);
                 
        }

        [Fact]
        public void DeveRetornarOProdutoDosValores()
        {
            var valorEsperado = 120;
            OperacoesMatematicas operacoes = new OperacoesMatematicas();
            var valorAtual = operacoes.Multiplicar(12, 10);
            Assert.Equal(valorEsperado, valorAtual);
        }

        [Fact]
        public void DeveRetornarARazaoEntreOsValores()
        {
            var valorEsperado = 5;
            OperacoesMatematicas operacoes = new OperacoesMatematicas();
            var valorAtual = operacoes.Dividir(50, 10);
            Assert.Equal(valorEsperado, valorAtual);
        }

    }
}
