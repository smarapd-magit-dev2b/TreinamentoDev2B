using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio1_Abstrata
{
    class ContaPoupanca : Contas
    {
        public override int Depositar(int deposito)
        {
            return Depositos + deposito;
        }

        public override void ImprimeExtrato()
        {
            Console.WriteLine((Saques - Depositos));
        }

        public override int Sacar(int saque)
        {
            return Saques + saque;
        }
        public int AplicarRendimento(int rendimento)
        {
            return Depositos + rendimento;
        }
    }
}
