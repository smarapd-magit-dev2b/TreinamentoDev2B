using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Helpers
{
    public class DateTimeHelper
    {
        public static int Idade(DateTime dataNascimento)
        {
            var idade = new DateTime((DateTime.Now - dataNascimento).Ticks).Year;
            return idade;
        }
    }
}