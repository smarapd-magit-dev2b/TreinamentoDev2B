﻿namespace Domain.Operacao
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
