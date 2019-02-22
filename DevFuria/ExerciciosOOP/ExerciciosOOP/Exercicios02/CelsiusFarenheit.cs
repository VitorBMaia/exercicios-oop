using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOP.Exercicios02
{
    public static class CelsiusFarenheit
    {

        public static double ParaFarenheit(this double celsius)
        {
            return celsius * 9 / 5  + 32 ;
        }

        public static double ParaCelsius(this double farenheit)
        {
            return (farenheit - 32) * 5 / 9;
        }
    }
}
