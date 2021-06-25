using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio1Interface
{
    public abstract class Conta
    {
        public string NumeroConta { get; set; }
        public decimal MovimentacoesSaques { get; set; }
        public decimal MovimentacoesDeposito { get; set; }
        public string Agencia { get; set; }
        public decimal Saldo { get; set; }

        public Conta(string numeroConta, decimal movimentacoesSaques, decimal movimentacoesDeposito, string agencia, decimal saldo)
        {
            NumeroConta = numeroConta;
            MovimentacoesSaques = movimentacoesSaques;
            MovimentacoesDeposito = movimentacoesDeposito;
            Agencia = agencia;
            Saldo = saldo;
        }
    }
}
