using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Classes.ClassesAbstr
{
    public abstract class Conta
    {
        public int NumeroConta { get; set; }
        public decimal MovimentacoesSaques { get; private set; }
        public decimal MovimentacoesDepositos { get; private set; }
        public string Agencia { get; set; }

        public Conta(int numeroConta, string agencia)
        {
            NumeroConta = numeroConta;
            MovimentacoesSaques = 0;
            MovimentacoesDepositos = 0;
            Agencia = agencia;
        }

        public void ImpreExtrato()
        {
            Console.WriteLine("EXTRATO");
            Console.WriteLine($"Numero da conta: {NumeroConta}");
            Console.WriteLine($"Agencia: {Agencia}");
            Console.WriteLine($"Valor saques: {MovimentacoesSaques}");
            Console.WriteLine($"Valor depósitos: {MovimentacoesDepositos}");
        }
        public void Depositar(decimal valor)
        {
            MovimentacoesDepositos += valor;
        }

        public void Sacar(decimal valor)
        {
            MovimentacoesSaques -= valor;
        }
    }
}
