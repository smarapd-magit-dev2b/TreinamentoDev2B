using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio2Interface
{
    public abstract class Conta
    {
        public decimal Valor1 { get; set; }
        public decimal Valor2 { get; set; }

        public Conta(decimal valor1, decimal valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }
    }
}
