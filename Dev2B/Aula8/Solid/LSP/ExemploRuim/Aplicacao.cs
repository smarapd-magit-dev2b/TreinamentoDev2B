using Aula8.LSP.ExemploBom;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula8.LSP.ExemploRuim
{
    public class Aplicacao
    {
        public string ObterCaracteristicaProduto(Produto produto)
        {
            if (produto is Geladeira)
                return ObterCaracteristicaGeladeira(produto as Geladeira);
            if (produto is Fogao)
                return ObterCaracteristicaFogao(produto as Fogao);
            return null;
        }

        private string ObterCaracteristicaFogao(Fogao fogao)
        {
            return fogao.ObterCaracteristicaFogao();
        }

        private string ObterCaracteristicaGeladeira(Geladeira geladeira)
        {
            return geladeira.ObterCaracteristicaGeladeira();
        }
    }
}
