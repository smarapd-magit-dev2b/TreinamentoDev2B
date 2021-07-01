using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04.Interfaces
{
    public class Calculo
    {
        public decimal Valor1 { get; set; }
        public decimal Valor2 { get; set; }
    
        public Calculo(decimal valor1, decimal valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }
    }
}
