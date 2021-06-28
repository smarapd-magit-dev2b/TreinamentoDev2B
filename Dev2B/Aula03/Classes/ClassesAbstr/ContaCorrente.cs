using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Classes.ClassesAbstr
{
    class ContaCorrente:Conta
    {
        public ContaCorrente(int numeroConta, string agencia)
            : base(numeroConta, agencia)
        {
        }

        public void AplicarTaxaServico(decimal valor)
        {
            Sacar(valor);
        }
    }
}
