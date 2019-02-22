using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOP.Exercicios03.Extensoes
{
    public static class ExtensaosNumeros
    {
        public static bool EPrimo(this int numero)
        {

            for (int i = 2; i < Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
                    
            }

            return true;
        }
    }
}
