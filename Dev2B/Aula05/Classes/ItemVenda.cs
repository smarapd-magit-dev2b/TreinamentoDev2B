using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05.Classes
{
    public class ItemVenda
    {
        
        public string ID { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

        public ItemVenda(string id, string descricao, int quantidade, decimal precoUnitario)
        {
            ID = id;
            Descricao = descricao;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }
    }
}
