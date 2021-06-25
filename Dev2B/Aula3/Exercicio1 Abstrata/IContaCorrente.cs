using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio1_Abstrata
{
    class IContaCorrente : IContas
    {
        public string NmrConta { get; set; }
        public int Saques { get; set; }
        public int Depositos { get; set; }
        public string Agencia { get; set; }

        public int Depositar(int deposito)
        {
            return Depositos + deposito;
        }

        public void ImprimeExtrato()
        {
            Console.WriteLine((Saques - Depositos));
        }

        public int Sacar(int saque)
        {
            return Saques + saque;
        }
        public int AplicarTaxaServico(int taxa)
        {
            return Saques + taxa;
        }
    }
}
