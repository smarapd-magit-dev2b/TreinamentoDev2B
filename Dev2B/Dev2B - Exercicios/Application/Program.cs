
using Aluno;
using Aula1;
using Aula2;
using Aula3;
using Aula4;
using Lambdas;
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            EnumMain escolha;
            string resposta;

            Console.WriteLine("EXERCICIOS!");
            Estrutura estrutura = new Estrutura();
            ClassesObjetos classes = new ClassesObjetos();
            AbstractInterface abs = new AbstractInterface();
            Exercicio1Interface inter = new Exercicio1Interface();
            Listas lista = new Listas();
            Lambda lamb = new Lambda();

            do
            {
                Console.WriteLine("1) Exercicios de estruturas.\n2) Exercicios de classes.\n3) Exercicios com classes abstratas.\n" +
                    "4) Exercicios com interface.\n5) Exercicios de lista.\n6) Exercicios com lambda.\n");

                Console.WriteLine("Opção: ");
                escolha = (EnumMain)Enum.Parse(typeof(EnumMain), Console.ReadLine());

                switch (escolha)
                {
                    case EnumMain.ExerciciosEstrutura:
                        {
                            estrutura.Execute();
                            break;
                        }
                    case EnumMain.ExerciciosClasses:
                        {
                            classes.Execute();
                            break;
                        }
                    case EnumMain.ExerciciosClassesAbstratas:
                        {
                            abs.Execute();
                            break;
                        }
                    case EnumMain.ExerciciosInterface:
                        {
                            inter.Execute();
                            break;
                        }
                    case EnumMain.ExerciciosLista:
                        {
                            lista.Execute();
                            break;
                        }
                    case EnumMain.ExerciciosLambda:
                        {
                            lamb.Execute();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opção invalida...");
                            break;
                        }
                }

                Console.WriteLine("Deseja verificar outro bloco de exercicios?");
                resposta = Console.ReadLine();
            } while (resposta != "nao");
        }
    }
}
