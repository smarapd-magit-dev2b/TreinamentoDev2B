using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3
{
    public class Soma : Operacao, IOperacao
    {
        public Soma(decimal valor1, decimal valor2):
            base(valor1, valor2)
        {

        }
        public decimal Calcular()
        {
            return Valor1 + Valor2;
        }
    }
}
