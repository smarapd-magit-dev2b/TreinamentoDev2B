using System;

namespace Aula2.Classes
{
    public class Aluno
    {
        public DateTime DataNascimento { get; set; }
        public DateTime DataMatricula { get; set; }
        public int Ra { get; set; }
        public Professor Professor { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Nacionalidade { get; set; }

        public Aluno()
        {
            Endereco = new Endereco();
            Professor = new Professor();
        }

        public override string ToString() => 
           "\nAluno\n\n" +
            $"Nome: {Nome}\n" +
            $"Data de nascimento: {DataNascimento}\n" +
            $"Telefone: {Telefone}\n" +
            $"Email: {Email}\n" +
            $"Nacionalidade: {Nacionalidade}\n" +
            $"Data da matrícula: {DataMatricula:dd/MM/yyyy}\n" +
            $"RA: {Ra}\n" +
            $"{Endereco}\n" +
            Professor;
    }
}
