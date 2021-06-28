using System;

namespace Aula3.Classes.ClassesExe04 {
    public abstract class ContaBancaria {
        public int NumeroConta { get; set; }
        public decimal MovimentacoesSaques { get; set; }
        public decimal MovimentacoesDepositos { get; set; }
        public int Agencia { get; set; }
        public decimal Saldo = 0;

        public ContaBancaria(int numeroconta, int agencia) {
            NumeroConta = numeroconta;
            Agencia = agencia;
        }
    }
}
