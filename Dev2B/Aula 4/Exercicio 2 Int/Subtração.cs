using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_2Int
{
    class Subtração : Mãe
    {

        public Subtração(decimal valor1, decimal valor2) : base(valor1, valor2)
        {


        }


        public decimal Calculo(decimal valor1, decimal valor2)

        {

            decimal subtraçao = valor1 - valor2;
            return subtraçao;


        }


    }
}
