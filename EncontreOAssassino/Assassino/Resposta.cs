using System;
using System.Collections.Generic;

namespace Assassino
{
    public class Resposta
    {
  
        
        public int[] Fato { get; set; }
    
        public Resposta(){
            Fato = new int[3];
            Random rdm = new Random();
            Fato[0] = rdm.Next(1, 7);
            Fato[1] = rdm.Next(1, 11);
            Fato[2] = rdm.Next(1, 7);
        }

        public int ChecarResposta(int suspeito, int lugar, int arma){
            
            if(suspeito < 1 || lugar < 1 || arma < 1)
                return -1;

            if(suspeito > 6 || lugar > 10 || arma > 6)
                return -1;

            var lista = new List<int>();
            Random rdm = new Random();

            if(suspeito != Fato[0] )
                lista.Add(1);

            if(lugar != Fato[1])
                lista.Add(2);

            if(arma != Fato[2])
                lista.Add(3);
            
            if(lista.Count == 0)
            return 0;

            return lista[rdm.Next(0, lista.Count)];
        }

        
    }
}