using System;

namespace Aula3.Exercicio4.Classes
{
    public class ContaCorrente : Conta
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
