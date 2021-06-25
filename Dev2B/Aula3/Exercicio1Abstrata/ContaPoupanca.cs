using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio1Abstrata
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(string numeroConta, decimal movimentacoesSaques, decimal movimentacoesDeposito, string agencia, decimal saldo)
           : base(numeroConta, movimentacoesSaques, movimentacoesDeposito, agencia, saldo)
        {

        }

        public override decimal Depositar(decimal deposito)
        {
            Saldo += deposito;
            return Saldo;
        }
        public override decimal Sacar(decimal saque)
        {
            Saldo -= saque;
            return Saldo;
        }

        public decimal AplicarRendimento()
        {
            return (Saldo * (2.5m / 100));
        }

        public override void ImpreExtrato()
        {
            decimal saldoInicial = Saldo;
            decimal saldoDeposito = Depositar(MovimentacoesDeposito);
            decimal saldoSaque = Sacar(MovimentacoesSaques);
            decimal rendimento = AplicarRendimento();
            decimal saldoRendimento = Saldo + rendimento;
            Console.WriteLine("----- Conta Corrente -----");
            Console.WriteLine($"Número da conta: {NumeroConta}");
            Console.WriteLine($"Agência: {Agencia}");
            Console.WriteLine($"Saldo inicial: {saldoInicial}");
            Console.WriteLine($"Quantia depositada: {MovimentacoesDeposito}");
            Console.WriteLine($"Saldo atual: {saldoDeposito}");
            Console.WriteLine($"Quantia sacada: {MovimentacoesSaques}");
            Console.WriteLine($"Saldo atual: {saldoSaque}");
            Console.WriteLine($"Rendimento (2,5%): {rendimento}");
            Console.WriteLine($"Saldo com rendimento: {saldoRendimento}");
        }
    }
}
