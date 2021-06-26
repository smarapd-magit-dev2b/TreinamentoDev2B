using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Menu
    {
        public string Title { get; set; }
        private List<IExecute> ItemsExecute { get; set; }
        private List<string> ItemsString { get; set; }

        public Menu(string title)
        {
            Title = title;
            ItemsString = new List<String>();
        }

        public void AddItem(IExecute item)
        {
            if (ItemsExecute == null)
                ItemsExecute = new List<IExecute>();
            ItemsExecute.Add(item);
        }

        public void AddItem(string item)
        {
            if (ItemsString == null)
                ItemsString = new List<string>();
            ItemsString.Add(item);
        }

        public void Execute()
        {
            bool run = true;
            do
            {
                PrintExecute();
                Console.Write("Digite o número que deseja executar: ");
                try
                {
                    var escolha = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (escolha != 0)
                        ItemsExecute[escolha - 1].Execute();
                    else
                        run = false;
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas números!\n");
                }
            } while (run);
        }

        private void PrintExecute()
        {
            Console.WriteLine($"{Title}\n");

            for (int i = 0; i < ItemsExecute.Count; i++)
                Console.WriteLine($"{i + 1} - {ItemsExecute[i].GetType().Name}");

            Console.WriteLine("0 - Sair\n");
        }
        public void PrintString()
        {
            Console.WriteLine($"{Title}\n");

            for (int i = 0; i < ItemsString.Count; i++)
                Console.WriteLine($"{i + 1} - {ItemsString[i]}");

            Console.WriteLine("0 - Sair\n");
        }
    }
}
