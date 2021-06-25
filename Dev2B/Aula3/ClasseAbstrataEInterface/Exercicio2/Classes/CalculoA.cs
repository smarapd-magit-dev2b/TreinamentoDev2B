using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3.Exercicio2.Domain
{
    public abstract class CalculoA
    {
        public decimal Valor1 { get; set; }
        public decimal Valor2 { get; set; }

        protected CalculoA(decimal valor1, decimal valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }

        public abstract decimal Calcular();
    }
}
