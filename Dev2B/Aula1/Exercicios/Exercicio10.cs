using Domain.Classes.Pessoa.Fisica;
using Domain.Interfaces;
using System;

namespace Aula1.Exercicios
{
    public class Exercicio10 : IExecute
    {
        private int PessoasIdadeSuperior50 { get; set; }
        private int PessoasIdade10a20 { get; set; }
        private decimal MediaAlturaPessoas10a20anos { get; set; }
        private decimal MediaAlturasPessoas10a20anos { get; set; }
        private decimal PessoasPesoInferior40 { get; set; }

        public void Execute()
        {
            Console.WriteLine("Exercício 10\n");

            for (int i = 1; i <= 5; i++)
            {
                PessoaFisica pessoa = new PessoaFisica();

                Console.Write($"Digite a idade da {i}º pessoa: ");
                pessoa.Idade = int.Parse(Console.ReadLine());

                Console.Write($"Digite a altura da {i}º pessoa: ");
                pessoa.Altura = decimal.Parse(Console.ReadLine());

                Console.Write($"Digite o peso da {i}º pessoa: ");
                pessoa.Peso = decimal.Parse(Console.ReadLine());

                //Regras de negócio
                if (pessoa.Idade > 50)
                    PessoasIdadeSuperior50++;
                if (pessoa.Idade >= 10 && pessoa.Idade <= 20)
                {
                    PessoasIdade10a20++;
                    MediaAlturasPessoas10a20anos += pessoa.Altura;
                }
                if (pessoa.Peso < 40)
                    PessoasPesoInferior40++;
            }

            //Regras de negócio
            if (PessoasIdade10a20 != 0)
                MediaAlturaPessoas10a20anos = MediaAlturasPessoas10a20anos / PessoasIdade10a20;

            Console.WriteLine($"Há {PessoasIdadeSuperior50} pessoas com idade superior a 50 anos");
            Console.WriteLine($"A média das alturas das pessoas entre 10 e 20 anos é {MediaAlturaPessoas10a20anos}");
            Console.WriteLine($"A porcentagem das pessoas com peso inferior a 40 kilos é {20 * PessoasPesoInferior40}%");
        }
    }
}
