using Domain;
using System;

namespace Aula3
{
    public class ClasseAbstrataInterface
    {
        public void Execute()
        {
            Menu menu = new Menu("Exercícios de Classes Abstratas e Interfaces");
            menu.AddItem("Exercício 1");
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
                            Ex1();
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
        private static void Ex1()
        {

        }
    }
}
