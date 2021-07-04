using Domain.Classes;
using Domain.Interfaces;
using Aula7.Exercicios;

namespace Aula7
{
    public class TryCatchEStatic : IExecute
    {
        public void Execute()
        {
            Menu menu = new Menu("Try/Catch e Static");

            menu.Add(new Exercicio1());
            menu.Add(new Exercicio2());

            menu.Execute();
        }
    }
}
