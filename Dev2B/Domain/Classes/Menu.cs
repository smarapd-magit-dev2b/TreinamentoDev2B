using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Domain.Classes
{
    public class Menu : IExecute
    {
        public string Title { get; set; }
        private List<string> ItemsString { get; set; }
        private List<IExecute> ItemsExecute { get; set; }

        public Menu(string title)
        {
            Title = $"\n{title}\n";
            ItemsString = new List<String>();
        }

        public void AddItem(string item)
        {
            if (ItemsString == null)
                ItemsString = new List<string>();
            ItemsString.Add(item);
        }

        public void AddItem(IExecute item)
        {
            if (ItemsExecute == null)
                ItemsExecute = new List<IExecute>();
            ItemsExecute.Add(item);
        }

        public void Cadastrar()
        {
            var run = true;
            do
            {
                PrintExecute();
                Console.Write("Digite o número que deseja executar: ");
                try
                {
                    var escolha = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (escolha != 0 && escolha <= ItemsExecute.Count)
                        ItemsExecute[escolha - 1].Cadastrar();
                    else if (escolha > ItemsExecute.Count)
                        Console.WriteLine($"{escolha} não está na lista!");
                    else
                        run = false;
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas números!");
                }
            } while (run);
        }

        public void PrintString()
        {
            Console.WriteLine($"{Title}");

            for (int i = 0; i < ItemsString.Count; i++)
                Console.WriteLine($"{i + 1} - {ItemsString[i]}");

            Console.WriteLine("0 - Sair\n");
        }

        private void PrintExecute()
        {
            Console.WriteLine($"{Title}");

            for (int i = 0; i < ItemsExecute.Count; i++)
                Console.WriteLine($"{i + 1} - {ItemsExecute[i].GetType().Name}");

            Console.WriteLine("0 - Sair");
        }
    }
}
