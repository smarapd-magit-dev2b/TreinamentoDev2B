using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio2Abstrata
{
    public class Multiplicacao : Conta
    {
        public Multiplicacao(decimal valor1, decimal valor2) : base(valor1, valor2)
        {

        }
        public override decimal Calcular(decimal valor1, decimal valor2)
        {
            decimal resultadoMultiplicacao = valor1 * valor2;
            return resultadoMultiplicacao;
        }
    }
}
