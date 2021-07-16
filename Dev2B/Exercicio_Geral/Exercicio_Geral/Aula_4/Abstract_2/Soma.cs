using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_4.Abstract_2
{
    public class Soma : Mãe
    {
        public Soma(decimal valor1, decimal valor2) : base(valor1, valor2)
        {


        }


        public override decimal Calculo(decimal valor1, decimal valor2)

        {
            decimal soma = valor1 + valor2;
            return soma;

        }

    }
}
