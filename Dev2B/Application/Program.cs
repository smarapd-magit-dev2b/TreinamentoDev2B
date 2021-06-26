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
            if (args is null)
                throw new ArgumentNullException(nameof(args));

            Menu menu = new Menu("Aulas");
            menu.AddItem(new EstruturaComandos());
            menu.AddItem(new ClassesObjetos());
            menu.AddItem(new Heranca());
            menu.AddItem(new ClasseAbstrataInterface());
            menu.Execute();
        }
    }
}
