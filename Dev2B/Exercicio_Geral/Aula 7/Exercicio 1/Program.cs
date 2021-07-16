using System;
using System.Linq;
using System.Collections.Generic;

namespace Aula_7
{
    class Program
    {
        private static object bse;

        public static bool Message { get; private set; }
        public static List<Pessoa> PessoaCollection { get; private set; }

        static void Main(string[] args)
        {
            Base resultado = new Base();

            var Maiorde90 = resultado.PessoaCollection.Count(x => x.Filhos != null && x.Filhos.Where(f => Idade.Data(f.DataNascimento).Year > 90).Any());

            var Pessoasde90 = resultado.PessoaCollection.Count(x => Idade.Data(x.DataNascimento).Year > 90);

            try
            {
                if (Maiorde90 <= 0 && Pessoasde90 <= 0) 
                {
                    throw new Erro();                
                }
          
            }
            catch(Erro e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                PessoaColection.Listar(PessoaCollection);

            }
            
           
        
        
        }

        
    }
}
