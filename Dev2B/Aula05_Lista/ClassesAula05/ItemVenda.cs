using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05_Lista.ClassesAula05
{
    public class ItemVenda
    {
        public string Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

        public ItemVenda(string id, string descricao, int quantidade, decimal precoUnitario)
        {
            Id = id;
            Descricao = descricao;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }
    }
}