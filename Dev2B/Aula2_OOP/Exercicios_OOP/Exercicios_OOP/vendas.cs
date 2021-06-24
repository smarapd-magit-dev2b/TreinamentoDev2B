using Classes;
using System;

namespace Exercicios_OOP
{
    class vendas
    {
        static void Main(string[] args)
        {
            int opcao;

            itemVenda feijao = new itemVenda(1, "Feijão Broto Legal", -10.00m, -5);
            itemVenda arroz = new itemVenda(2, "Arroz do Bom", 15.00m, 2);
            do
            {
                Console.WriteLine("\n\n1) Feijão.\n2) Arroz.\n3) Sair.\nDeseja mostrar os dados de qual produto?");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (opcao == 1)
                {
                    feijao.validacoes();
                    feijao.dados();
                }
                if (opcao == 2)
                {
                    arroz.validacoes();
                    arroz.dados();
                }
            } while (opcao != 3);
            

            
            

            
        }
    }
}
