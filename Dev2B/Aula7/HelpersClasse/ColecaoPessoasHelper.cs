using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Aula7.Classes;

namespace Aula7.HelpersClasse
{
    public class ColecaoPessoasHelper
    {
        public static void GetArquivos<T>(List<T> lista)
        {
            foreach (T ex in lista)
            {
                    File.AppendAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lista.txt"),
                    ex.ToString());
            }
        }

    }
}
