using Domain.Classes.Pessoa.Fisica;
using Domain.Interfaces;
using System;

namespace Aula1.Exercicios
{
    public class Exercicio10 : IExecute
    {
        public void Execute()
        {
            Console.WriteLine("Exercício 10\n");
            int pessoa50 = 0, dezA20 = 0;
            decimal media10a20 = 0, porcentagem40, alturas10a20 = 0, pesos40 = 0;
            for (int i = 1; i <= 5; i++)
            {
                PessoaFisica pessoa = new PessoaFisica();
                Console.Write("Digite a idade da " + i + "º pessoa: ");
                pessoa.Idade = int.Parse(Console.ReadLine());
                Console.Write("Digite a altura da " + i + "º pessoa: ");
                pessoa.Altura = decimal.Parse(Console.ReadLine());
                Console.Write("Digite o peso da " + i + "º pessoa: ");
                pessoa.Peso = decimal.Parse(Console.ReadLine());
                //Regras de negócio
                if (pessoa.Idade > 50)
                    pessoa50++;
                if (pessoa.Idade >= 10 && pessoa.Idade <= 20)
                {
                    dezA20++;
                    alturas10a20 += pessoa.Altura;
                }
                if (pessoa.Peso < 40)
                    pesos40++;
            }
            //Regras de negócio
            if (dezA20 != 0)
                media10a20 = alturas10a20 / dezA20;
            porcentagem40 = pesos40 / 5;
            Console.WriteLine($"Há {pessoa50} pessoas com idade superior a 50 anos");
            Console.WriteLine($"A média das alturas das pessoas entre 10 e 20 anos é {media10a20}");
            Console.WriteLine($"A porcentagem das pessoas com peso inferior a 40 kilos é {porcentagem40 * 100}%");
        }
    }
}
