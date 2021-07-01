using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04.ClassesAbstratas
{
    class Subtracao: Calculo
    {
        public override void Calcular()
        {
            decimal resultado = 0.0m;

            Console.WriteLine("Informe o Primeiro Número: ");
            valor1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Segundo Número: ");
            valor2 = decimal.Parse(Console.ReadLine());

            resultado = valor1 - valor2;

            Console.WriteLine("Resultado = " + resultado);
        }
    }
}
