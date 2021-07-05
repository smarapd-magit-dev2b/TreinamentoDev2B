using Aula7.Classes;
using Aula7.Helpers;
using System;
using System.Linq;

namespace Aula7
{
    public class TryCathStatic
    {
        public void Executar()
        {
            Exercicio1();
        }

        private void Exercicio1()
        {
            Base bse = new Base();

            var todasPessoas = bse.PessoaCollection.Union(bse.PessoaCollection.Where(p => p.Filhos != null).SelectMany(p => p.Filhos)).ToList();

            Console.WriteLine("----- TODAS AS PESSOAS E SUAS IDADES -----\n");

            foreach (var pessoa in todasPessoas)
            {
                var idade = DateTimeHelper.GetIdade(pessoa.DataNascimento);

                Console.WriteLine($"Nome: {pessoa.Nome} / Idade: {idade}");
            }

            Console.WriteLine();

            var pessoasCom90anos = bse.PessoaCollection.Count(x => DateTimeHelper.GetIdade(x.DataNascimento) > 90);

            try
            {
                if (pessoasCom90anos <= 0)
                    throw new NegocioException("Erro de negócio: não existe pessoas com mais de 90 anos");
                else
                    throw new NegocioException($"{pessoasCom90anos} pessoa(s) possue(m) idade maior que 90 anos");
            }
            catch (NegocioException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                PessoaHelper.GetList<Pessoa>(bse.PessoaCollection);
                Console.WriteLine("\nArquivo salvo com suecesso!");
            }
        }
    }
}
