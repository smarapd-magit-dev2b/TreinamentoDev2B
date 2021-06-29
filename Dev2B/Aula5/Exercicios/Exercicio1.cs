using Domain.Classes;
using Domain.Interfaces;
using Aula5.Classes;

namespace Aula5.Exercicios
{
    public class Exercicio1 : IExecute
    {
        public void Execute()
        {
            Pessoa pessoa = new Pessoa();
            var cadastro = new Cadastro<object>(pessoa);
            cadastro.Cadastrar();
            new Print(pessoa).PrintarPropriedades();
        }
    }
}
