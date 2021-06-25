using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio2Abstrata
{
    public class Soma : Conta
    {
        public Soma(decimal valor1, decimal valor2) : base(valor1, valor2)
        {

        }
        public override decimal Calcular(decimal valor1, decimal valor2)
        {
            decimal resultadoSoma = valor1 + valor2;
            return resultadoSoma;
        }
    }
}
