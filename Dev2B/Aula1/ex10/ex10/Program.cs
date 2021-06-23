using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            decimal altura;
            decimal peso;

            decimal media_altura = 0;

            int idade50 = 0;
            int idade1020 = 0;
            decimal total_peso = 0;
            decimal abaixo = 0;
            int count = 0;
            int porcentagem = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Digite a idade da pessoa " + i);
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura da pessoa " + i);
                altura = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Digite a peso da pessoa " + i);
                peso = decimal.Parse(Console.ReadLine());

                if (idade >= 50)
                    idade50++;

                if(idade >= 10 && idade < 20)
                {
                    idade1020++;
                    media_altura += altura;
                    media_altura = media_altura / idade1020;
                }

                total_peso += peso;
                if (peso < 40)
                {
                    abaixo += peso;
                    count++;
                }

                porcentagem = (100 * count) / i;
            }
            Console.WriteLine("Pessoas com mais de 50 anos " + idade50);
            Console.ReadLine();
            Console.WriteLine("Media das alturas das pessoas com idade entre 10 e 20 anos " + media_altura);
            Console.ReadLine();
            Console.WriteLine("Porcentagem de pessoas com peso inferior a 40kg " + porcentagem);
            Console.ReadLine();
        }
    }
}
