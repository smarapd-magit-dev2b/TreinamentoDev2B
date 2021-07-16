using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_2Abs
{
    class Multiplicação  : Mãe
    {

        public Multiplicação(decimal valor1, decimal valor2) : base(valor1, valor2)
        {


        }


        public override decimal Calculo(decimal valor1, decimal valor2)

        {

            decimal multiplicação = valor1 * valor2;
            return multiplicação;


        }




    }
}
