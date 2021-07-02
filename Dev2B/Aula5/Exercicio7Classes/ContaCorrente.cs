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

        public ContaCorrente(int numeroConta, decimal saldo, string contaEspecial, decimal limite)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
            ContaEspecial = contaEspecial;
            Limite = limite;
            Movimentacao = new List<Movimentacao>();
        }

        public bool Sacar(decimal valorSaque)
        {
            if ((Saldo - valorSaque) >= 0 && valorSaque <= Limite)
            {
                Saldo = Saldo - valorSaque;
                Movimentacao.Add(new Movimentacao("SAQUE", valorSaque, "DÉBITO"));
                Console.WriteLine($"Realizado saque de R${valorSaque}. ");
                return true;
            }
            if (valorSaque > Saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else if (valorSaque > Limite)
            {
                Console.WriteLine("Erro!!\nValor de saque acima do limite.");
            }
            return false;
        }

        public void Depositar(decimal valorDep)
        {
            Saldo += valorDep;
            Movimentacao.Add(new Movimentacao("DEPÓSITO", valorDep, "CRÉDITO"));
            Console.WriteLine($"Realizado depósito de R${valorDep}. ");
        }

        public void ExibirExtrato()
        {
            Console.WriteLine($"Numero da Conta: {NumeroConta}");
            Console.WriteLine($"Conta Especial: {ContaEspecial}");
            Console.WriteLine($"Limite: {Limite}");
            Console.WriteLine($"\nSaldo R$: {Saldo}");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"\n\nTransações Realizadas");
            foreach (var item in Movimentacao)
            {
                Console.WriteLine($"\nDescrição: {item.Descricao}");
                Console.WriteLine($"Valor: {item.Valor}");
                Console.WriteLine($"Tipo de movimentação: {item.TipoMovimentacao}");
            }
        }
        public bool DebitoSaldo(decimal valor)
        {
            if ((Saldo - valor) >=0 )
            {
                Saldo -= valor;
                return true;
            }
            return true;
        }

        public void ReceberTransferencia(decimal valor)
        {
            Movimentacao.Add(new Movimentacao("TRANSFERÊNCIA RECEBIDA", valor, "CRÉDITO"));
            Saldo += valor;
        }
        public void Transferencia(ContaCorrente contaDestino, decimal valor)
        {
            if (DebitoSaldo(valor))
            {
                Console.WriteLine($"Transferencia de R${valor} realizada");
                Movimentacao.Add(new Movimentacao("TRANSFERÊNCIA REALIZADA", valor, "DÉBITO"));
                contaDestino.ReceberTransferencia(valor);
            }
            else
                Console.WriteLine("Saldo insuficiente para realizar transferências");
        }
    }
}
