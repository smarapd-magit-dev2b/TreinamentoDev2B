using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_4.Abstract_1
{
    public abstract class Conta
    {
        public string NumeroConta { get; set; }

        public decimal MoviSaques { get; set; }

        public decimal MoviDeposito { get; set; }

        public string Agencia { get; set; }

        public decimal Saldo { get; set; }

        public Conta(string numeroconta, decimal movisaques, decimal movideposito, string agencia, decimal saldo)
        {
            NumeroConta = numeroconta;
            MoviSaques = movisaques;
            MoviDeposito = movideposito;
            Agencia = agencia;
            Saldo = saldo;

        }

        public abstract void ImprimeExtr();

        public abstract decimal Depositar(decimal deposito);

        public abstract decimal Sacar(decimal saque);



    }
}
