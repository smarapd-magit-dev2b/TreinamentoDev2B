using System;
using System.Collections.Generic;
using System.Text;

namespace Aula7.Helpers
{
    public static class DateTimeHelper
    {
        public static int GetIdade(DateTime dataNascimento)
        {
            return new DateTime((DateTime.Now - dataNascimento).Ticks).Year;
        }
    }
}
