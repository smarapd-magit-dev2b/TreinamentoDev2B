using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio1Interface
{
    public interface IBanco
    {
        void ImpreExtrato();
        decimal Depositar(decimal deposito);
        decimal Sacar(decimal saque);
    }
}
