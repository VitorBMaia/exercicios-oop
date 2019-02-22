using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOP.Exercicios01
{
    public class AreaQuadrada
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double CalculaArea()
        {
            return this.Base * this.Altura;
        }
    }
}
