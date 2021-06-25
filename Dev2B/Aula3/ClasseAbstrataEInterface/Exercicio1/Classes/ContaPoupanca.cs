using System;

namespace Aula3.Exercicio4.Classes
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(int numeroConta, string agencia)
            : base(numeroConta, agencia)
        {
        }

        public void AplicarRendimento(decimal valor)
        {
            Saldo += valor;
        }

    }
}
