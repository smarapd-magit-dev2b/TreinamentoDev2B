using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04.Interfaces
{
    class Subtracao: Calculo, ICalculo
    {
        public Subtracao(decimal valor1, decimal valor2): base(valor1, valor2) { }
    
        public decimal Calcular()
        {
            return Valor1 - Valor2;
        }
    }
}
