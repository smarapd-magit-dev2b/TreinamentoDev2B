using Domain;
using System;

namespace Aula1
{
    public class EstruturaComandos : IExecute
    {
        public void Execute()
        {
            Menu menu = new Menu("Exercícios de Estrutura de Comandos");
            menu.AddItem("Exercício 1");
            menu.AddItem("Exercício 2");
            menu.AddItem("Exercício 3");
            menu.AddItem("Exercícios 4");
            menu.AddItem("Exercícios 5");
            menu.AddItem("Exercícios 6");
            menu.AddItem("Exercícios 7");
            menu.AddItem("Exercícios 8");
            menu.AddItem("Exercício 9");
            menu.AddItem("Exercício 10");
            bool run = true;
            do
            {
                menu.Print();
                Console.Write("Digite o número que deseja executar: ");
                try
                {
                    var escolha = int.Parse(Console.ReadLine());
                    switch (escolha)
                    {
                        case 1:
                            Console.Clear();
                            new Exercicio1();
                            break;
                        case 2:
                            Console.Clear();
                            Ex2();
                            break;
                        case 3:
                            Console.Clear();
                            Ex3();
                            break;
                        case 4:
                            Console.Clear();
                            Ex4if();
                            Ex4switch();
                            break;
                        case 5:
                            Console.Clear();
                            Ex5for();
                            Ex5while();
                            Ex5do();
                            break;
                        case 6:
                            Console.Clear();
                            Ex6for();
                            Ex6while();
                            Ex6do();
                            break;
                        case 7:
                            Console.Clear();
                            Ex7for();
                            Ex7while();
                            Ex7do();
                            break;
                        case 8:
                            Console.Clear();
                            Ex8for();
                            Ex8while();
                            Ex8do();
                            break;
                        case 9:
                            Console.Clear();
                            Ex9();
                            break;
                        case 10:
                            Console.Clear();
                            Ex10();
                            break;
                        case 0:
                            Console.Clear();
                            run = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine($"{escolha} não está na lista!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas números!\n");
                }
            } while (run);
        }

        private void Ex2()
        {
            int maiorNumero = 0, menorNumero = 0;
            int numero;
            Console.WriteLine("Exercício 2\n\nDigite 10 números\n");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}º número: ");
                numero = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    maiorNumero = numero;
                    menorNumero = numero;
                }
                else if (numero > maiorNumero)
                    maiorNumero = numero;
                else if (numero < menorNumero)
                    menorNumero = numero;
            }
            Console.WriteLine($"O maior número digitado foi o {maiorNumero}");
            Console.WriteLine($"O menor número digitado foi o {menorNumero}\n");
        }
        private void Ex3()
        {
            int valor1, valor2;
            Console.WriteLine("Exercício 3\n\nDigite 2 valores\n\nPrimeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());
            if ((valor1 % valor2) == 0)
                Console.WriteLine($"{valor1} é múltiplo de {valor2}");
            else if ((valor2 % valor1) == 0)
                Console.WriteLine($"{valor2} é múltiplo de {valor1}");
            else
                Console.WriteLine($"{valor1} e {valor2} não são múltiplos");
            Console.WriteLine("\n");
        }
        private void Ex4if()
        {
            decimal numero1, numero2;
            char? operacao = null;
            Console.WriteLine("Exercício 4 If\n\nDigite dois números e a operação que deseja realizar com eles\n\n" +
                "Operações: Soma(+), Subtração(-), Multiplicação(x), Divisão(/)\n");
            Console.Write("Primeiro número: ");
            numero1 = decimal.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            numero2 = decimal.Parse(Console.ReadLine());
            Console.Write("Operação: ");
            try
            {
                operacao = char.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite apenas 1 caractere!");
            }
            if (operacao == '+')
                Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
            else if (operacao == '-')
                Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
            else if (operacao == 'x')
                Console.WriteLine($"{numero1} x {numero2} = {numero1 * numero2}");
            else if (operacao == '/')
                Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
            else
                Console.WriteLine($"{operacao} é uma operação inválida!");
            Console.WriteLine("\n");
        }
        private void Ex4switch()
        {
            decimal numero1, numero2;
            char? operacao = null;
            Console.WriteLine("Exercício 4 Switch\n\nDigite dois números e a operação que deseja realizar com eles\n\n" +
                "Operações: Soma(+), Subtração(-), Multiplicação(x), Divisão(/)\n");
            Console.Write("Primeiro número: ");
            numero1 = decimal.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            numero2 = decimal.Parse(Console.ReadLine());
            Console.Write("Operação: ");
            try
            {
                operacao = char.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite apenas 1 caractere!");
            }
            switch (operacao)
            {
                case '+':
                    Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
                    break;
                case '-':
                    Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");
                    break;
                case 'x':
                    Console.WriteLine($"{numero1} x {numero2} = {numero1 * numero2}");
                    break;
                case '/':
                    Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
                    break;
                default:
                    Console.WriteLine($"{operacao} é uma operação inválida!");
                    break;
            }
            Console.WriteLine("\n");
        }
        private void Ex5for()
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++)
                soma += i;
            Console.WriteLine($"Exercício 5 for\n\nSoma de 1 a 100: {soma}\n");
        }
        private void Ex5while()
        {
            int soma = 0, i = 1;
            while (i <= 100)
            {
                soma += i;
                i++;
            }
            Console.WriteLine($"Exercício 5 While\n\nSoma de 1 a 100: {soma}\n");
        }
        private void Ex5do()
        {
            int soma = 0, i = 1;
            do
            {
                soma += i;
                i++;
            } while (i <= 100);
            Console.WriteLine($"Exercício 5 Do While\n\nSoma de 1 a 100: {soma}\n");
        }
        private void Ex6for()
        {
            Console.WriteLine("Exercício 6 For\n");
            for (int i = 3; i < 100; i += 3)
                Console.WriteLine(i);
            Console.WriteLine("\n");
        }
        private void Ex6while()
        {
            Console.WriteLine("Exercício 6 While\n");
            int i = 3;
            while (i < 100)
            {
                Console.WriteLine(i);
                i += 3;
            }
            Console.WriteLine("\n");
        }
        private void Ex6do()
        {
            Console.WriteLine("Exercício 6 Do While\n");
            int i = 3;
            do
            {
                Console.WriteLine(i);
                i += 3;
            } while (i < 100);
            Console.WriteLine("\n");
        }
        private void Ex7for()
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++)
                if ((i % 3) != 0)
                    soma += i;
            Console.WriteLine($"Exercício 7 For\n\nSoma de 1 a 100 menos os múltiplos de 3: {soma}\n");
        }
        private void Ex7while()
        {
            int soma = 0, i = 1;
            while (i <= 100)
            {
                if ((i % 3) != 0)
                    soma += i;
                i++;
            }
            Console.WriteLine($"Exercício 7 While\n\nSoma de 1 a 100 menos os múltiplos de 3: {soma}\n");
        }
        private void Ex7do()
        {
            int soma = 0, i = 1;
            do
            {
                if ((i % 3) != 0)
                    soma += i;
                i++;
            } while (i <= 100);
            Console.WriteLine($"Exercício 7 Do While\n\nSoma de 1 a 100 menos os múltiplos de 3: {soma}\n");
        }
        private void Ex8for()
        {
            Console.WriteLine("Exercício 8 For\n");
            for (int i = 3; i < 30; i++)
                if ((i % 3) == 0 || (i % 4) == 0)
                    Console.WriteLine(i);
            Console.WriteLine("\n");
        }
        private void Ex8while()
        {
            Console.WriteLine("Exercício 8 While\n");
            int i = 3;
            while (i < 30)
            {
                if ((i % 3) == 0 || (i % 4) == 0)
                    Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("\n");
        }
        private void Ex8do()
        {
            Console.WriteLine("Exercício 8 Do While\n");
            int i = 3;
            do
            {
                if ((i % 3) == 0 || (i % 4) == 0)
                    Console.WriteLine(i);
                i++;
            } while (i < 30);
            Console.WriteLine("\n");
        }
        private void Ex9()
        {
            int numero;
            bool run = true;
            do
            {
                Console.Write("Exercício 9 \n\nDigite um número de 1 a 100: ");
                numero = int.Parse(Console.ReadLine());
                if (numero >= 0 && numero <= 100)
                {
                    Tabuada(numero);
                    run = false;
                }
                else
                    Console.WriteLine($"{numero} é um número inválido");
            } while (run);
            Console.WriteLine("\n");
        }
        private void Tabuada(int numero)
        {
            for (int i = 0; i <= 10; i++)
                Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
        private void Ex10()
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
        //Desafios
        private void Desafio1()
        {
            bool run = true;
            do
            {
                int? valor = null;
                try
                {
                    valor = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite um número inteiro");
                }
                if (valor == 0)
                    run = false;
                else if (valor <= 0)
                    Console.WriteLine($"{valor}é um valor inválido");
            } while (run);
        }
    }
}
