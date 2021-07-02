using Aula6.Exemplos;
using Aula6.Exercicios;
using Domain.Classes;
using Domain.Interfaces;

namespace Aula6
{
    public class Lambda : IExecute
    {
        public void Execute()
        {
            Menu menu = new Menu("Lambda");

            menu.AddItem(new Exemplo1());
            menu.AddItem(new Exercicio1());

            menu.Execute();
        }
    }
}
