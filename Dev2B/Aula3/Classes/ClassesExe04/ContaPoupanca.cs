using Aula3.Interfaces.InterfacesExe04;
using System;

namespace Aula3.Classes.ClassesExe04 {
    public class ContaPoupanca : ContaBancaria, IContaBancaria {
        public ContaPoupanca(int numeroconta, int agencia)
            : base(numeroconta, agencia) {
        }

        public decimal Deposito(decimal deposito) {
            return Saldo += deposito;
        }

        public decimal Sacar() {
            return Saldo -= MovimentacoesSaques;
        }

        public decimal AplicarRendimentos(int tempo, decimal aportesmensais) {
            for (int i = 1; i <= tempo; i++) {
                Saldo += aportesmensais;
                Saldo += (Saldo * (1.0m / 100m));
            }
            return Saldo;
        }

        public void ImprimeExtrato(string nome) {
            Console.WriteLine($"Titular: {nome}\n" +
                              $"Número da conta: {NumeroConta} Agencia: {Agencia}\n" +
                              $"Deposito: R${MovimentacoesDepositos}  + Rendimento de 1% a.m + Aportes Mensais\n" +
                              $"Projeção do saldo no final do periodo de rendimento: R${Saldo.ToString("F2")}");
        }
    }
}
