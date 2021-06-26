using System;

namespace Domain.Classes.Conta
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca() :
            base()
        { }
        public override void Depositar(decimal valor)
        {
            MovimentacoesDepositos += valor;
        }
        public override void Sacar(decimal valor)
        {
            Console.WriteLine("Rendimento de 2% aplicado");
            MovimentacoesSaques += AplicarRendimento(valor);
        }
        private decimal AplicarRendimento(decimal valor)
        {
            return valor * 1.02m;
        }
    }
}
