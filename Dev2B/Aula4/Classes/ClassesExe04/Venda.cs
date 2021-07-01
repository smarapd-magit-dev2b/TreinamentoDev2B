using System;
using System.Collections.Generic;

namespace Aula4.Classes.ClassesExe04 {
    class Venda {
        public int ID { get; set; }
        public DateTime DataVenda { get; set; }
        public string Vendedor { get; set; }
        public List<ItemVenda> Itens { get; set; }

        public Venda() {
            Itens = new List<ItemVenda>();
        }

        internal object FirstOrDefault(Func<object, bool> p) {
            throw new NotImplementedException();
        }
    }
    public class ItemVenda {
        public int IDproduto { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}
