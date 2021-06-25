using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2.Exercicio1
{
    class ItemVenda
    {
        public string NumeroItem { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeCompra { get; set; }
        public decimal PrecoUnitario { get; set; }

        public ItemVenda(string numero, string descricao, int quantidadeCompra, decimal preco)
        {
            NumeroItem = numero;
            Descricao = descricao;
            if (quantidadeCompra < 0)
                QuantidadeCompra = 0;
            else
                QuantidadeCompra = quantidadeCompra;
            if (preco < 0)
                PrecoUnitario = 0;
            else
                PrecoUnitario = preco;
        }
        public decimal calcularValorTotal()
        {
            decimal total = QuantidadeCompra * PrecoUnitario;
            return total;
        }
    }
}
