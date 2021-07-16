using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_2Abs
{
    class Divisão : Mãe
    {

        public Divisão(decimal valor1, decimal valor2) : base(valor1, valor2)
        {


        }


        public override decimal Calculo(decimal valor1, decimal valor2)

        {
            if (valor2 != 0)
            {
                decimal divisão = valor1 * valor2;
                return divisão;

            }
            
            else

                return default;


        }





    }
}
