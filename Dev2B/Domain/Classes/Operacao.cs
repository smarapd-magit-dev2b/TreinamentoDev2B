using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public abstract class Operacao
    {
        public decimal Valor1 { get; set; }
        public decimal Valor2 { get; set; }
        public Operacao(decimal valor1, decimal valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }
    }
}
