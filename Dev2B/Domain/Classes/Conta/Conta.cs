using System;

namespace Domain.Classes.Conta
{
    public abstract class Conta
    {
        public string NumeroConta { get; set; }
        protected decimal MovimentacoesSaques { get; set; }
        protected decimal MovimentacoesDepositos { get; set; }
        public string Agencia { get; set; }
        public Conta()
        {
            MovimentacoesDepositos = 0;
            MovimentacoesSaques = 0;
        }
        public void ImpreExtrato()
        {
            Console.WriteLine($"Extrato\n\n" +
                $"Agência:{Agencia}\n" +
                $"Conta: {NumeroConta}\n" +
                $"Depositos: {MovimentacoesDepositos}\n" +
                $"Saques: {MovimentacoesSaques}\n" +
                $"Saldo: {MovimentacoesDepositos - MovimentacoesSaques}\n");
        }
        public abstract void Depositar(decimal valor);
        public abstract void Sacar(decimal valor);
    }
}
