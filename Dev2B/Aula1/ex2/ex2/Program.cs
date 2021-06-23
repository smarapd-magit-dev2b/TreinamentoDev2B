using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
	class Program
	{
		static void Main(string[] args)
		{
			int maior = 0;
			int menor = 0;
			int num = 0;

			for ( int i = 1; i <= 5; i++) {
				Console.WriteLine((i) + "º numero: ");
				num = int.Parse(Console.ReadLine());

				if (i == 1)
                {
					maior = num;
					menor = num;
                } else if (num > maior)
                {
					maior = num;
                } else if (num < menor)
                {
					menor = num;
                }
			}
			Console.WriteLine("O maior numero é " + maior);
			Console.WriteLine("O menor numero é " + menor);
			Console.ReadLine();

		}
	}
}
