using Common.Interfaces;
using Common.Classes;
using Aula6.Classes;

namespace Aula7.Exercicios
{
    public class Exercicio2 : IExecute
    {
        public void Execute()
        {
            WriteTree.PropriedadesNumArquivo(Pessoas.Lista, "Lista de Pessoas");
        }
    }
}
