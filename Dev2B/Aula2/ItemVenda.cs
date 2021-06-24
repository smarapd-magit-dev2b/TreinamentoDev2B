using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2
{
    public class ItemVenda
    {
        public int NumeroItem { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeComprada { get; set; }
        public decimal PrecoUnitario { get; set; }

        public ItemVenda()
        {

        }

        public ItemVenda(int numeroItem, string descricao, int quantidadeComprada, decimal precoUnitario)
        {
            NumeroItem = numeroItem;
            Descricao = descricao;
            QuantidadeComprada = quantidadeComprada < 0 ? 0 : quantidadeComprada;
            PrecoUnitario = precoUnitario < 0 ? 0 : precoUnitario;
        }

        public decimal CalcularValorTotal()
        {
            return PrecoUnitario * QuantidadeComprada;
        }

        public void EscreverProduto()
        {
            decimal valorFatura = CalcularValorTotal();
            Console.WriteLine($"\nO numero do produto é {NumeroItem}.");
            Console.WriteLine($"A descrição do produto é {Descricao}.");
            Console.WriteLine($"A quantidade do produto é {QuantidadeComprada}.");
            Console.WriteLine($"O preço unitário do produto é {PrecoUnitario}.");
            Console.WriteLine($"O valor da fatura do produto é {valorFatura}.");
        }
    }
}
