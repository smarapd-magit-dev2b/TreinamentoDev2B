using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio2Interface
{
    public class Soma : Conta, IConta
    {
        public Soma(decimal valor1, decimal valor2) : base(valor1, valor2)
        {

        }
        public decimal Calcular(decimal valor1, decimal valor2)
        {
            decimal resultadoSoma = valor1 + valor2;
            return resultadoSoma;
        }
    }
}
