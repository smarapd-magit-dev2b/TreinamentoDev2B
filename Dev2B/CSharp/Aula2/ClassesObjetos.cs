using Common.Classes;
using Common.Interfaces;

namespace Aula2
{
    public class ClassesObjetos : IExecute
    {
        public void Execute()
        {
            var menu = new Menu("Exercícios de Classes e Objetos");

            menu.Add(new Exercicio1());
            menu.Add(new Exercicio2());
            menu.Add(new Exercicio3());
            menu.Add(new Exercicio4());

            menu.Execute();
        }
    }
}
