using Lambdas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula6
{
    public class DateTimeHelper
    {

        public static DateTime Data { get; set; }

        
        
        public static int Date(DateTime data)
        {
            Data = data;

            return new DateTime((DateTime.Now - Data ).Ticks).Year;
        }
    }
}
