using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio1Interface
{
    public class ContaCorrente : Conta, IBanco
    {
        public ContaCorrente(string numeroConta, decimal movimentacoesSaques, decimal movimentacoesDeposito, string agencia, decimal saldo)
            : base(numeroConta, movimentacoesSaques, movimentacoesDeposito, agencia, saldo)
        {

        }

        public decimal Depositar(decimal deposito)
        {
            Saldo += deposito;
            return Saldo;
        }
        public decimal Sacar(decimal saque)
        {
            Saldo -= saque;
            return Saldo;
        }

        public decimal AplicarTaxaServico()
        {
            return (Saldo * (1.5m / 100));
        }

        public void ImpreExtrato()
        {
            decimal saldoInicial = Saldo;
            decimal saldoDeposito = Depositar(MovimentacoesDeposito);
            decimal saldoSaque = Sacar(MovimentacoesSaques);
            decimal taxaServico = AplicarTaxaServico();
            decimal saldoTaxado = Saldo - taxaServico;
            Console.WriteLine("----- Conta Corrente -----");
            Console.WriteLine($"Número da conta: {NumeroConta}");
            Console.WriteLine($"Agência: {Agencia}");
            Console.WriteLine($"Saldo inicial: {saldoInicial}");
            Console.WriteLine($"Quantia depositada: {MovimentacoesDeposito}");
            Console.WriteLine($"Saldo atual: {saldoDeposito}");
            Console.WriteLine($"Quantia sacada: {MovimentacoesSaques}");
            Console.WriteLine($"Saldo atual: {saldoSaque}");
            Console.WriteLine($"Taxa de serviço (1,5%): {taxaServico}");
            Console.WriteLine($"Saldo com taxa de serviço: {saldoTaxado}");
            Console.WriteLine();
        }

    }
}
