using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aula7.Classes;
using Aula7.ExcecoesClasse;
using Aula7.HelpersClasse;

namespace Aula7
{
    public class ExcecoesTryCatch
    {
        public void Execute()
        {
            //Exercicio1();
            Exercicio2();
        }

        private int Exercicio1()
        {
            Base bs = new Base();

            var pessoasComMais90 = bs.PessoaCollection.Where(x => DateTimeHelper.GetIdade(x.DataNascimento) > 90) // salve vsalve familia
                .Count();
            if (pessoasComMais90 == 0)
            {
                throw new NegocioException("Erro de negócio: não existe pessoas com mais de 90 anos");
            }
            return pessoasComMais90;
        }

        private void Exercicio2()
        {
            Base bs = new Base();
            try
            {
                Exercicio1();
                Console.WriteLine($"Pessoas com mais de 90 anos: {Exercicio1()}");
            }
            catch (NegocioException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //var listapessoasComMais90 = bs.PessoaCollection.Where(x => DateTimeHelper
                //.GetIdade(x.DataNascimento) > 90).ToList();
                //ColecaoPessoasHelper.GetArquivos<Pessoa>(listapessoasComMais90);
                ColecaoPessoasHelper.GetArquivos<Pessoa>(bs.PessoaCollection);
            }
            Console.ReadKey();
        }
    }
}
