﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Multiplicacao : Calculadora
    {
       

        public override void Calcular()
        {
            ValorTotal = Valor1 * Valor2;
            Console.WriteLine(ValorTotal);
        }
    }
}
