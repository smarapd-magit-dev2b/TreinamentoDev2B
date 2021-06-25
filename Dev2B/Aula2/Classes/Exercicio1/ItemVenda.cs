using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class ItemVenda
    {
        public int NumeroDoItem { get; set; }
        public string Desgricao { get; set; }
        public int QuantidadeComprada { get; set; }
        public decimal PrecoUnitario { get; set; }

        public ItemVenda(int numeroDoItem, string desgricao, int quantidadeComprada, decimal precoUnitario)
        {
            NumeroDoItem = numeroDoItem;
            Desgricao = desgricao;
            QuantidadeComprada = quantidadeComprada < 0 ? 0 : quantidadeComprada;
            PrecoUnitario = precoUnitario < 0 ? 0 : precoUnitario;
        }

        public decimal CalcularValorTotal()
        {
            return PrecoUnitario * QuantidadeComprada;
        }
    }
}
