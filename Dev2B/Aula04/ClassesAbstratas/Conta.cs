using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04.ClassesAbstratas
{
    public abstract class Conta
    {
        public string NumeroConta { get; set; }
        public decimal MovimentacoesSaques { get; set; }
        public decimal MovimentacoesDepositos { get; set; }
        public string Agencia { get; set; }

        public abstract void ImpreExtrato();
        public abstract void Depositar();
        public abstract void Sacar();
        public abstract void AplicarTaxaServico();
        public abstract void AplicarRendimento();
    }
}
