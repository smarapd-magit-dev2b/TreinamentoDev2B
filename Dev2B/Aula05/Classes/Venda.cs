using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05.Classes
{
    public class Venda
    {
        public string ID { get; set; }
        public DateTime DataVenda { get; set; }
        public string Vendedor { get; set; }

        public List<ItemVenda> Itens { get; set; }

        public Venda(string id, DateTime dataVenda, string vendedor)
        {
            ID = id;
            DataVenda = dataVenda;
            Vendedor = vendedor;
            Itens = new List<ItemVenda>();
        }
    }
}
