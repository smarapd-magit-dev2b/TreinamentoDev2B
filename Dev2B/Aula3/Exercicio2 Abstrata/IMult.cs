using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio2_Abstrata
{
    class IMult : IContas
    {
        public int Valor1 { get; set; }
        public int Valor2 { get; set; }

        public int Calcular()
        {
            return Valor1 * Valor2;
        }
    }
}
