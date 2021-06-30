using System;
using System.Collections.Generic;
using Aula4.Exercicio5.Enum;

namespace Aula4.Exercicio5.Classes
{
    public class Conta
    {
        public Conta(int numeroConta)
        {
            NumeroConta = numeroConta;
            Movimentacoes = new List<Movimentacoes>();
            Saldo = 0;
            Console.WriteLine("Conta especial? [S/N]");
            ContaEspecial = Console.ReadLine().ToLower() == "s" ? true : false;
            Console.WriteLine("Qual o limite da conta? ");
            Limite = decimal.Parse(Console.ReadLine());
        }

        public int NumeroConta { get; set; }
        public decimal Saldo { get; private set; }
        public bool ContaEspecial { get; set; }
        public decimal Limite { get; set; }
        public List<Movimentacoes> Movimentacoes { get; set; }

        public bool Sacar(decimal valor)
        {
            if ((Saldo - valor) >= 0 && valor <= Limite)
            {
                Saldo -= valor;
                Movimentacoes.Add(new Movimentacoes(valor, EnumDescricao.SAQUE, EnumTipoMovimentacao.DEBITO));
                Console.WriteLine($"Saque realizado de R${valor} com sucesso!");
                return true;
            }

            if (valor > Saldo)
            {
                Console.WriteLine($"Voce nao possui saldo o suficiente!");
            }
            else if (valor > Limite)
            {
                Console.WriteLine($"O valor de saque nao pode sar maior que o limite");
            }


            return false;
        }

        public void Depositar(decimal valor)
        {
            Movimentacoes.Add(new Movimentacoes(valor, EnumDescricao.DEPOSITO, EnumTipoMovimentacao.CREDITO));
            Console.WriteLine("Deposito realizado com sucesso!");
            Saldo += valor;
        }

        public void Tranferir(Conta contaDestino, decimal valor)
        {
            if (Sacar(valor))
            {
                Console.WriteLine("Transferido com sucesso!");
                contaDestino.Depositar(Saldo);
                return;
            }

            Movimentacoes.Add(new Movimentacoes(valor, EnumDescricao.TRANFERENCIA, EnumTipoMovimentacao.CREDITO));
        }

        public void ImprimirExtrato()
        {
            Console.WriteLine("Status da conta");
            Console.WriteLine($"Limite de saque R${Limite}");
            Console.WriteLine("Tipo da conta: " + (ContaEspecial ? "ESPECIAL" : "NORMAL"));
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine("Transações: ");

            foreach (var item in Movimentacoes)
            {
                Console.WriteLine($" Tipo: {item.tipoMovimentacao.ToString()}");
                Console.WriteLine($" Descrição: {item.Descricao.ToString()}");
                Console.WriteLine($" Saldo: {item.Valor}");
                Console.WriteLine("=============================");
            }
        }
    }
}