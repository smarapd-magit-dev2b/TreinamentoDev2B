using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Multiplicacao : Operacao, IOperacao
    {
        public Multiplicacao(decimal valor1, decimal valor2):
            base(valor1, valor2)
        { }

        public decimal Calcular()
        {
            return Valor1 * Valor2;
        }
    }
}
