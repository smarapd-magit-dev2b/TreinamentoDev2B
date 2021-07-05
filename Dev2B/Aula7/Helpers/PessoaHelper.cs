using Aula7.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aula7.Helpers
{
    public class PessoaHelper : Pessoa
    {

        public static void GetList<T>(List<T> lista)
        {

            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lista_Pessoas.txt"), null);

            foreach (T listapessoas in lista)
            {
                File.AppendAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lista_Pessoas.txt"), listapessoas.ToString());
            }

        }
    }
}
