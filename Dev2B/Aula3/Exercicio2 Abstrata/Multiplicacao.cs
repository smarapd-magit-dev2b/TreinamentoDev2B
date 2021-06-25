using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio2_Abstrata
{
    class Multiplicacao : Contas
    {
        public override int Calcular()
        {
            return Valor1 * Valor2;
        }
    }
}
