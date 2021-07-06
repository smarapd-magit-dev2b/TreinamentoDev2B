using System;
using System.Collections.Generic;
using System.Text;

namespace Aula8.SRP.ExemploRuim
{
    public class Produto
    {
        public string Nome { get; set; }
        public Decimal Preco { get; set; }
        public Produto(string nomeProduto, decimal precoProduto)
        {
            this.Nome = nomeProduto ?? throw new ArgumentNullException();
            this.Preco = precoProduto;
        }
    }
}
