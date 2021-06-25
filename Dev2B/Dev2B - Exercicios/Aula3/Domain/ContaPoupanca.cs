using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ContaPoupanca : Banco
    {

        public decimal Saldo { get; set; }

        public ContaPoupanca(decimal saldo)
        {
            Saldo = saldo;
        }

        public override void AplicarRendimento()
        {
            decimal novoSaldo = (Saldo * 115) / 100;
            Saldo = novoSaldo;
            Console.WriteLine($"Novo Saldo Poupanca: {Saldo}.\n");
        }

        public override void ImpreExtrato()
        {
            Console.WriteLine("Extrato Bancario");
            Console.WriteLine("----------------");
            Console.WriteLine($"Saldo disponivel: {Saldo}");
        }

        public override decimal Movimentar()
        {
            Console.WriteLine("Informe o valor que deseja depositar: ");
            MovDeposito = Convert.ToDecimal(Console.ReadLine());
            return Saldo += MovDeposito;
        }

        public override decimal Sacar()
        {
            Console.WriteLine("Informe o valor que deseja sacar: ");
            MovSaque = Convert.ToDecimal(Console.ReadLine());
            return Saldo -= MovSaque;
        }
    }
}
