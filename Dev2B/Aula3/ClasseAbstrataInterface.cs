using Aula3.Exercicios;
using Aula3.Exercicios.ClasseAbstrataInterface;
using Domain.Classes;
using Domain.Interfaces;

namespace Aula3
{
    public class ClasseAbstrataInterface : IExecute
    {
        public void Execute()
        {
            var menu = new Menu("Exercícios de Classes Abstratas e Interfaces");

            menu.Add(new Exercicio1());
            menu.Add(new Exercicio2());

            menu.Execute();
        }
    }
}
