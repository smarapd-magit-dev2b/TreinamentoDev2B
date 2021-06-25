using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio1_Abstrata
{
    interface IContas
    {

        public void ImprimeExtrato();
        public int Depositar(int deposito);
        public int Sacar(int saque);
    }
}
