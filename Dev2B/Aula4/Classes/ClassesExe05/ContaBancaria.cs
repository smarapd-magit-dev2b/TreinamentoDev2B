using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4.Classes.ClassesExe05 {
    public class ContaBancaria {
        public int Numero { get; set; }
        public decimal Saldo { get; set; }
        public string Status { get; set; }
        public decimal Limite { get; set; }
        public List<Movimentacao> Movimentacoes { get; set; }

        public ContaBancaria() {
            Movimentacoes = new List<Movimentacao>();
        }
        public string ExtratoTostring() {
            return $"Número da conta: {Numero}\nSaldo: R${Saldo}\nStatus: {Status}\n";
        }
    }
    public class Movimentacao {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int CreditoDebito { get; set; }
    }

    public class Enum {

    }
}
