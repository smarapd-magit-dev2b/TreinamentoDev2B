using System;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exer01();
            //Exer02(); 
            //Exer03();
            //Exer04_1();
            //Exer04_2();
            //Exer05_1();
            //Exer05_2();
            //Exer05_3();
            //Exer06();
            //Exer07();
            //Exer08();
            //Exer09();
            //Exer10();


            static void Exer01()
            {
                decimal nota = 0m;
                decimal media = 0m;

                int i = 1;

                for(i = 1 ; i < 4; i++)
                {
                    Console.Write("Informe a "+ i +"° nota: ");
                    media = Convert.ToDecimal(Console.ReadLine());
                    nota = media + nota;
                }

                media = nota / 3;

                if(media >= 7 && media <= 10)
                {
                    Console.WriteLine("Aprovado");
                }else if(media > 4 && media < 7)
                {
                    Console.WriteLine("Exame");
                }else if(media >= 0 && media < 4)
                {
                    Console.WriteLine("Reprovado");
                }
                else
                {
                    Console.WriteLine("Média Inválida, Informe notas de 0 a 10");
                }

                Console.ReadLine();
                Console.WriteLine();
            }



            static void Exer02()
            {
                decimal maior = 0;
                decimal menor = 0;

                for (int i = 0; i < 10; i++)
                {
                    var random = decimal.Parse(Console.ReadLine());

                    if (i == 0)
                    {
                        random = maior;
                        random = menor;
                    }
                    if(random > maior)
                    {
                        maior = random;
                    }
                    if(random < menor)
                    {
                        menor = random;
                    }
                }
                Console.WriteLine("O Maior Número:" + maior);
                Console.WriteLine("O Menor Número:" + menor);

                Console.ReadLine();
            }


            static void Exer03()
            {
                Console.WriteLine("Digite o primeiro número:");
                var primeiro = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número:");
                var segundo = decimal.Parse(Console.ReadLine());

                if(primeiro % segundo == 0)
                {
                    Console.WriteLine("São Múltiplos");
                }
                else
                {
                    Console.WriteLine("Não são múltiplos");
                }
                Console.ReadLine();
            }
            
            static void Exer04_1()
            {
                decimal primeiro, segundo, resultado = 0;
                char Operacao;

                Console.WriteLine("Informe a Operação: ");


                char.TryParse(Console.ReadLine(), out Operacao);

                Console.WriteLine();
                Console.Write("Informe o primeiro valor: ");
                decimal.TryParse(Console.ReadLine(), out primeiro);

                Console.WriteLine();
                Console.Write("Informe o segundo valor: ");
                decimal.TryParse(Console.ReadLine(), out segundo);

                Console.WriteLine();
                Console.WriteLine();

                switch (Operacao)
                {
                    case '+':
                        resultado = (primeiro + segundo);
                        break;
                    case '-':
                        resultado = (primeiro - segundo);
                        break;
                    case '*':
                        resultado = (primeiro * segundo);
                        break;
                    case '/':
                        resultado = (primeiro / segundo);
                        break;
                    default:
                        Console.WriteLine("Informe uma operação válida");
                        break;
                }
                Console.WriteLine(string.Format("Resultao: {0}", resultado));
            }

            static void Exer04_2()
            {
                decimal primeiro, segundo, resultado = 0;
                char Operacao;

                Console.WriteLine("Informe a Operação: ");

                char.TryParse(Console.ReadLine(), out Operacao);

                Console.WriteLine();
                Console.Write("Informe o primeiro valor: ");
                decimal.TryParse(Console.ReadLine(), out primeiro);

                Console.WriteLine();
                Console.Write("Informe o segundo valor: ");
                decimal.TryParse(Console.ReadLine(), out segundo);

                Console.WriteLine();
                Console.WriteLine();

                if(Operacao == '+')
                {
                    resultado = primeiro + segundo;
                }else if (Operacao == '-')
                {
                    resultado = primeiro - segundo;
                }else if(Operacao == '*')
                {
                    resultado = primeiro * segundo;
                }else if(Operacao == '/')
                {
                    resultado = primeiro / segundo;
                }
                else
                {
                   Console.WriteLine("Informe uma operação inválida: " + Operacao);
                }
                Console.WriteLine(string.Format("Resultao: {0}", resultado));
            }

            static void Exer05_1()
            {

                int soma = 0;

                for (int i = 0; i<=100; i++)
                {
                    soma += i;
                }

                Console.WriteLine("Utilizando FOR: "+ soma);
            }

            static void Exer05_2()
            {
                int soma = 0;
                int i = 0;

                while(i <= 100)
                {
                    soma += i;
                    i++;
                }
                Console.WriteLine("Utilizando WHILE: " + soma);
            }

            static void Exer05_3()
            {
                int i = 0;
                int soma = 0;

                do
                {
                    soma += i;
                    i++;
                } while (i <= 100);

                Console.WriteLine("Utilizando DO WHILE: " + soma);
            }

            static void Exer10()
            {
                int idade = 0;
                decimal altura = 0m;
                decimal peso = 0m;

                int idadeSuperior = 0;
                decimal mediaAltura = 0m;
                int mediaAlturaQtde = 0;
                int pessoasPesoInferior = 0;
                

                for(int i = 0; i<5; i++)
                {

                    Console.WriteLine("Digite a idade da pessoa:");
                    idade = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite a altura da pessoa:");
                    altura = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Digite o peso da pessoa:");
                    peso = Convert.ToDecimal(Console.ReadLine());

                    if (idade > 50)
                    {
                        idadeSuperior++;
                    }

                    if (idade >= 10 && idade <= 20)
                    {
                        mediaAltura += altura;
                        mediaAlturaQtde++;
                    }

                    if(peso <= 40)
                    {
                        pessoasPesoInferior++;
                    }
                }

                Console.WriteLine("Quantidade de pessoas com idade maior que 50: " + idadeSuperior);
                Console.WriteLine("Media de alturas entre 10 a 20 anos: " + (mediaAltura / mediaAlturaQtde));
                Console.WriteLine("Porcentagem de pessoas com peso inferior a 40: " + ((pessoasPesoInferior * 100) / 5));

                Console.ReadLine();
            }
        }
    }
}
