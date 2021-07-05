using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6.Classes.ClassesExe01 {
    public class Helper : Pessoa{

        public static void GetList<T>(List<T> lista) {
            
            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lista_Pessoas.txt"), null);

            foreach (T listapessoas in lista) {
                File.AppendAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lista_Pessoas.txt"), listapessoas.ToString());
            }
           
        }
    }
}
