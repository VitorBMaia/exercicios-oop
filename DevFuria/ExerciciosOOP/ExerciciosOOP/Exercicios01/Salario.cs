using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOP.Exercicios00
{
    public class Salario
    {
        public double Valor { get; set; }

        public void Reajuste(double taxa)
        {
            this.Valor *= 1 + taxa;
        }
    }
}
