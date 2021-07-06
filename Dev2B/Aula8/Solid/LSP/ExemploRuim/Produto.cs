using System;
using System.Collections.Generic;
using System.Text;

namespace Aula8.LSP.ExemploRuim
{
    public abstract class Produto
    {
        public string Nome { get; set; }
        public Decimal Preco { get; set; }
        private const decimal DESCONTO_PADRAO = .3M;
        public virtual void AplicarDesconto()
        {
            this.Preco = this.Preco * 0.5m;
        }
        public Produto(string nomeProduto, decimal precoProduto)
        {
            //if (nomeProduto == null)
            //    throw new ArgumentNullException();
            //else
            //    Nome = nomeProduto;

            this.Nome = nomeProduto == null ? throw new ArgumentNullException() : Nome = nomeProduto;
            this.Preco = precoProduto;
        }
    }
}
