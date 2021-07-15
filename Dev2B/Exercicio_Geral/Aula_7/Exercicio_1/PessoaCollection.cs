using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aula_7.Exercicio_1
{
    public static class PessoaColection
    {
        public static void Listar(List<Pessoa> lista)
        {
            Base bse = new Base();

            File.WriteAllText("C:/Users/AWMMANHA/Documents/Exercicios/Exercicio feitos/Parte 7/Aula_7/Aula_7/Lista.txt", null);

            foreach (var pessoa in bse.PessoaCollection)
            {

                File.AppendAllText("C:/Users/AWMMANHA/Documents/Exercicios/Exercicio feitos/Parte 7/Aula_7/Aula_7/Lista.txt", pessoa.ToString());

            }

        }
    }
}
