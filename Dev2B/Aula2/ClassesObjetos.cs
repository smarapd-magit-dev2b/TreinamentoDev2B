using Domain.Classes;
using Domain.Interfaces;

namespace Aula2
{
    public class ClassesObjetos : IExecute
    {
        public void Cadastrar()
        {
            var menu = new Menu("Exercícios de Classes e Objetos");

            menu.AddItem(new Exercicio1());
            menu.AddItem(new Exercicio2());
            menu.AddItem(new Exercicio3());
            menu.AddItem(new Exercicio4());

            menu.Cadastrar();
        }
    }
}
