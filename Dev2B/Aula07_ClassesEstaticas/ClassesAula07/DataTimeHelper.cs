using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Aula07_ClassesEstaticas.ClassesAula07
{
        public static class DateTimeHelper
        {
            public static int GetIdade(DateTime dataNascimento)
            {
                return new DateTime((DateTime.Now - dataNascimento).Ticks).Year;
            }
        }
}
