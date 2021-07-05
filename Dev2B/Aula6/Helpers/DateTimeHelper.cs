using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6.Helpers
{
    public static class DateTimeHelper
    {
        public static int GetIdade(DateTime dataNascimento)
        {
            return new DateTime((DateTime.Now - dataNascimento).Ticks).Year;
        }
    }
}
