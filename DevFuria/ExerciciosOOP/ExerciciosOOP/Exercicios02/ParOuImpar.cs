using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExerciciosOOP.Exercicios02
{
    public class ParOuImpar
    {
        public int Numero { get; set; }


        public bool IsPar()
        {
            return this.Numero % 2 == 0;
        }
    }
}