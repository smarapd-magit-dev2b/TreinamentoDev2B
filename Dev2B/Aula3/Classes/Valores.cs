using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Classes
{
    public abstract class Valores
    {
        public decimal V1 { get; set; }
        public decimal V2 { get; set; }

        public Valores(decimal valor1, decimal valor2)
        {
            V1 = valor1;
            V2 = valor2;
        }
        public abstract decimal Calcular();
    }
}
