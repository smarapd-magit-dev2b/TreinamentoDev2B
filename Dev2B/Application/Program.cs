using Aula1;
using Aula2;
using Aula3;
using Aula5;
using Aula6;
using Aula7;
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

            menu.Add(new EstruturaComandos());
            menu.Add(new ClassesObjetos());
            menu.Add(new Heranca());
            menu.Add(new ClasseAbstrataInterface());
            menu.Add(new Listas());
            menu.Add(new Lambda());
            menu.Add(new TryCatchEStatic());

            menu.Execute();
        }
    }
}
