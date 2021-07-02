using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Exercicio7Classes
{
    public class ContaCorrente
    {
        public int NumeroConta { get; set; }
        public decimal Saldo { get; set; }
        public string ContaEspecial { get; set; }
        public decimal Limite { get; set; }
        public List<Movimentacao> Movimentacao;

        public ContaCorrente(int numConta, decimal saldo, string contaEspecial, decimal limite)
        {
            NumeroConta = numConta;
            Saldo = saldo;
            ContaEspecial = contaEspecial;
            Limite = limite;
            Movimentacao = new List<Movimentacao>();
        }

        public string CriacaoConta()
        {
            Console.WriteLine("\nCadastro de contas");
            Console.WriteLine("Informe o numero da conta: ");
            var numConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o saldo da conta: ");
            var saldo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe se a conta é especial:");
            var contaEspecial = (Console.ReadLine());
            Console.WriteLine("Informe o limite da conta:");
            var limite = decimal.Parse(Console.ReadLine());

            var conta = new ContaCorrente(numConta, saldo, contaEspecial, limite);
            //listaContaCorrente.Add(conta);
            return ("Conta adicionada com sucesso");
        }
    }
}
