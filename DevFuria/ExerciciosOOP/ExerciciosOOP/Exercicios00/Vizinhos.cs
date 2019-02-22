using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOP.Exercicios01
{
    public class Vizinhos
    {
        public int Numero { get; set; }

        public int Sucessor()
        {
            return this.Numero + 1;
        }

        public int Antecessor()
        {
            return this.Numero - 1;
        }
    }
}
