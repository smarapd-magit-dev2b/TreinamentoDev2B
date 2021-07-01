using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02.Classes
{
    public class ItemVenda
    {
        public int NumeroItem { get; set; }

        public string Descricao { get; set; }

        public decimal PrecoUnitario { get; set; }

        public int QuantidadeComprada { get; set; }
        public ItemVenda(int numeroItem, string descricao, int quantidadeComprada, decimal precoUnitario)
        {
            NumeroItem = numeroItem;
            Descricao = descricao;

            if (quantidadeComprada < 0)
                QuantidadeComprada = 0;
            else
                QuantidadeComprada = quantidadeComprada;

            if (precoUnitario < 0)
                PrecoUnitario = 0.0m;
            else
                QuantidadeComprada = quantidadeComprada;
        }

        public decimal ValorFatura()
        {
            return PrecoUnitario * QuantidadeComprada;
        }
    }
}
