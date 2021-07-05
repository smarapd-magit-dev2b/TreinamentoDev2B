using Aula4;
using Aula4.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula4
{
    public class Soma : Calculadora, ICalc
    {


        public void Matematica()
        {
            ValorTotal = Valor1 + Valor2;
            Console.WriteLine(ValorTotal);
        }
    }
}

