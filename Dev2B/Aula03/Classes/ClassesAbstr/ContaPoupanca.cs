using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Classes.ClassesAbstr
{
    public class ContaPoupanca: Conta
    {
        public ContaPoupanca(int numeroConta, string agencia)
           : base(numeroConta, agencia)
        {
        }

        public void AplicarRendimento(decimal valor)
        {
            Depositar(valor);
        }
    }
}
