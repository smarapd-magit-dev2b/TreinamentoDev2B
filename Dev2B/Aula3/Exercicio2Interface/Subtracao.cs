using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio2Interface
{
    class Subtracao : Conta, IConta
    {
        public Subtracao(decimal valor1, decimal valor2) : base(valor1, valor2)
        {

        }
        public decimal Calcular(decimal valor1, decimal valor2)
        {
            decimal resultadoSubtracao = valor1 - valor2;
            return resultadoSubtracao;
        }
    }
}
