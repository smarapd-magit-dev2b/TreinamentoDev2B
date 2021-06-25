using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio2Interface
{
    public class Divisao : Conta, IConta
    {
        public Divisao(decimal valor1, decimal valor2) : base(valor1, valor2)
        {

        }
        public decimal Calcular(decimal valor1, decimal valor2)
        {
            if (valor2 != 0)
            {
                decimal resultadoDivisao = valor1 / valor2;
                return resultadoDivisao;
            }
            else
            {
                return default;
            }

        }
    }
}
