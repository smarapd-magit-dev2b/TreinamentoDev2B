using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Classes.ClassesInterf
{
    public class Calculo
    {
        public int Valor1 { get; set; }
        public int Valor2 { get; set; }

        public Calculo(int valor1, int valor2)
        {
            Valor1 = valor1;
            Valor2 = valor2;
        }
    }
}
