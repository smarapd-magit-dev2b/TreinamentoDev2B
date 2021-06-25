using Aula1;
using Aula2;
using Aula3;
using Domain;
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu("Aulas");
            menu.AddItem("Estrutura e Comandos");
            menu.AddItem("Classes e Objetos");
            menu.AddItem("Herança");
            menu.AddItem("Classes Abstratas e Interfaces");
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
                            new EstruturaComandos().Execute();
                            break;
                        case 2:
                            Console.Clear();
                            new ClassesObjetos().Execute();
                            break;
                        case 3:
                            Console.Clear();
                            new Heranca().Execute();
                            break;
                        case 4:
                            Console.Clear();
                            new ClasseAbstrataInterface().Execute();
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
    }
}
