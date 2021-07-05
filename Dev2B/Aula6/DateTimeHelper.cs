using System;
using System.Collections.Generic;
using System.Text;

namespace Aula6
{
    public static class DateTimeHelper
    {
        public static int CalcularIdade(DateTime idade)
        {
            return new DateTime((DateTime.Now - idade).Ticks).Year;
        }
    }
}
