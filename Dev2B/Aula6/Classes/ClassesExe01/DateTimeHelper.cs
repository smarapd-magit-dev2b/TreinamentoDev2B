using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6.Classes.ClassesExe01 {
    public static class DateTimeHelper {
    
        public static int Idade(DateTime datanascimento) {
            return new DateTime((DateTime.Now - datanascimento).Ticks).Year; 
        }
    }
}
