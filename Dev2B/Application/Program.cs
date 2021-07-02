using Aula1;
using Aula2;
using Aula3;
using Aula5;
using Aula6;
using Domain.Classes;
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
                throw new ArgumentNullException(nameof(args));

            var menu = new Menu("Aulas");

            menu.AddItem(new EstruturaComandos());
            menu.AddItem(new ClassesObjetos());
            menu.AddItem(new Heranca());
            menu.AddItem(new ClasseAbstrataInterface());
            menu.AddItem(new Listas());
            menu.AddItem(new Lambda());

            menu.Execute();
        }
    }
}
