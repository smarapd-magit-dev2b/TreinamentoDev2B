using Aula06_Lambdas.ClassesAula06;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aula07_ClassesEstaticas.ClassesAula07
{
    public static class PessoaHelper
    {
        public static void SaveInFile(List<Pessoa> pessoas, string nomeArquivo)
        {
            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo), null);

            foreach (var item in pessoas)
            {
                File.AppendAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo), item.ToString());
            }
        }
    }
}
