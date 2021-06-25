using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Classes
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(int numeroConta, string movSaque, string movDeposito, int agencia)
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
        public int AplicarRendimento()
        {
            var valorFinal = Convert.ToInt32(MovimentacoesDepositos) * (Convert.ToInt32(MovimentacoesDepositos) / 3);
            return valorFinal;
        }
    }
}
