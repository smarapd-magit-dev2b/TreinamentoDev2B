using System;
using System.Collections.Generic;
using System.Text;

namespace Aula8.OCP.ExemploRuim
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

        public void AplicarDesconto()
        {
            if (this.Nome == "Geladeira")
                this.Preco = this.Preco * .8m;
            if (this.Nome == "Fogao")
                this.Preco = this.Preco * .75m;
        }
    }
}
