using System;
using System.Collections.Generic;
using System.Text;
using Aula3.Classes;

namespace Aula3
{
    public class ClassesAbstrata
    {
        public void Execute()
        {
            ExClasseAbstrata1();
        }

        private void ExClasseAbstrata1()
        {
            Console.WriteLine("Informe o número da conta corrente: ");
            var numCC = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o movimento de saque: ");
            var movSaqCC = Console.ReadLine();

            Console.WriteLine("Informe o movimento de depósito: ");
            var movDepCC = Console.ReadLine();

            Console.WriteLine("Informe o número da agencia: ");
            var agCC = int.Parse(Console.ReadLine());

            ContaCorrente contaCorrente = new ContaCorrente(numCC, movSaqCC, movDepCC, agCC);

            Console.WriteLine("Extrato Conta Corrente");
            contaCorrente.ImpreExtrato();
            Console.WriteLine("Deposito");
            contaCorrente.Depositar();
            Console.WriteLine("Saque");
            contaCorrente.Sacar();
            Console.WriteLine("Taxa de Serviço");
            contaCorrente.AplicarTaxaServico();

            Console.ReadLine();
        }
    }
}
