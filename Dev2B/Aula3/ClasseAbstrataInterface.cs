using Aula3.Exercicios.ClasseAbstrataInterface;
using Domain;

namespace Aula3
{
    public class ClasseAbstrataInterface : IExecute
    {
        public void Execute()
        {
            var menu = new Menu("Exercícios de Classes Abstratas e Interfaces");

            menu.AddItem(new Exercicio1());
            menu.AddItem(new Exercicio2());

            menu.Execute();
        }
    }
}
