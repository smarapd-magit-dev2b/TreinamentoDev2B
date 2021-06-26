using Domain;
using System;

namespace Aula2
{
    public class ClassesObjetos : IExecute
    {
        public void Execute()
        {
            var menu = new Menu("Exercícios de Classes e Objetos");

            menu.AddItem(new Exercicio1());
            menu.AddItem(new Exercicio1());
            menu.AddItem(new Exercicio1());
            menu.AddItem(new Exercicio1());

            menu.Execute();
        }
    }
}
