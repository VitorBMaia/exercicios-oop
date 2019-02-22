using ExerciciosOOP.Exercicios01;
using System;
using Xunit;
namespace ExerciciosOOP.Test
{
        namespace DobraNumero.Test
        { 
            public class DobraNumeroTest
            {
                [Fact]
                public void DeveRetornarODobroDoValorRecebido()
                {
                   var valorEsperado = 2;
                   var dobraNumero = new DobrarNumero();
                   dobraNumero.Numero = 1;
                   dobraNumero.DobraNumero();
                   Assert.Equal(valorEsperado, dobraNumero.Numero);

                   


                }

            }
        }
}
