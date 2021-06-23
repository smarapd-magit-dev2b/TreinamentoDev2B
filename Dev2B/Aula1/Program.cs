using System;
using System.Collections.Generic;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha qual exercicio verificar (1,2,3,4,5,10):");
            string exercicio = Console.ReadLine();
            int i = 0;
            
            switch (exercicio)
            {
                case "1":
                    string temp = Console.ReadLine();
                    decimal nota = Convert.ToDecimal(temp);
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
                    break;
                case "2":
                    List<int> list = new List<int>();
                    int maior = 0;
                    int menor = 0;
                    int aux = 0;
                    for ( i = 0; i < 10; i++)
                    {
                        list.Add(Convert.ToInt32(Console.ReadLine()));
                    }
                    for ( i = 0; i < 9; i++)
                    {
                        aux = list[0];
                        if (list[i] < list[i + 1])
                        {
                            aux = list[i + 1];
                        }
                    }
                    maior = aux;
                    aux = 0;
                    for ( i = 0; i < 9; i++)
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
                    break;
                case "3":
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
                    break;
                case "4":
                    int numero1 = Convert.ToInt32(Console.ReadLine());
                    int numero2 = Convert.ToInt32(Console.ReadLine());
                    string simbolo = Console.ReadLine();
                    int resultado2;
                    switch (simbolo)
                    {
                        case "+":
                            resultado2 = numero1 + numero2;
                            Console.WriteLine(resultado2);
                            break;
                        case "-":
                            resultado2 = numero1 - numero2;
                    Console.WriteLine(resultado2);
                            break;
                        case "*":
                            resultado2 = numero1 * numero2;
                            Console.WriteLine(resultado2);
                            break;
                        case "/":
                            resultado2 = numero1 / numero2;
                            Console.WriteLine(resultado2);
                            break;
                    }
                    if(simbolo == "+")
                    {
                            resultado2 = numero1 + numero2;
                            Console.WriteLine(resultado2);
            }
            else if (simbolo == "-")
            {
                    resultado2 = numero1 - numero2;
                    Console.WriteLine(resultado2);
            }
            else if (simbolo == "*")
            {
                    resultado2 = numero1 * numero2;
                    Console.WriteLine(resultado2);
            }
            else if (simbolo == "/")
            {
                    resultado2 = numero1 / numero2;
                    Console.WriteLine(resultado2);
            }
                    break;
                case "5":
                    int total = 0;
                    i = 0;
                    for (i = 0; i <= 100; i++)
                    {
                        total = total + i;
                    }
                    Console.WriteLine(total);
                    i = 0;
                    total = 0;
                    while (i <= 100)
                    {
                        total = total + i;
                        i++;
                    }
                    Console.WriteLine(total);
                    i = 0;
                    total = 0;
                    do
                    {
                        total = total + i;
                        i++;
                    } while (i <= 100);
                    break;
                //case "6":
                //    break;
                //case "7":
                //    break;
                //case "8":
                //    break;
                //case "9":
                //    break;
                case "10":
                    Pessoa pessoa1 = new Pessoa();
                    Pessoa pessoa2 = new Pessoa();
                    Pessoa pessoa3 = new Pessoa();
                    Pessoa pessoa4 = new Pessoa();
                    Pessoa pessoa5 = new Pessoa();
                    i = 0;
                    int acima50 = 0;
                    int contIdade = 0;
                    decimal totalAltura = 0;
                    decimal mediaAltura = 0;
                    int abaixo40 = 0;
                    int porcentagemAbaixo40 = 0;
                    for (i = 0; i < 5; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                pessoa1.altura = Convert.ToDecimal(Console.ReadLine());
                                pessoa1.peso = Convert.ToInt32(Console.ReadLine());
                                pessoa1.idade = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 1:
                                pessoa2.altura = Convert.ToDecimal(Console.ReadLine());
                                pessoa2.peso = Convert.ToInt32(Console.ReadLine());
                                pessoa2.idade = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2:
                                pessoa3.altura = Convert.ToDecimal(Console.ReadLine());
                                pessoa3.peso = Convert.ToInt32(Console.ReadLine());
                                pessoa3.idade = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                pessoa4.altura = Convert.ToDecimal(Console.ReadLine());
                                pessoa4.peso = Convert.ToInt32(Console.ReadLine());
                                pessoa4.idade = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 4:
                                pessoa5.altura = Convert.ToDecimal(Console.ReadLine());
                                pessoa5.peso = Convert.ToInt32(Console.ReadLine());
                                pessoa5.idade = Convert.ToInt32(Console.ReadLine());
                                break;
                        }
                    }
                    for (i = 0; i < 5; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                if (pessoa1.idade > 50)
                                {
                                    acima50++;
                                }
                                break;
                            case 1:
                                if (pessoa2.idade > 50)
                                {
                                    acima50++;
                                }
                                break;
                            case 2:
                                if (pessoa3.idade > 50)
                                {
                                    acima50++;
                                }
                                break;
                            case 3:
                                if (pessoa4.idade > 50)
                                {
                                    acima50++;
                                }
                                break;
                            case 4:
                                if (pessoa5.idade > 50)
                                {
                                    acima50++;
                                }
                                break;
                        }
                    }
                    for (i = 0; i < 5; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                if (pessoa1.idade > 10 && pessoa1.idade < 20)
                                {
                                    contIdade++;
                                    totalAltura = totalAltura + pessoa1.altura;
                                }
                                break;
                            case 1:
                                if (pessoa2.idade > 10 && pessoa2.idade < 20)
                                {
                                    contIdade++;
                                    totalAltura = totalAltura + pessoa2.altura;
                                }
                                break;
                            case 2:
                                if (pessoa3.idade > 10 && pessoa3.idade < 20)
                                {
                                    contIdade++;
                                    totalAltura = totalAltura + pessoa3.altura;
                                }
                                break;
                            case 3:
                                if (pessoa4.idade > 10 && pessoa4.idade < 20)
                                {
                                    contIdade++;
                                    totalAltura = totalAltura + pessoa4.altura;
                                }
                                break;
                            case 4:
                                if (pessoa5.idade > 10 && pessoa5.idade < 20)
                                {
                                    contIdade++;
                                    totalAltura = totalAltura + pessoa5.altura;
                                }
                                break;
                        }
                    }
                    for (i = 0; i < 5; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                if (pessoa1.peso > 40)
                                {
                                    abaixo40++;
                                }
                                break;
                            case 1:
                                if (pessoa2.peso > 40)
                                {
                                    abaixo40++;
                                }
                                break;
                            case 2:
                                if (pessoa3.peso > 40)
                                {
                                    abaixo40++;
                                }
                                break;
                            case 3:
                                if (pessoa4.peso > 40)
                                {
                                    abaixo40++;
                                }
                                break;
                            case 4:
                                if (pessoa5.peso > 40)
                                {
                                    abaixo40++;
                                }
                                break;
                        }
                    }
                    mediaAltura = totalAltura / contIdade;
                    porcentagemAbaixo40 = 100 * abaixo40 / 5;
                    Console.WriteLine("Pessoas acima de 50:" + acima50);
                    Console.WriteLine("Media da altura pessoas entre 10 e 20: " + mediaAltura);
                    Console.WriteLine("Percentual de pessoas com peso abaixo de 40: " + porcentagemAbaixo40);
                    break;
            }
            Console.ReadLine();
        }
        
    }
}
