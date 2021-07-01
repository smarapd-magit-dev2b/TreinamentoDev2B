using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Exercicio4
{
    class Venda
    {
        public Venda()
        {
            Console.WriteLine("Digite o id da venda: ");
            Id = Console.ReadLine();
            Console.WriteLine("Digite a data da venda: ");
            DataVenda = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite o vendedor da venda: ");
            Vendedor = Console.ReadLine();
            
        }

        public string Id { get; set; }
        public DateTime DataVenda { get; set; }
        public string Vendedor { get; set; }
        public List<ItemVenda> ListaItens { get; set; }

    }
}
