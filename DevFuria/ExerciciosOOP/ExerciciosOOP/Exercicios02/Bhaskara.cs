using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOP.Exercicios02
{
    public class Bhaskara
    {
        public (double, double) Calcular(double a, double b, double c)
        {
            var x1 = ((b * -1) + Math.Sqrt(b * b - 4 * a * c))/2;
            var x2 = ((b * -1) - Math.Sqrt(b * b - 4 * a * c)) / 2;
            return (x1, x2);
        }
    }
}
