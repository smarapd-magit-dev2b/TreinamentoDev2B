﻿using Aula3.Interfaces;

namespace Aula3.Classes
{
    public class MultiplicacaoInterface : IOperacao
    {
        public decimal Valor1 { get; set; }
        public decimal Valor2 { get; set; }

        public MultiplicacaoInterface(decimal valor1, decimal valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }

        public decimal Calcular() => Valor1 * Valor2;
    }
}
