using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOP.Exercicios00
{
    public class Juros
    {
        public double Capital { get; set; }
        public double Taxa { get; set; }
        public int Periodo { get; set; }

        public double CalculaJuros()
        {
            return Capital * Taxa * Periodo;
        }
    }
}
