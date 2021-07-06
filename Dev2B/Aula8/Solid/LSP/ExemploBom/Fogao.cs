using System;
using System.Collections.Generic;
using System.Text;

namespace Aula8.LSP.ExemploBom
{
    public class Fogao : Produto
    {
        public Fogao(string nomeProduto, decimal precoProduto) : base(nomeProduto, precoProduto)
        {
        }
        public override void AplicarDesconto()
        {
            this.Preco = this.Preco * .75m;
        }

        public override string ObterCaracteristica()
        {
            return "Fogao 4 bocas";
        }
    }
}
