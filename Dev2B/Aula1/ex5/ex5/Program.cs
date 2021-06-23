using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            ex5DW();
        }

        static void ex5for()
        {
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                soma += i;
                Console.WriteLine(soma);
            }
            Console.ReadLine();
        }

        static void ex5while()
        {
            int soma = 0;
            int i = 1;

            while ( i <= 100){
                soma += i;
                i++;
                Console.WriteLine(soma);
            }
            Console.ReadLine();
        }

        static void ex5DW()
        {
            int soma = 0;
            int i = 1;

            do
            {
                soma += i;
                i++;
                Console.WriteLine(soma);
            } while (i <= 100);
            Console.ReadLine();
        }
    }
}
