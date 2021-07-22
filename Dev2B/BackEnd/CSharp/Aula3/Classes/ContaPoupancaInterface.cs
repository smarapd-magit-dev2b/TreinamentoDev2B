using Aula3.Interfaces;

namespace Aula3.Classes
{
    public class ContaPoupancaInterface : IConta
    {
        public string NumeroConta { get; set; }
        public decimal MovimentacoesSaques { get; set; }
        public decimal MovimentacoesDepositos { get; set; }
        public string Agencia { get; set; }

        public string Depositar(decimal valor)
        {
            MovimentacoesDepositos += valor;

            return $"\nDepósito de R${valor} efetuado\n";
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
            MovimentacoesSaques += AplicarRendimento(valor);

            return $"\nSaque de R${valor} solicitado\n" + 
                    "Rendimento de 2% aplicado\n" +
                   $"Saque no valor de R${valor} efetuado\n";
        }

        private decimal AplicarRendimento(decimal valor) => valor * 1.02m;
    }
}
