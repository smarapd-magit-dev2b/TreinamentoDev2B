using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_4.Interface_2
{
    class Multiplicação : Mãe
    {

        public Multiplicação(decimal valor1, decimal valor2) : base(valor1, valor2)
        {


        }
        public decimal Calculo(decimal valor1, decimal valor2)

        {

            decimal multiplicação = valor1 * valor2;
            return multiplicação;


        }
    }
}
