using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_7
{
   public static class Idade
    {
       public static DateTime Data (DateTime DataNascimento)
        {

            return new DateTime((DateTime.Now - DataNascimento).Ticks);

        }
    
    
    }
}
