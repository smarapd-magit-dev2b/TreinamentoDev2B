using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Classes
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int numeroConta, string movSaque, string movDeposito, int agencia) 
            : base(numeroConta, movSaque, movDeposito, agencia)
        {

        }

        public override void ImpreExtrato()
        {
            Console.WriteLine(MovimentacoesDepositos);
            Console.WriteLine(MovimentacoesSaques);
        }

        public override string Depositar()
        {
             return MovimentacoesDepositos;
        }

        public override string Sacar()
        {
            return MovimentacoesSaques;
        }

        public int AplicarTaxaServico()
        {
            var valorFinal = Convert.ToInt32(MovimentacoesSaques) * (Convert.ToInt32(MovimentacoesSaques) / 3);
            return valorFinal;
        }

    }
}
