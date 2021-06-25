using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Classes
{
    public abstract class Conta
    {
        public int NumeroConta { get; set; }
        public string MovimentacoesSaques { get; set; }
        public string MovimentacoesDepositos { get; set; }
        public int Agencia { get; set; }

        public Conta(int numeroConta, string movSaque, string movDeposito, int agencia)
        {
            NumeroConta = numeroConta;
            MovimentacoesSaques = movSaque;
            MovimentacoesDepositos = movDeposito;
            Agencia = agencia;
        }

        public abstract void ImpreExtrato();
        public abstract string Depositar();
        public abstract string Sacar();

    }
}
