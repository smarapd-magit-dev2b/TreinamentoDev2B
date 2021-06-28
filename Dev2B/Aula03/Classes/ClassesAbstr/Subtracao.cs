using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Classes.ClassesAbstr
{
    class Subtracao : Calculo
    {
        public Subtracao(int valor1, int valor2) : base(valor1, valor2)
        {

        }
        public override decimal Calcular()
        {
            return Valor1 - Valor2;
        }
    }
}
