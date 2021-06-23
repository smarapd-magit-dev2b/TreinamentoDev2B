using System;

namespace Exe003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o 1° número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2° número: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0 && n2 % 2 == 0)
            {
                Console.WriteLine("Os números são múltiplos");
            }
            else
            {
                Console.WriteLine("Os números não são múltiplos");
            }
        }
    }
}
