namespace ExerciciosOOP.Exercicios02.Extensions
{
    public static class ExtensaoNumero
    {
        public static bool EPositivo(this int numero) => numero > 0;
        public static bool EPositivo(this decimal numero) => numero > 0;
        public static bool EPositivo(this float numero) => numero > 0;

        public static bool EPar(this int numero) => numero % 2 == 0;
        public static bool EPar(this decimal numero) => numero % 2 == 0;
        public static bool EPar(this float numero) => numero % 2 == 0;


        public static bool EMaiorQueDez(this int numero) => numero > 10;
        public static bool EMaiorQueDez(this decimal numero) => numero > 10;
        public static bool EMaiorQueDez(this float numero) => numero > 10;

    }
}
