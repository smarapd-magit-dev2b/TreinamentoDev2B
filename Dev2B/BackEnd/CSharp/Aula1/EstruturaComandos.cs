using Aula1.Exercicios;
using Common.Classes;
using Common.Interfaces;

namespace Aula1
{
    public class EstruturaComandos : IExecute
    {
        public void Execute()
        {
            var menu = new Menu("Exercícios de Estrutura de Comandos");

            menu.Add(new Exercicio1());
            menu.Add(new Exercicio2());
            menu.Add(new Exercicio3());
            menu.Add(new Exercicios4());
            menu.Add(new Exercicios5());
            menu.Add(new Exercicios6());
            menu.Add(new Exercicios7());
            menu.Add(new Exercicios8());
            menu.Add(new Exercicio9());
            menu.Add(new Exercicio10());

            menu.Execute();
        }
    }
}
