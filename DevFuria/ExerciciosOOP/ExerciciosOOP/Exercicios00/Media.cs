using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOP.Exercicios01
{
    public class Media
    {
        public double PrimeiroNumero { get; set; }
        public double SegundoNumero { get; set; }
        public double TerceiroNumero { get; set; }

        public double CalculaMedia()
        {
            return (PrimeiroNumero + SegundoNumero + TerceiroNumero) / 3;
        }
    }
}
