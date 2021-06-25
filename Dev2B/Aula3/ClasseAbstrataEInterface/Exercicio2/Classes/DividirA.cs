using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3.Exercicio2.Domain
{
    public class DividirA : CalculoA
    {
        public DividirA(decimal valor1, decimal valor2) : base(valor1, valor2)
        {
        }

        public override decimal Calcular()
        {
            return Valor1 / Valor2;
        }
    }
}
