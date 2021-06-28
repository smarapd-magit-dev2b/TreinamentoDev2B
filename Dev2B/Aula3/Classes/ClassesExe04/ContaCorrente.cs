using Aula3.Interfaces.InterfacesExe04;
using System;

namespace Aula3.Classes.ClassesExe04 {
    public class ContaCorrente : ContaBancaria, IContaBancaria {
        public ContaCorrente(int numeroconta, int agencia)
            : base(numeroconta, agencia) {
        }

        public decimal Deposito(decimal deposito) {
            return Saldo += deposito;
        }

        public decimal AplicarTaxaServico() {
            return MovimentacoesSaques * (3.5m / 100m);      
        }

        public decimal Sacar() {
            return Saldo -= (MovimentacoesSaques + AplicarTaxaServico());
        }


        public void ImprimeExtrato(string nome) {
            Console.WriteLine($"Titular: {nome}\n" +
                              $"Número da conta: {NumeroConta} Agencia: {Agencia}\n" +
                              $"Deposito: R${MovimentacoesDepositos}  Saque: R${MovimentacoesSaques} + R${AplicarTaxaServico().ToString("F2")} de 3,5% Serviços Administrativo\n" +
                              $"Saldo: R${Saldo.ToString("F2")}");
        }

    }
}
