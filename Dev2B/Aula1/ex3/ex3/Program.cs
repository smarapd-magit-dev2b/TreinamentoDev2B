using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Digite um numero: ");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite outro numero: ");
			int num2 = Convert.ToInt32(Console.ReadLine());


		if (num1 % num2 == 0)
			{
				Console.Write("Os numeros sao multiplos");
				Console.ReadLine();
			}
		else
			{
				Console.Write("Os numeros não são multiplos");
				Console.ReadLine();
			}
		}
			
	}
}
