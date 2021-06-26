using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Menu
    {
        public string Title { get; set; }
        public List<IExecute> Items { get; set; }

        public Menu(string title)
        {
            Title = title;
            Items = new List<IExecute>();
        }

        public void AddItem(IExecute item)
        {
            Items.Add(item);
        }

        public void Execute()
        {
            bool run = true;
            do
            {
                Print();
                Console.Write("Digite o número que deseja executar: ");
                try
                {
                    var escolha = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (escolha != 0)
                        Items[escolha - 1].Execute();
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

        private void Print()
        {
            Console.WriteLine($"{Title}\n");

            for (int i = 0; i < Items.Count; i++)
                Console.WriteLine($"{i + 1} - {Items[i].GetType().Name}");

            Console.WriteLine("0 - Sair\n");
        }
    }
}
