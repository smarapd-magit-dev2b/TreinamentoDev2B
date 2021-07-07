using System;
using System.Collections.Generic;
using System.Text;

namespace Aula06.Classes
{
    public static class DateTimeHelper
    {
        public static DateTime Data { get; set; }

        public static int CalculaAno(DateTime data)
        {
            Data = data;

            return new DateTime((DateTime.Now - Data).Ticks).Year;
        }

    }
}
