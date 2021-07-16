using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4sw();
            //Ex4if();
            //Ex5();
            //Ex5do();
            //Ex5While();
            //Ex6();
            //Ex6do();
            //Ex6while();
            //Ex7while();
            //Ex7do();
            //Ex7();
            //Ex8();
            //Ex8do();
            //Ex8while();
            //Ex9();
            //Ex9do();
            //Ex9while();
           //Ex10();
        }

        static void Ex1()
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

        static void Ex2()
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

        static void Ex3()
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

        static void Ex4sw()
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

        static void Ex4if()
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

        static void Ex5()
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

        static void Ex5do()
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

        static void Ex5While()
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

        static void Ex6()
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

        static void Ex6do()
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

        static void Ex6while()
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

        static void Ex7while()
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

        static void Ex7do()
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

        static void Ex7()
        {

            //Exercicio 7-------------------

            //Variaveis---------------------

            decimal Multiplo, Valor = 0;

            //while----------------------------
               
            for(int i = 0; i <= 100; i ++)
            {
 

                Multiplo = i % 3;

                if (Multiplo != 0)

                    Valor = Valor + i;

            } 

            Console.WriteLine("Valor: " + Valor);


        }

        static void Ex8()
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

        static void Ex8do()
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

        static void Ex8while()
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

        static void Ex9()
        {
            //Exercicio 9-------------------

            //Variaveis---------------------

            int numero, respostas;

            //Programa----------------------

            Console.WriteLine("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //for---------------------------
            for(int i = 0; i <=10; i++)
            {

                respostas = numero * i;

                Console.WriteLine( i+ " X " + numero + " = " + respostas);

            }



        }

        static void Ex9do()
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

        static void Ex9while()
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

        static void Ex10()
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

                Console.WriteLine("\n Total de pessoas com idade acima de 50 anos: " +contador);
                
                Console.WriteLine("\n A media das auturas: " +media);

                Console.WriteLine("\n Porcentagem de pessoas com menos de 40 Kg: " +porcentagem + "%");

            




        }
    }
}

    


