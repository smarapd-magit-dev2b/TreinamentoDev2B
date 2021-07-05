using Aula6.Classes;
using Aula6.Exceptions;
using Aula6.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6
{
    public class TryCatch
    {
        public void Exercute()
        {
            try
            {
                Exercicio1();
            }
            catch (NegocioException negocioException)
            {
                Console.WriteLine(negocioException.Message);
            }
            catch (Exception negocioException)
            {
                Console.WriteLine($"Erro generio: { negocioException.Message}");
            }
            finally
            {
                Base bse = new Base();
                PessoaHelper.SaveInFile(bse.PessoaCollection, "Lista.txt");
            }
        }
        public void Exercicio1()
        {
            Base bse = new Base();
            var Pessoas = bse.PessoaCollection.Where(x => DateTimeHelper.GetIdade(x.DataNascimento) > 90).Count();
            if (Pessoas == 0)
            {
                throw new NegocioException("Erro de negócio: não existe pessoas com mais de 90 anos");
            }

        }
    }
}
