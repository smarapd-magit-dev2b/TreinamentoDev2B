using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio2_Abstrata
{
    abstract class Contas
    {
        public int Valor1 { get; set; }
        public int Valor2 { get; set; }

        public abstract int Calcular();
    }
}
