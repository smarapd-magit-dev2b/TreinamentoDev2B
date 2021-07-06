using System;
using System.Collections.Generic;
using System.Text;

namespace Aula8.LSP.ExemploBom
{
    public class Aplicacao
    {
        public string ObterCaracteristicaProduto(Produto produto)
        {
            return produto.ObterCaracteristica();
        }
    }
}
