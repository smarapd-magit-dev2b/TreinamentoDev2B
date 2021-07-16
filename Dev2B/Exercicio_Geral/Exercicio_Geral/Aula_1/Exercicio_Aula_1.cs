using System;

namespace Aula_1
{
    public class Exercicio_Aula_1
    {
        private void Exercicio_1()
        {
            decimal nota;

            Console.WriteLine("Digite a nota: ");
            nota = Convert.ToDecimal(Console.ReadLine());

            if (nota < 4)
            {
                Console.WriteLine(" Reprovado ");
            }

            else if (nota < 7)
            {
                Console.WriteLine(" Exame ");
            }

            else if (nota <= 10)
            {
                Console.WriteLine(" Aprovado ");
            }

        }

        private void Exercicio_2()
        {
            //Exercicio 2-------------------

            //Variaveis---------------------

            decimal valor, maior = 0, menor = 10000;

            //Programa----------------------

            // For--------------------------

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" Digite um número: ");
                valor = Convert.ToDecimal(Console.ReadLine());

                if (valor > maior)
                {
                    maior = valor;
                }

                if (valor < menor)
                {
                    menor = valor;
                }

            }
            //Mensagem----------------------

            Console.WriteLine("\n O maior valor:\t" + maior);

            Console.WriteLine("\n O menor valor:\t" + menor);


        }
        private void Exercicio_3()
        {
            //Exercicio 3-------------------

            //Variaveis---------------------

            decimal valor, multiplo;
            int div;

            //Definição do divisor e valor--

            Console.WriteLine("Digite o divisor:\t");
            div = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor da divisão:\t ");
            valor = Convert.ToDecimal(Console.ReadLine());

            //Divisão-----------------------

            multiplo = valor % div;

            //If e Mensagem-----------------

            if (multiplo != 0)
            {
                Console.WriteLine("\n O Valor: " + valor + " não é multiplo por " + div + " Resposta: " + multiplo);
            }

            else
            {
                Console.WriteLine("\n O Valor: " + valor + " é multiplo por " + div + " Resposta: " + multiplo);
            }

            
        }

        private void Exercicio_4Sw()
        {
            //Exercicio 4-------------------

            //Variaveis---------------------

            decimal nu1, nu2, som, sub, mul, div;
            int op = 0;

            //Primeiro número---------------

            Console.WriteLine(" Digite o primeiro valor:\t");
            nu1 = Convert.ToDecimal(Console.ReadLine());

            // Segundo número---------------

            Console.WriteLine("Digite o segundo valor:\t");
            nu2 = Convert.ToDecimal(Console.ReadLine());

            //Opção de operação-------------

            Console.WriteLine("\n Digite (1) Soma \n Digite (2) Subtração \n Digite (3) Multiplicação \n Digite (4) Divisão \nEscolha a operação:");
            op = Convert.ToInt32(Console.ReadLine());

            //Switch------------------------

            switch (op)
            {
                case 1:

                    som = nu1 + nu2;

                    Console.WriteLine(" Resposta da soma: " + som);

                    break;

                case 2:

                    sub = nu1 - nu2;

                    Console.WriteLine(" Resposta da subtração: " + sub);

                    break;

                case 3:

                    mul = nu1 * nu2;

                    Console.WriteLine(" Resposta da multiplicação: " + mul);

                    break;

                case 4:

                    if (nu2 != 0)
                    {
                        div = nu1 / nu2;

                        Console.WriteLine(" Resposta da divisão: " + div);
                    }

                    else
                    {
                        Console.WriteLine(" Não é possivel dividir ");
                    }

                    break;

            }
        }

        private void Exercicio_4If()
        {
            //Exercicio 4-------------------

            //Variaveis---------------------

            decimal nu1, nu2, som, sub, mul, div;
            int op = 0;

            //Primeiro número---------------

            Console.WriteLine(" Digite o primeiro valor:\t");
            nu1 = Convert.ToDecimal(Console.ReadLine());

            // Segundo número---------------

            Console.WriteLine("Digite o segundo valor:\t");
            nu2 = Convert.ToDecimal(Console.ReadLine());

            //Opção de operação-------------

            Console.WriteLine("\n Digite (1) Soma \n Digite (2) Subtração \n Digite (3) Multiplicação \n Digite (4) Divisão \nEscolha a operação:");
            op = Convert.ToInt32(Console.ReadLine());

            //if----------------------------

            if (op == 1)
            {
                som = nu1 + nu2;

                Console.WriteLine(" Resposta da soma: " + som);
            }

            else if (op == 2)
            {
                sub = nu1 - nu2;

                Console.WriteLine(" Resposta da subtração: " + sub);

            }


            else if (op == 3)
            {
                mul = nu1 * nu2;

                Console.WriteLine(" Resposta da multiplicação: " + mul);

            }





            else if (op == 4)
            {

                if (nu2 != 0)
                {
                    div = nu1 / nu2;

                    Console.WriteLine(" Resposta da divisão: " + div);
                }

                else
                {
                    Console.WriteLine(" Não é possivel dividir ");
                }

            }


        }
        
       private void Exercicio_5For()
        {
            //Exercicio 5-----------------------

            //Variaveis--------------------------

            int soma = 0;

            //For-------------------------------

            for (int i = 0; i <= 100; i++)
            {
                soma = i + soma;
            }

            Console.WriteLine(" O resultado é: " + soma);



        }

        private void Exercicio_5Do()
        {
            //Exercicio 5----------------------

            //Variaveis------------------------

            int soma = 0, i = 0;

            //Do while----------------------

            do
            {
                i++;

                soma = i + soma;

            } while (i < 100);


            Console.WriteLine(" O resultado a é: " + soma);


        }

        private void Exercicio_5While()
        {
            //Exercicio 5-------------------

            //Variaveis---------------------

            int soma = 0, i = 0;

            //While-------------------------

            while (i < 100)
            {
                i++;

                soma = i + soma;

            }

            Console.WriteLine(" O resultado a é: " + soma);

        }
        private void Exercicio_6For()
        {
            //Exercicio 6----------------------

            //Variaveis------------------------

            decimal Multiplo;

            //For---------------------------

            for (int i = 1; i <= 100; i++)
            {
                Multiplo = i % 3;

                if (Multiplo == 0)

                    Console.WriteLine("Número: " + i);
            }

        }

        private void Exercicio_6Do()
        {
            //Exercicio 6-------------------

            //Variaveis---------------------

            decimal Multiplo;
            int i = 0;

            //do----------------------------

            do
            {
                i++;

                Multiplo = i % 3;

                if (Multiplo == 0)

                    Console.WriteLine("Número: " + i);

            } while (i < 100);

        }

        private void Exercicio_6While()
        {
            //Exercicio 6-------------------

            //Variaveis---------------------

            decimal Multiplo;
            int i = 0;

            //while----------------------------

            while (i < 100)
            {
                i++;

                Multiplo = i % 3;

                if (Multiplo == 0)

                    Console.WriteLine("Número: " + i);

            }

        }

        private void Exercicio_7While()
        {
            //Exercicio 7-------------------

            //Variaveis---------------------

            decimal Multiplo, Valor = 0;
            int i = 0;

            //while----------------------------

            while (i < 100)
            {
                i++;

                Multiplo = i % 3;

                if (Multiplo != 0)

                    Valor = Valor + i;

            }

            Console.WriteLine("Valor: " + Valor);

        }

        private void Exercicio_7Do()
        {
            //Exercicio 7-------------------

            //Variaveis---------------------

            decimal Multiplo, Valor = 0;
            int i = 0;

            //while----------------------------

            do
            {
                i++;

                Multiplo = i % 3;

                if (Multiplo != 0)

                    Valor = Valor + i;

            } while (i < 100);

            Console.WriteLine("Valor: " + Valor);


        }

        private void Exercicio_7For()
        {
            //Exercicio 7-------------------

            //Variaveis---------------------

            decimal Multiplo, Valor = 0;

            //while----------------------------

            for (int i = 0; i <= 100; i++)
            {


                Multiplo = i % 3;

                if (Multiplo != 0)

                    Valor = Valor + i;

            }

            Console.WriteLine("Valor: " + Valor);
        }

        private void Exercicio_8For()
        {
            //Exercicio 8----------------------

            //Variaveis------------------------

            decimal Multiplo, Multiplo1;

            //For---------------------------

            for (int i = 1; i <= 30; i++)
            {
                Multiplo = i % 3;
                Multiplo1 = i % 4;

                if (Multiplo == 0 || Multiplo1 == 0)

                    Console.WriteLine("Número: " + i);
            }


        }

        private void Exercicio_8Do()
        {
            //Exercicio 8----------------------

            //Variaveis------------------------

            decimal Multiplo, Multiplo1;
            int i = 0;
            //do---------------------------

            do
            {
                i++;

                Multiplo = i % 3;
                Multiplo1 = i % 4;

                if (Multiplo == 0 || Multiplo1 == 0)

                    Console.WriteLine("Número: " + i);
            } while (i <= 30);

        }

        private void Exercicio_8While()
        {
            //Exercicio 8----------------------

            //Variaveis------------------------

            decimal Multiplo, Multiplo1;
            int i = 0;
            //do---------------------------

            while (i <= 30)
            {
                i++;

                Multiplo = i % 3;
                Multiplo1 = i % 4;

                if (Multiplo == 0 || Multiplo1 == 0)

                    Console.WriteLine("Número: " + i);
            }

        }

        private void Exercicio_9For()
        {

            //Exercicio 9-------------------

            //Variaveis---------------------

            int numero, respostas;

            //Programa----------------------

            Console.WriteLine("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //for---------------------------
            for (int i = 0; i <= 10; i++)
            {

                respostas = numero * i;

                Console.WriteLine(i + " X " + numero + " = " + respostas);

            }

        }

        private void Exercicio_9Do()
        {
            //Exercicio 9-------------------

            //Variaveis---------------------

            int numero, respostas, i = 0;

            //Programa----------------------

            Console.WriteLine("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //do---------------------------
            do
            {

                respostas = numero * i;

                Console.WriteLine(i + " X " + numero + " = " + respostas);

                i++;

            } while (i <= 10);

        }

        private void Exercicio_9While()
        {
            //Exercicio 9-------------------

            //Variaveis---------------------

            int numero, respostas, i = 0;

            //Programa----------------------

            Console.WriteLine("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //do---------------------------
            while (i <= 10)
            {

                respostas = numero * i;

                Console.WriteLine(i + " X " + numero + " = " + respostas);

                i++;

            }

        }


        private void Exercicio_10()
        {
            //Exercicio 10------------------

            //Variaveis---------------------

            decimal peso, altura, idade, media = 0, soma = 0, contador1 = 0;

            decimal porcentagem = 0;

            int contador = 0, j = 0;

            //For---------------------------

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Digite sua idade: ");
                idade = Convert.ToDecimal(Console.ReadLine());


                Console.WriteLine("Digite sua altura: ");
                altura = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite sua peso: ");
                peso = Convert.ToDecimal(Console.ReadLine());

                if (idade > 50)
                    contador++;

                else if (idade > 10 && idade < 20)
                {
                    j++;

                    soma = altura + soma;

                    media = soma / j;

                }

                else if (peso < 40)

                    contador1++;
            }

            if (contador1 != 0)

                porcentagem = contador1 / 5 * 100;

            else

                porcentagem = 0;

            Console.WriteLine("\n Total de pessoas com idade acima de 50 anos: " + contador);

            Console.WriteLine("\n A media das auturas: " + media);

            Console.WriteLine("\n Porcentagem de pessoas com menos de 40 Kg: " + porcentagem + "%");

        }

        public void Executar_Aula1()
        {
            Exercicio_1();
            Exercicio_2();
            Exercicio_3();
            Exercicio_4Sw();
            Exercicio_4If();
            Exercicio_5For();
            Exercicio_5While();
            Exercicio_6For();
            Exercicio_6Do();
            Exercicio_6While();
            Exercicio_7While();
            Exercicio_7Do();
            Exercicio_7For();
            Exercicio_8For();
            Exercicio_8Do();
            Exercicio_8While();
            Exercicio_9For();
            Exercicio_9Do();
            Exercicio_9While();
            Exercicio_10();

        }



    }
}
