using System;
using System.Collections.Generic;
using System.Text;
using Aula3.Interfaces;

namespace Aula3.Classes
{
    public class NewSubtracao : ICalculo
    {
        public decimal V1 { get; set; }
        public decimal V2 { get; set; }

        public NewSubtracao(decimal valor1, decimal valor2)
        {
            V1 = valor1;
            V2 = valor2;
        }

        public decimal Calculo()
        {
            return V1 - V2;
        }
    }
}
