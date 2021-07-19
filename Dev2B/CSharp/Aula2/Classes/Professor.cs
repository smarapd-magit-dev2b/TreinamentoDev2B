using System;

namespace Aula2.Classes
{
    public class Professor
    {
        public int Registro { get; set; }
        public DateTime DataNascimento { get; set; }
        public Disciplina Disciplina { get; set; }
        public Data DataAdmissao { get; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Nacionalidade { get; set; }
        public string Cnh { get; set; }
        public decimal Salario { get; set; }

        public Professor()
        {
            DataNascimento = new DateTime();
            Disciplina = new Disciplina();
            DataAdmissao = new Data();
            Endereco = new Endereco();
        }

        public override string ToString() =>
           "\nProfessor\n\n" +
            $"Nome: {Nome}" +
            $"Data de nascimento: {DataNascimento}\n" +
            $"Telefone: {Telefone}\n" +
            $"Email: {Email}\n" +
            $"Nacionalidade: {Nacionalidade}\n" +
            $"CNH: {Cnh}\n" +
            $"Data de admissão: {DataAdmissao.ToUserString()}\n" +
            $"Registro: {Registro}\n" +
            $"Salario: R${Salario}\n" +
            $"{Endereco}\n" +
            Disciplina;
    }
}
