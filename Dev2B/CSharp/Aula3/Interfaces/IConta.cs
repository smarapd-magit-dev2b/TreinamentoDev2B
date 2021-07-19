namespace Aula3.Interfaces
{
    public interface IConta
    {
        string NumeroConta { get; set; }
        decimal MovimentacoesSaques { get; set; }
        decimal MovimentacoesDepositos { get; set; }
        string Agencia { get; set; }

        public string ImprimeExtrato();

        public abstract string Depositar(decimal valor);

        public abstract string Sacar(decimal valor);
    }
}
