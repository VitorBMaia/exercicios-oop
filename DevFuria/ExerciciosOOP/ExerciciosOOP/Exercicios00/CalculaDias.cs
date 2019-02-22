using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOP.Exercicios01
{
    public class CalculaDias
    {
        public int Meses { get; set; }

        public int CalcularDias()
        {
            return this.Meses * 30;
        }
    }
}
