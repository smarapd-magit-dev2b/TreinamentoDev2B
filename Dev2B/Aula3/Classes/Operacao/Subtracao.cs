﻿using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3
{
    public class Subtracao : Operacao, IOperacao
    {
        public Subtracao(decimal valor1, decimal valor2):
            base(valor1, valor2)
        { }
        public decimal Calcular()
        {
            return Valor1 - Valor2;
        }
    }
}
