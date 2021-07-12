using System;
using System.Collections.Generic;
using System.Text;

namespace Common.ClassHelpers
{
    public static class IdadeHelper
    {
        public static int CalcularIdade(DateTime idade)
        {
            return new DateTime((DateTime.Now - idade).Ticks).Year;
        }
    }
}


