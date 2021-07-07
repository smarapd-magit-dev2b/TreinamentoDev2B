using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Aula06.Classes
{
    public static class EscreverPessoaArquivoHelper
    {
        public static List<Pessoa> Pessoas { get; set; }

        public static void EscreverPessoas(List<Pessoa> pessoas)
        {
            Pessoas = pessoas;

            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Pessoas.txt"), null);

            foreach (Pessoa pessoa in Pessoas)
            {
                //File.WriteAllText("C:/UsersAMJARIA/Desktop/treinamento/exercícios/TreinamentoDev2B/Dev2B/Application/Pessoas.txt", pessoa.Nome.ToString());
                File.AppendAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Pessoas.txt"), $" {pessoa.Nome}\n");
            }

        }
    }
}
