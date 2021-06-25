using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Divisao : Operacao, IOperacao
    {
        public Divisao(decimal valor1, decimal valor2):
            base(valor1, valor2)
        { }
        public decimal Calcular()
        {
            return Valor1 / Valor2;
        }
    }
}
