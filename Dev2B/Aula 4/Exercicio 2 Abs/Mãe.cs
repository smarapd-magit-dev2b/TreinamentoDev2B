using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_2Abs
{
    public abstract class Mãe
    {
      
        public decimal Valor1 { get; set; }

        public decimal Valor2 { get; set; }

        public Mãe(decimal valor1, decimal valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }

        public abstract decimal Calculo(decimal valor1, decimal valor2);







    }
}
