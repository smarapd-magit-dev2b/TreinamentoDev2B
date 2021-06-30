using Aula3.Exercicios.Heranca;
using Domain.Classes;
using Domain.Interfaces;

namespace Aula3
{
    public class Heranca : IExecute
    {
        public void Execute()
        {
            Menu menu = new Menu("Herança");

            menu.AddItem(new Exercicio1());
            menu.AddItem(new Exercicio2());

            menu.Execute();
        }
    }
}
