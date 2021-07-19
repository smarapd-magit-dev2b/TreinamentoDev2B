namespace Aula3.Classes
{
    public class ContaCorrenteAbstrata : Conta
    {
        public ContaCorrenteAbstrata(): base() { }

        public override string Depositar(decimal valor)
        {
            decimal valorTaxado = AplicarTaxaServico(valor);

            MovimentacoesDepositos += valorTaxado;

            return $"\nDepósito de R${valor} solicitado\n" +
                    "Taxa de 3% aplicada\n" +
                   $"Depósito de R${valorTaxado} efetuado\n";
        }
        public override string Sacar(decimal valor)
        {
            decimal valorTaxado = AplicarTaxaServico(valor);

            MovimentacoesSaques += valorTaxado;

            return $"\nSaque no valor de R${valor} solicitado\n" +
                    "Taxa de 3% aplicada\n" +
                   $"Saque de R${valorTaxado} efetuado\n";
        }
        private decimal AplicarTaxaServico(decimal valor) => valor * 0.97m;
    }
}
