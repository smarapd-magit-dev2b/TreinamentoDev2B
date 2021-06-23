using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4IF();
            //Exercicio4Switch();
            //Exercicio5For();
            //Exercicio5While();
            //Exercicio5DoWhile();
            //Exercicio6For();
            //Exercicio6While();
            //Exercicio6DoWhile();
            //Exercicio7For();
            //Exercicio7While();
            //Exercicio7DoWhile();
            //Exercicio8For();
            //Exercicio8While();
            //Exercicio8DoWhile();
            //Exercicio9For();
            //Exercicio9While();
            //Exercicio9DoWhile();
            //Exercicio10();
            Exercicio10_2();
        }

        static void Exercicio1()
        {
            Console.Write("Informe a nota: ");

            string entrada = Console.ReadLine();
            decimal nota = decimal.Parse(entrada);

            if (nota >= 7 && nota <= 10)
            {
                Console.WriteLine("Aprovado!");
            }
            else if (nota >= 4 && nota < 7)
            {
                Console.WriteLine("Exame!");
            }
            else if (nota >= 0 && nota < 4)
            {
                Console.WriteLine("Reprovado!");
            }

        }

        static void Exercicio2()
        {
            decimal menorValor = 0;
            decimal maiorValor = 0;
            decimal valor;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Informe o {i} valor: ");
                valor = decimal.Parse(Console.ReadLine());

                if (i == 0)
                {
                    maiorValor = valor;
                    menorValor = valor;
                }

                if (valor > maiorValor) maiorValor = valor;
                if (valor < menorValor) menorValor = valor;
            }


            Console.WriteLine($"Menor valor: {menorValor}");
            Console.WriteLine($"Maior valor: {maiorValor}");
        }

        static void Exercicio3()
        {
            Console.WriteLine("Informe o valor 1");
            decimal valor1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor 2");
            decimal valor2 = decimal.Parse(Console.ReadLine());


            if (valor1 % valor2 == 0)
                Console.WriteLine($"Os valores {valor1} e {valor2} são multiplos");
            else
                Console.WriteLine($"Os valores {valor1} e {valor2} não são multiplos");
        }

        static void Exercicio4IF()
        {
            Console.WriteLine("Informe o valor 1");
            decimal valor1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor 2");
            decimal valor2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe a operação (/ , * , - , +)");
            string operacao = Console.ReadLine();
            decimal resultado = 0;

            if (operacao == "+")
            {
                resultado = valor1 + valor2;
            }
            else if (operacao == "-")
            {
                resultado = valor1 - valor2;
            }
            else if (operacao == "*")
            {
                resultado = valor1 * valor2;
            }
            else if (operacao == "/")
            {
                resultado = valor1 / valor2;
            }

            Console.WriteLine($"O resultado a operação de {operacao} é igual a {resultado}");
        }

        static void Exercicio4Switch()
        {
            Console.WriteLine("Informe o valor 1");
            decimal valor1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor 2");
            decimal valor2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe a operação (/ , * , - , +)");
            string operacao = Console.ReadLine();
            decimal resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    resultado = valor1 / valor2;
                    break;
                default:
                    Console.WriteLine("Operação invalida");
                    return;
            }


            Console.WriteLine($"O resultado a operação de {operacao} é igual a {resultado}");
        }

        static void Exercicio5For()
        {
            decimal somaFor = 0;



            for (int i = 1; i <= 100; i++)
            {
                somaFor += i;
            }


            Console.WriteLine($"A soma é: {somaFor}");
        }

        static void Exercicio5While()
        {
            decimal somaWhile = 0;
            int cWhile = 1;

            while (cWhile <= 100)
            {
                somaWhile += cWhile;
                cWhile++;
            }

            Console.WriteLine($"A soma é: {somaWhile}");
        }

        static void Exercicio5DoWhile()
        {
            decimal somaDoWhile = 0;
            int cDoWhile = 0;

            do
            {
                somaDoWhile += cDoWhile;
                cDoWhile++;
            } while (cDoWhile <= 100);
            Console.WriteLine($"A soma é: {somaDoWhile}");
        }

        static void Exercicio6For()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) Console.WriteLine(i);
            }
        }

        static void Exercicio6While()
        {
            int cWhile = 1;

            while (cWhile <= 100)
            {
                if (cWhile % 3 == 0) Console.WriteLine(cWhile);
                cWhile++;
            }

        }

        static void Exercicio6DoWhile()
        {
            int cDoWhile = 0;

            do
            {
                if (cDoWhile % 3 == 0) Console.WriteLine(cDoWhile);
                cDoWhile++;
            } while (cDoWhile <= 100);
        }

        static void Exercicio7For()
        {
            decimal resultado = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0) resultado += i;
            }

            Console.WriteLine($"O resultado é: {resultado}");
        }

        static void Exercicio7While()
        {
            decimal resultado = 0;
            int cWhile = 1;

            while (cWhile <= 100)
            {
                if (cWhile % 3 != 0) resultado += cWhile;
                cWhile++;
            }
            Console.WriteLine($"O resultado é: {resultado}");

        }

        static void Exercicio7DoWhile()
        {
            decimal resultado = 0;
            int cDoWhile = 0;

            do
            {
                if (cDoWhile % 3 != 0) resultado += cDoWhile;
                cDoWhile++;
            } while (cDoWhile <= 100);

            Console.WriteLine($"O resultado é: {resultado}");
        }

        static void Exercicio8For()
        {
            for (int i = 0; i <= 30; i++)
            {
                string[] valores = i.ToString().Split("");
                decimal resultado = 0;

                foreach (string item in valores)
                {
                    decimal v = decimal.Parse(item);
                    resultado += v;
                }

                if (resultado % 3 == 0 || resultado % 4 == 0) Console.WriteLine(i);
            }
        }

        static void Exercicio8While()
        {

            int cWhile = 1;

            while (cWhile <= 30)
            {
                string[] valores = cWhile.ToString().Split("");
                decimal resultado = 0;

                foreach (string item in valores)
                {
                    decimal v = decimal.Parse(item);
                    resultado += v;
                }

                if (resultado % 3 == 0 || resultado % 4 == 0) Console.WriteLine(cWhile);
                cWhile++;
            }

        }

        static void Exercicio8DoWhile()
        {

            int cDoWhile = 0;

            do
            {
                string[] valores = cDoWhile.ToString().Split("");
                decimal resultado = 0;

                foreach (string item in valores)
                {
                    decimal v = decimal.Parse(item);
                    resultado += v;
                }

                if (resultado % 3 == 0 || resultado % 4 == 0) Console.WriteLine(cDoWhile);
                cDoWhile++;
            } while (cDoWhile <= 100);

        }

        static void Exercicio9For()
        {
            Console.WriteLine("Informe o numero: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 100 || n < 0)
            {
                Console.WriteLine("Apenas numeros entre 0 e 100");
                return;
            }
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }

        static void Exercicio9While()
        {
            Console.WriteLine("Informe o numero: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 100 || n < 0)
            {
                Console.WriteLine("Apenas numeros entre 0 e 100");
                return;
            }
            int cWhile = 0;

            while (cWhile <= 10)
            {
                Console.WriteLine($"{n} x {cWhile} = {n * cWhile}");
                cWhile++;
            }

        }

        static void Exercicio9DoWhile()
        {
            Console.WriteLine("Informe o numero: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 100 || n < 0)
            {
                Console.WriteLine("Apenas numeros entre 0 e 100");
                return;
            }
            int cDoWhile = 0;

            do
            {
                Console.WriteLine($"{n} x {cDoWhile} = {n * cDoWhile}");
                cDoWhile++;
            } while (cDoWhile <= 10);

        }

        static void Exercicio10()
        {
            // Feito com array
            Pessoa[] pessoas = new Pessoa[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Dados da pessoa {i + 1}");
                Console.WriteLine("Informe a idade");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o peso");
                Decimal peso = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Informe a altura");
                Decimal altura = decimal.Parse(Console.ReadLine());
                pessoas[i] = new Pessoa(idade, peso, altura);
            }

            int pessoasMaiorDe50 = 0;
            decimal mediaDasAlturas = 0m;
            int pessoasEntre10e20 = 0;
            int pessoasMenoresDe40Quiloskg = 0;

            foreach (Pessoa p in pessoas)
            {
                if (p.idade > 50) pessoasMaiorDe50++;

                if (p.idade > 10 && p.idade < 20)
                {
                    pessoasEntre10e20++;
                    mediaDasAlturas += p.altura;
                }

                if (p.peso < 40) pessoasMenoresDe40Quiloskg++;
            }

            Console.WriteLine($"A quantidade de pessoas com idade superior a 50 anos: {pessoasMaiorDe50}");
            Console.WriteLine($"A média das alturas das pessoas com idade entre 10 a 20 anos: {mediaDasAlturas / pessoasEntre10e20}");
            Console.WriteLine($"A porcentagem de pessoas com peso inferior a 40 kg: {(pessoasMenoresDe40Quiloskg * 100) / 5}%");
        }

        static void Exercicio10_2()
        {
            // Feito sem array
            Pessoa Pessoa1 = new Pessoa();
            Pessoa Pessoa2 = new Pessoa();
            Pessoa Pessoa3 = new Pessoa();
            Pessoa Pessoa4 = new Pessoa();
            Pessoa Pessoa5 = new Pessoa();
            Pessoa PessoaVariavel = null;
         
            int pessoasMaiorDe50 = 0;
            decimal mediaDasAlturas = 0m;
            int pessoasEntre10e20 = 0;
            int pessoasMenoresDe40Quiloskg = 0;

            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    PessoaVariavel = Pessoa1;
                }
                else if (i == 1)
                {
                    PessoaVariavel = Pessoa2;
                }
                else if (i == 2)
                {
                    PessoaVariavel = Pessoa3;
                }
                else if (i == 3)
                {
                    PessoaVariavel = Pessoa4;
                }
                else if (i == 4)
                {
                    PessoaVariavel = Pessoa5;
                }

                Console.WriteLine($"Dados da pessoa {i + 1}");
                Console.WriteLine("Informe a idade");
                PessoaVariavel.idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o peso");
                PessoaVariavel.peso = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Informe a altura");
                PessoaVariavel.altura = decimal.Parse(Console.ReadLine());

            }

            

            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    PessoaVariavel = Pessoa1;
                }
                else if (i == 1)
                {
                    PessoaVariavel = Pessoa2;
                }
                else if (i == 2)
                {
                    PessoaVariavel = Pessoa3;
                }
                else if (i == 3)
                {
                    PessoaVariavel = Pessoa4;
                }
                else if (i == 4)
                {
                    PessoaVariavel = Pessoa5;
                }

                if (PessoaVariavel.idade > 50) pessoasMaiorDe50++;

                if (PessoaVariavel.idade > 10 && PessoaVariavel.idade < 20)
                {
                    pessoasEntre10e20++;
                    mediaDasAlturas += PessoaVariavel.altura;
                }

                if (PessoaVariavel.peso < 40) pessoasMenoresDe40Quiloskg++;
            }

            Console.WriteLine($"A quantidade de pessoas com idade superior a 50 anos: {pessoasMaiorDe50}");
            Console.WriteLine($"A média das alturas das pessoas com idade entre 10 a 20 anos: {mediaDasAlturas / pessoasEntre10e20}");
            Console.WriteLine($"A porcentagem de pessoas com peso inferior a 40 kg: {(pessoasMenoresDe40Quiloskg * 100) / 5}%");
        }

    }
}
