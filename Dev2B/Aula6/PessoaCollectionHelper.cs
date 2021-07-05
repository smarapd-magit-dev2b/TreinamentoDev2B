using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aula6
{
    public static class PessoaCollectionHelper
    {
        public static void Listar(List<Pessoa> pessoas)
        {
            File.WriteAllText("D:/dev2b/TreinamentoDev2B/Dev2B/Application/Lista.txt", null);
            foreach (var pessoa in pessoas)
            {
                File.AppendAllText("D:/dev2b/TreinamentoDev2B/Dev2B/Application/Lista.txt", pessoa.ToString());
            }
        }
    }
}
