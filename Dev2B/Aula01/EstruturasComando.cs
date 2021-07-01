using System;

namespace Aula01
{
    public class EstruturasComando
    {
        public void Execute()
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio4_1();
            //Exercicio4_2();
            //Exercicio5_1();
            //Exercicio5_2();
            //Exercicio5_3();
            //Exercicio10();
        }

        private void Exercicio1()
        {
            Console.WriteLine("Digite a nota: ");
            var nota = decimal.Parse(Console.ReadLine());

            if(nota <= 3.99m)
            {
                Console.WriteLine("Reprovado");
            }
            else
            {
                if(nota <= 6.99m)
                {
                    Console.WriteLine("Exame");
                }
                else
                {
                    if(nota <= 10)
                    {
                        Console.WriteLine("Aprovado");
                    }
                    else
                    {
                        Console.WriteLine("Valor digitado inválido:" + nota);
                    }
                }
            }
            Console.ReadLine();
        }

        private void Exercicio2()
        {
            Console.WriteLine("Digite 10 números:");

            decimal maior = 0.0m;
            decimal menor = 0.0m;

            for(int i = 0; i <10; i++)
            {
                var numero = decimal.Parse(Console.ReadLine());

                if(i == 0)
                {
                    maior = numero;
                    menor = numero;
                }
                if(numero > maior)
                {
                    maior = numero;
                }
                if(numero < menor)
                {
                    menor = numero;
                }
            }

            Console.WriteLine("O Maior número: " + maior);
            Console.WriteLine("O Menor número: " + menor);

            Console.ReadLine();
        }

        private void Exercicio3()
        {
            Console.WriteLine("Digite o primeiro número: ");
            var primeiroNumero = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            var segundoNumero = decimal.Parse(Console.ReadLine());

            if(primeiroNumero % segundoNumero == 0)
            {
                Console.WriteLine("Os números são múltiplos");
            }
            else
            {
                Console.WriteLine("Os números não são múltiplos");
            }
            Console.ReadLine();
        }

        private void Exercicio4_1()
        {
            Console.WriteLine("Digite o primeiro número: ");
            var primeiroNumero = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            var segundoNumero = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação:");
            var operacao = Console.ReadLine();

            switch (operacao)
            {
                case "+":
                    Console.WriteLine(primeiroNumero + segundoNumero);
                    break;
                case "-":
                    Console.WriteLine(primeiroNumero - segundoNumero);
                    break;
                case "/":
                    Console.WriteLine(primeiroNumero / segundoNumero);
                    break;
                case "*":
                    Console.WriteLine(primeiroNumero * segundoNumero);
                    break;
                default:
                    Console.WriteLine("Operação inválida!" + operacao);
                    break;
            }
            Console.ReadLine();
        }

        private void Exercicio4_2()
        {
            Console.WriteLine("Digite o primeiro número: ");
            var primeiroNumero = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            var segundoNumero = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação: ");
            var operacao = Console.ReadLine();

            if(operacao == "+")
            {
                Console.WriteLine(primeiroNumero + segundoNumero);
            }
            else
            {
                if(operacao == "-")
                {
                    Console.WriteLine(primeiroNumero - segundoNumero);
                }
                else
                {
                    if(operacao == "/")
                    {
                        Console.WriteLine(primeiroNumero / segundoNumero);
                    }
                    else
                    {
                        if(operacao == "*")
                        {
                            Console.WriteLine(primeiroNumero * segundoNumero);
                        }
                        else
                        {
                            Console.WriteLine("Operação inválida!");
                        }
                    }
                }
            }
            Console.ReadLine();
        }

        private void Exercicio5_1()
        {
            int somaTotal = 0;

            for(int i = 0; i<= 100; i++)
            {
                somaTotal += i;
            }
            Console.WriteLine("Resultado: " + somaTotal);
            Console.ReadLine();
        }

        private void Exercicio5_2()
        {
            int somaTotal = 0;
            int i = 0;

            while(i < 100)
            {
                somaTotal += i;
                i++;
            }
            Console.WriteLine("Resultado: " + somaTotal);
            Console.ReadLine();
        }

        private void Exercicio5_3()
        {
            int somaTotal = 0;
            int i = 0;
            do
            {
                somaTotal += i;
                i++;
            } while (i < 100);

            Console.WriteLine("Resultado: " + somaTotal);
            Console.ReadLine();
        }

        private void Exercicio10()
        {
            int quantidadePessoasSuperior50 = 0;
            int quantidadePessoasComIdadeEntre1020 = 0;
            int quantidadePessoasComPesoInferior40 = 0;
            decimal somaAlturas = 0m;
            decimal mediaAlturas = 0m;
            decimal porcentagemPessoas = 0m;

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Informa a idade: ");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o peso: ");
                decimal peso = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Informe a altura: ");
                decimal altura = decimal.Parse(Console.ReadLine());

                if (idade > 50)
                    quantidadePessoasSuperior50++;
                if(idade >= 10 && idade <= 20)
                {
                    somaAlturas += altura;
                    quantidadePessoasComIdadeEntre1020++;
                }
                if (peso < 40)
                    quantidadePessoasComPesoInferior40++;
            }

            mediaAlturas = (quantidadePessoasComIdadeEntre1020 == 0) ? 0 : somaAlturas / quantidadePessoasComIdadeEntre1020;
            porcentagemPessoas = (quantidadePessoasComPesoInferior40 * 100) / 5;

            Console.WriteLine("Quantidade de pessoas acima dos 50 anos: " + quantidadePessoasSuperior50);
            Console.WriteLine("Media altura das pessoas entre 10 e 20 anos: " + mediaAlturas);
            Console.WriteLine("Porcentagem de pessoas com peso inferior a 40kg: " + porcentagemPessoas + "%");

            Console.ReadLine();
        }
    }
}
