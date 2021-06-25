using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Classes
{
    public class Subtracao : Valores
    {
        public Subtracao(decimal valor1, decimal valor2) : base(valor1, valor2)
        {

        }

        public override decimal Calcular()
        {
            return V1 - V2;
        }
    }
}
