using Aula5.Exemplos;
using Aula5.Exercicios;
using Domain.Classes;
using Domain.Interfaces;

namespace Aula5
{
    public class Listas : IExecute
    {
        public void Cadastrar()
        {
            var menu = new Menu("Listas");

            menu.AddItem(new Exemplo1());
            menu.AddItem(new Exemplo2());
            menu.AddItem(new Exercicio1());

            menu.Cadastrar();
        }
    }
}
