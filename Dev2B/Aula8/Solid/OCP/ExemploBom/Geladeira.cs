using System;
using System.Collections.Generic;
using System.Text;

namespace Aula8.OCP.ExemploBom
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
    }

}
