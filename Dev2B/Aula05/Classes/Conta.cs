using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05.Classes
{
    class Conta
    {
        public string Numero { get; set; }
        public decimal Saldo { get; set; }
        public bool Especial { get; set; }
        public decimal Limite { get; set; }
        public List<Movimentacao> ListaMovimentacao { get; set; }

        public Conta(string numero, decimal saldo, bool especial, decimal limite)
        {
            Numero = numero;
            Saldo = saldo;
            Especial = especial;
            Limite = limite;
        }
    }
}
