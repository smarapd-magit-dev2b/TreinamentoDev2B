using Aula3.Interfaces;

namespace Aula3.Classes
{
    public class ContaCorrenteInterface : IConta
    {
        public string NumeroConta { get; set; }
        public decimal MovimentacoesSaques { get; set; }
        public decimal MovimentacoesDepositos { get; set; }
        public string Agencia { get; set; }

        public string Depositar(decimal valor)
        {
            decimal valorTaxado = AplicarTaxaServico(valor);

            MovimentacoesDepositos += valorTaxado;

            return $"\nDepósito de R${valor} solicitado\n" +
                    "Taxa de 3% aplicada\n" +
                   $"Depósito de R${valorTaxado} efetuado\n";
        }

        public string ImprimeExtrato() =>
           "\nConta Poupança\n\nExtrato\n\n" +
            $"Agência:{Agencia}\n" +
            $"Conta: {NumeroConta}\n" +
            $"Depositos: R${MovimentacoesDepositos}\n" +
            $"Saques: R${MovimentacoesSaques}\n" +
            $"Saldo: R${MovimentacoesDepositos - MovimentacoesSaques}\n";

        public string Sacar(decimal valor)
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
