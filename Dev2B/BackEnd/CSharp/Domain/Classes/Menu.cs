using Common.Interfaces;
using System;
using System.Collections.Generic;

namespace Common.Classes
{
    public class Menu
    {
        private const string Digite = "Digite o número que deseja executar: ";
        private const string Sair = "0 - Sair\n\n";
        private string Title { get; set; }
        private List<string> ItemsString { get; set; }
        private List<IExecute> ItemsExecute { get; set; }

        public Menu(string title)
        {
            Title = $"\n{title}\n";
        }

        public void Add(string item)
        {
            if (ItemsString == null)
                ItemsString = new List<string>();
            ItemsString.Add(item);
        }

        public void Add(IExecute item)
        {
            if (ItemsExecute == null)
                ItemsExecute = new List<IExecute>();
            ItemsExecute.Add(item);
        }

        public void Execute()
        {
            var run = true;
            do
            {
                WriteExecute();
                Console.Write(Digite);
                try
                {
                    var escolha = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (escolha == 0) run = false;
                    else if (escolha > ItemsExecute.Count)
                        Console.WriteLine($"{escolha} não está na lista!");
                    else ItemsExecute[escolha - 1].Execute();
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas números!");
                }
            } while (run);
        }

        public void WriteString()
        {
            Console.WriteLine($"{Title}");

            for (int i = 0; i < ItemsString.Count; i++)
                Console.WriteLine($"{i + 1} - {ItemsString[i]}");

            Console.Write(Sair + Digite);
        }

        private void WriteExecute()
        {
            Console.WriteLine($"{Title}");

            for (int i = 0; i < ItemsExecute.Count; i++)
                Console.WriteLine($"{i + 1} - {ItemsExecute[i].GetType().Name}");

            Console.Write(Sair);
        }
    }
}
