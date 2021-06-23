using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Digite sua media: ");
			int media = Convert.ToInt32(Console.ReadLine());

			if (media >= 7 && media <= 10)
			{
				Console.Write("Aprovado");
				Console.ReadLine();
			}
			else {
				if (media >= 4 && media <= 6.99)
				{
					Console.Write("Exame");
					Console.ReadLine();
				}
				else
				{
					Console.Write("Reprovado");
					Console.ReadLine();
				}
			}
		}
	}
}
