using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Helper
{
   public class DateTimeHelper
    {
        public static int Idade(DateTime dataNascimento) => new DateTime((DateTime.Now - dataNascimento).Ticks).Year;

    }
}
