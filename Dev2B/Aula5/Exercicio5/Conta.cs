using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Exercicio5
{
    class Conta
    {
        public Conta(string numero, decimal saldo, bool isEspecial, decimal limite)
        {
            Numero = numero;
            Saldo = saldo;
            IsEspecial = isEspecial;
            Limite = limite;
        }

        public string Numero { get; set; }
        public decimal Saldo { get; set; }
        public bool IsEspecial { get; set; }
        public decimal Limite { get; set; }
        public List<Movimentacao> ListaMovimentacao { get; set; }

    }
}
