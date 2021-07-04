using System;
using System.Collections.Generic;
using System.Text;

namespace Aula7.HelpersClasse
{
    public static class DateTimeHelper
    {
        public static int GetIdade(DateTime dataNascimento)
        {
            var idade = new DateTime((DateTime.Now - dataNascimento).Ticks).Year;
            return idade;
        }
    }
}
