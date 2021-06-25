using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Menu
    {
        public string Title { get; set; }
        public List<string> Items { get; set; }
        public Menu(string title)
        {
            Title = title;
            Items = new List<string>();
        }
        public void AddItem(string item)
        {
            Items.Add(item);
        }
        public void Print()
        {
            Console.WriteLine($"{Title}\n");
            for(int i = 0; i < Items.Count; i++)
                Console.WriteLine($"{i + 1} - {Items[i]}");
            Console.WriteLine("0 - Sair\n");
        }
    }
}
