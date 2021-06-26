using Aula1.Exercicios;
using Domain.Classes;
using Domain.Interfaces;

namespace Aula1
{
    public class EstruturaComandos : IExecute
    {
        public void Execute()
        {
            var menu = new Menu("Exercícios de Estrutura de Comandos");

            menu.AddItem(new Exercicio1());
            menu.AddItem(new Exercicio2());
            menu.AddItem(new Exercicio3());
            menu.AddItem(new Exercicios4());
            menu.AddItem(new Exercicios5());
            menu.AddItem(new Exercicios6());
            menu.AddItem(new Exercicios7());
            menu.AddItem(new Exercicios8());
            menu.AddItem(new Exercicio9());
            menu.AddItem(new Exercicio10());

            menu.Execute();
        }
    }
}
