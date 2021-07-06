using System;
using System.Collections.Generic;
using System.Text;

namespace Aula8.LSP.ExemploRuim
{
    public class Geladeira : Produto
    {
        public Geladeira(string nomeProduto, decimal precoProduto) : base(nomeProduto, precoProduto)
        {
        }
        public override void AplicarDesconto()
        {
            this.Preco = this.Preco * .8m;
        }


        public override string ObterCaracteristicaGeladeira()
        {
            return "Geladeira Frost Free";
        }
    }
}
