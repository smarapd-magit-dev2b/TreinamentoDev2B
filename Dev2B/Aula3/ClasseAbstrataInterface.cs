using Aula3.Exercicios;
using Aula3.Exercicios.ClasseAbstrataInterface;
using Domain.Classes;
using Domain.Interfaces;

namespace Aula3
{
    public class ClasseAbstrataInterface : IExecute
    {
        public void Cadastrar()
        {
            var menu = new Menu("Exercícios de Classes Abstratas e Interfaces");

            menu.AddItem(new Exercicio1());
            menu.AddItem(new Exercicio2());

            menu.Cadastrar();
        }
    }
}
