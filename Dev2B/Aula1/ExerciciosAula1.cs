using System;
using System.Collections.Generic;
using System.Text;

namespace Aula1
{
     public class ExerciciosAula1
    {
        private void Exercicio1()
        {
            Console.WriteLine("Digite a nota do aluno: ");
            decimal nota = Convert.ToDecimal(Console.ReadLine());
            if (nota <= 10 && nota >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else if (nota < 7 && nota >= 4)
            {
                Console.WriteLine("Exame");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }

        public void Execute()
        {
            Exercicio1();
            Exercicio2();
            Exercicio3();
            Exercicio4_1();
            Exercicio4_2();
            Exercicio5_1();
            Exercicio5_2();
            Exercicio5_3();
            Exercicio10();
        }

        private void Exercicio2()
        {
            List<int> list = new List<int>();
            int maior = 0;
            int menor = 0;
            int aux = 0;
            for (int i = 0; i < 10; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            for (int i = 0; i < 9; i++)
            {
                aux = list[0];
                if (list[i] < list[i + 1])
                {
                    aux = list[i + 1];
                }
            }
            maior = aux;
            aux = 0;
            for (int i = 0; i < 9; i++)
            {
                aux = list[0];
                if (list[i] > list[i + 1])
                {
                    aux = list[i + 1];
                }
            }
            menor = aux;
            Console.WriteLine(maior);
            Console.WriteLine(menor);
        }

        private void Exercicio3()
        {
            int valor1 = Convert.ToInt32(Console.ReadLine());
            int valor2 = Convert.ToInt32(Console.ReadLine());
            int resultado;
            Math.DivRem(valor1, valor2, out resultado);
            if (resultado == 0)
            {
                Console.WriteLine("É Multiplo");
            }
            else
            {
                Console.WriteLine("Não é multiplo");
            }
        }

        private void Exercicio4_1()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            string simbolo = Console.ReadLine();
            int resultado;
            switch (simbolo)
            {
                case "+":
                    resultado = numero1 + numero2;
                    Console.WriteLine(resultado);
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    Console.WriteLine(resultado);
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    Console.WriteLine(resultado);
                    break;
                case "/":
                    resultado = numero1 / numero2;
                    Console.WriteLine(resultado);
                    break;
            }
            
        }

        private void Exercicio4_2()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine()); string simbolo = Console.ReadLine();
            int resultado;
            if (simbolo == "+")
            {
                resultado = numero1 + numero2;
                Console.WriteLine(resultado);
            }
            else if (simbolo == "-")
            {
                resultado = numero1 - numero2;
                Console.WriteLine(resultado);
            }
            else if (simbolo == "*")
            {
                resultado = numero1 * numero2;
                Console.WriteLine(resultado);
            }
            else if (simbolo == "/")
            {
                resultado = numero1 / numero2;
                Console.WriteLine(resultado);
            }
        }

        private void Exercicio5_1()
        {
            int total = 0;
            int i = 0;
            while (i <= 100)
            {
                total = total + i;
                i++;
            }
            Console.WriteLine(total);
        }

        private void Exercicio5_2()
        {
            int total = 0;
            for (int i = 0; i <= 100; i++)
            {
                total = total + i;
            }
            Console.WriteLine(total);
        }

        private void Exercicio5_3()
        {
            int total = 0;
            int i = 0;
            do
            {
                total = total + i;
                i++;
            } while (i <= 100);
        }

        private void Exercicio10()
        {
            int quantidadePessoasSuperior50 = 0, quantidadePessoasEntre1020 = 0, quantidadePessoasPesoInferior40 = 0;
            decimal somaAlturas = 0m, mediaAlturas = 0m, porcetagemPessoas = 0m;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe a idade:");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o peso:");
                decimal peso = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Informe a altura:");
                decimal altura = decimal.Parse(Console.ReadLine());

                if (idade > 50)
                    quantidadePessoasSuperior50++;

                if (idade >= 10 && idade <= 20)
                {
                    somaAlturas = somaAlturas + altura;
                    quantidadePessoasEntre1020++;
                }

                if (peso < 40)
                    quantidadePessoasPesoInferior40++;
            }

            mediaAlturas = (quantidadePessoasEntre1020 == 0) ? 0 : somaAlturas / quantidadePessoasEntre1020;
            porcetagemPessoas = (quantidadePessoasPesoInferior40 * 100) / 5;

            Console.WriteLine("Quantidade de pessoas acima de 50 anos:" + quantidadePessoasSuperior50);
            Console.WriteLine("Media altura das pessoas entre 10 e 20 anos:" + mediaAlturas);
            Console.WriteLine("Porcentagem de pessoas com peso inferior a 40kg:" + porcetagemPessoas + "%");

            Console.ReadLine();
        }
    }
}
