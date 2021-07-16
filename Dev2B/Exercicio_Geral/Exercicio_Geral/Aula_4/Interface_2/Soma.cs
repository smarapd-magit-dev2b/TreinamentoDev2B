using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_4.Interface_2
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
