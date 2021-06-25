using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente():
            base()
        { }

        public override void Depositar(decimal valor)
        {
            Console.WriteLine("Taxa de 3% aplicada.");
            MovimentacoesDepositos += AplicarTaxaServico(valor);
        }
        public override void Sacar(decimal valor)
        {
            Console.WriteLine("Taxa de 3% aplicada.");
            MovimentacoesSaques += AplicarTaxaServico(valor);
        }
        private decimal AplicarTaxaServico(decimal valor)
        {
            return valor * 0.97m;
        }
    }
}
