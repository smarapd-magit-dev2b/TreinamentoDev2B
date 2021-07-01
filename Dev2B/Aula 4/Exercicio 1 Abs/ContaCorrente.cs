using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_1abs
{
    public class ContaCorrente : Conta
    {
        private object saque;

        public ContaCorrente(string numeroconta, decimal movisaques, decimal movideposito, string agencia, decimal saldo)
            : base(numeroconta, movisaques, movideposito, agencia, saldo)
        {


        }

        public override decimal Depositar(decimal deposito)
        {
            return Saldo = Saldo + deposito;
        }

        public decimal AplicarTaxaServ()
        {

            return Saldo * 5 / 100;


        }

        public override decimal Sacar(decimal saque)
        {
            return Saldo = Saldo - saque;
        }

        public override void ImprimeExtr()
        {
            Console.WriteLine($"Numero da conta:  { NumeroConta}");
            Console.WriteLine($" Agencia: {Agencia}");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine($"Deposito: {MoviDeposito}");
            Console.WriteLine($"Saque: {MoviSaques}");
        }

    }
}
