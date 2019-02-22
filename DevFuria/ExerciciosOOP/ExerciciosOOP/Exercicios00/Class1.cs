using System;

namespace ExerciciosOOP.Exercicios01
{
    public class TrocaVariaveis
    {
        public int valor1 { get; set; }
        public int valor2 { get; set; }

        public void TrocaValor()
            {

            var temp = this.valor1;
            valor1 = valor2;
            valor2 = temp;

            //valor1 = valor1 + valor2;
            //valor2 = valor1 - valor2;
            //valor1 = valor1 - valor2;
            }
    }
}
