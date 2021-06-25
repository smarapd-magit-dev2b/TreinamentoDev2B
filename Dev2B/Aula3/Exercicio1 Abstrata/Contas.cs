using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio1_Abstrata
{
    abstract class Contas
    {
        public string NmrConta { get; set; }
        public int Saques { get; set; }
        public int Depositos { get; set; }
        public string Agencia { get; set; }

        public abstract void ImprimeExtrato();
        public abstract int Depositar(int deposito);
        public abstract int Sacar(int saque);
    }
}
