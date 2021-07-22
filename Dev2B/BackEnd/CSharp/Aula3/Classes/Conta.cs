namespace Aula3.Classes
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

        public string ImprimeExtrato() =>
           "\nConta Poupança\n\nExtrato\n\n" +
            $"Agência:{Agencia}\n" +
            $"Conta: {NumeroConta}\n" +
            $"Depositos: R${MovimentacoesDepositos}\n" +
            $"Saques: R${MovimentacoesSaques}\n" +
            $"Saldo: R${MovimentacoesDepositos - MovimentacoesSaques}\n";

        public abstract string Depositar(decimal valor);

        public abstract string Sacar(decimal valor);
    }
}
