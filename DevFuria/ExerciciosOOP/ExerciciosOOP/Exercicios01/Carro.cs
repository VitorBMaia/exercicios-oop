using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOP.Exercicios01
{
    public class Carro
    {
        const double PERCENTUAL_DISTRIBUIDOR = 0.28;
        const double PERCENTUAL_IMPOSTOS = 0.45;
        
        public double Valor { get; set; }


        public double CustoFinal()
        {
            return Valor * (1 + PERCENTUAL_DISTRIBUIDOR + PERCENTUAL_IMPOSTOS);
        }
    }
}
