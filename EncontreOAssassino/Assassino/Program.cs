using System;

namespace Assassino
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Resposta rodada = new Resposta();
            
            System.Console.WriteLine("Suspeitos:");
            System.Console.WriteLine(" 1 - Charles B. Abbage \n 2- Donald Duck Knuth \n " +
             "3- Ada L. Ovelace \n 4- Alan T. Uring \n 5- Ivar J. Acobson \n 6- Ras Mus Ler Dorf");
            System.Console.WriteLine("Locais:");
            System.Console.WriteLine(" 1- Redmond \n 2- Palo Alto \n 3- San Francisco \n 4-Tokio \n 5- Restaurante no Fim do Universo" +
            "\n 6- São Paulo \n 7- Cupertino \n 8- Helsinki \n 9- Maida Vale\n 10- Toronto");
            System.Console.WriteLine("Armas: ");
            System.Console.WriteLine(" 1- Peixeira \n 2- DynaTAC 8000X (o primeiro aparelho celular do mundo)" +
             "\n 3- Trezoitão \n 4- Trebuchet \n 5- Maça \n 6- Gládio");

            var resultado = 0;
            do{
            System.Console.WriteLine("Insira uma teoria:");
            var teoria = Console.ReadLine();
            var input = teoria.Split(", ");
            resultado = rodada.ChecarResposta(Convert.ToInt16(input[0]), Convert.ToInt16(input[1]), Convert.ToInt16(input[2]));
            
            if(resultado >0)
            System.Console.WriteLine("Ao menos a posicao " + resultado + " é inválida");          
            else
            System.Console.WriteLine("Input inválido");

            }while (resultado != 0);
            

        }
    }
}
