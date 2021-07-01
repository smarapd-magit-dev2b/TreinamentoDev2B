using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_2Int
{
    public class Soma : Mãe, IInt
    {
        public Soma(decimal valor1, decimal valor2) : base(valor1, valor2)
        {


        }


        public decimal Calculo(decimal valor1, decimal valor2)

        {

            decimal soma = valor1 + valor2;
           
            return soma;



        }
    }

}
