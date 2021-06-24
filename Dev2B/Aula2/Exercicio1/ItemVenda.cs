using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Exercicio1
{
    public class ItemVenda
    {
        private int NumItem { get; set; }
        private string DescricaoItem { get; set; }
        private int Quantidade { get; set; }
        private decimal PrecoUnitario { get; set; }

        public ItemVenda (int numItem, string descricaoItem, int quantidade, decimal precoUnitario)
        {
            NumItem = numItem;
            DescricaoItem = descricaoItem;
            if (quantidade < 0)
                Quantidade = 0;
            else
                Quantidade = quantidade;
            if (precoUnitario < 0)
                PrecoUnitario = 0.0m;
            else
                PrecoUnitario = precoUnitario;
        }

        private decimal CalcularValorTotal ()
        {
            return Quantidade * PrecoUnitario;
        }

        public void EscreverProduto()
        {
            decimal valorFatura = CalcularValorTotal();
            Console.WriteLine($"\nO numero do produto é {NumItem}.");
            Console.WriteLine($"A descrição do produto é {DescricaoItem}.");
            Console.WriteLine($"A quantidade do produto é {Quantidade}.");
            Console.WriteLine($"O preço unitário do produto é {PrecoUnitario}.");
            Console.WriteLine($"O valor da fatura do produto é {valorFatura}.");
        }


        
    }
}
