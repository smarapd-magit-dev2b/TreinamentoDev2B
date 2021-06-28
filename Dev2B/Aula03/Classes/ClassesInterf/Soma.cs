﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Classes.ClassesInterf
{
    class Soma : Calculo, ICalculo
    {
        public Soma(int valor1, int valor2) : base(valor1, valor2)
        {

        }
        public decimal Calcular()
        {
            return Valor1 + Valor2;
        }
    }
}

