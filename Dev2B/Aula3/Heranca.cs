using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3
{
    public class Heranca
    {
        public void Execute()
        {
            Menu menu = new Menu("Herança");
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
        private void Ex1()
        {

        }
    }
}
