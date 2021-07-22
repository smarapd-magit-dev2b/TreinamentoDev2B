using Aula5.Exemplos;
using Aula5.Exercicios;
using Common.Classes;
using Common.Interfaces;

namespace Aula5
{
    public class Listas : IExecute
    {
        public void Execute()
        {
            var menu = new Menu("Listas");

            menu.Add(new Exemplo1());
            menu.Add(new Exemplo2());
            menu.Add(new Exercicio1());
            menu.Add(new Exercicio2());
            menu.Add(new Exercicio3());
            menu.Add(new Exercicio4());

            menu.Execute();
        }
    }
}
