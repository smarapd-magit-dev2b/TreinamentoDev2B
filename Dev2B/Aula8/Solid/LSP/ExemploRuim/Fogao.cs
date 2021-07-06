using System;
using System.Collections.Generic;
using System.Text;

namespace Aula8.LSP.ExemploRuim
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

        public override string ObterCaracteristicaFogao()
        {
            return "Fogao 4 bocas";
        }
    }
}
