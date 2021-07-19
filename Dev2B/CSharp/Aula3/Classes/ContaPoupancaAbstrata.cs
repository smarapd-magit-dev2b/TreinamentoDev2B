namespace Aula3.Classes
{
    public class ContaPoupancaAbstrata : Conta
    {
        public ContaPoupancaAbstrata() : base() { }

        public override string Depositar(decimal valor)
        {
            MovimentacoesDepositos += valor;

            return $"\nDepósito de R${valor} efetuado\n";
        }

        public override string Sacar(decimal valor)
        {
            decimal valorRendido = AplicarRendimento(valor);

            MovimentacoesSaques += valorRendido;

            return $"\nSaque de R${valor} solicitado\n" +
                    "Rendimento de 2% aplicado\n" +
                   $"Saque no valor de R${valorRendido} efetuado\n";
        }

        private decimal AplicarRendimento(decimal valor) => valor * 1.02m;
    }
}
