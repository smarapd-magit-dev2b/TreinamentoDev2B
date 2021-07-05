using Aula6.Classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace Aula6.Helpers
{
    public static class PessoaHelper
    {
        public static void SaveInFile(List<Pessoa> pessoas , string nomeArquivo)
        {
            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo) , null); 

            foreach (var item in pessoas)
            {
                File.AppendAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo), item.ToString());
            }
        }
    }
}
