using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Classes.ClassesAbstr
{
    class Multiplicacao : Calculo
    {
        public Multiplicacao (int valor1, int valor2):base(valor1, valor2)
        {

        }
        public override decimal Calcular()
        {
            return Valor1 * Valor2;
        }
    }
}
