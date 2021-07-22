using System;

namespace Aula2.Classes
{
    public class Disciplina
    {
        public string Nome { get; set; }
        public int Cid { get; set; }
        public string Curso { get; set; }
        public DateTime DataInclusao { get; set; }

        public Disciplina()
        {
            DataInclusao = new DateTime();
        }

        public override string ToString() =>
           "\nDisciplina\n\n" +
            $"Nome: {Nome}\n" +
            $"CID: {Cid}\n" +
            $"Curso: {Curso}\n" +
            $"Data de inclusão: {DataInclusao}";
    }
}
