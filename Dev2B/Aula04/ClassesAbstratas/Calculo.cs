using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04.ClassesAbstratas
{
    public abstract class Calculo
    {
        public decimal valor1 { get; set; }
        public decimal valor2 { get; set; }
        public abstract void Calcular();
    }
}
