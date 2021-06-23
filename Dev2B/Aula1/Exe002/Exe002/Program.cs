using System;
using System.Globalization;

namespace Exe002
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarações de variaveis
            decimal maior, menor, auxiliar = 0;
            int i = 1;
            
            //iniciando a variavel auxiliar
            Console.Write($"Digite o {i}° número: ");
            auxiliar = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            maior = auxiliar;
            menor = auxiliar;
            

            for (i = 2; i <= 10; i++)
            {
                Console.Write($"Digite o {i}° número: ");
                auxiliar = decimal.Parse(Console.ReadLine());

                if(auxiliar > maior)
                {
                    maior = auxiliar;
                }
                else if (auxiliar < menor)
                {
                    menor = auxiliar;
                }
            }
            Console.WriteLine($"Maior: {maior}" +
                               "Menor: " + menor);
            

        }
    }
}
