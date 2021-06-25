using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Exercicio4
{
    class Aluno
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Nacionalidade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime DataMatricula { get; set; }
        public string RegistroAluno { get; set; }
        public Professor Professor { get; set; }

        public Aluno(string nome, DateTime dataNascimento, string endereco, string telefone, string email, string nacionalidade, string cidade, string estado, DateTime dataMatricula, string registroAluno)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            Nacionalidade = nacionalidade;
            Cidade = cidade;
            Estado = estado;
            DataMatricula = dataMatricula;
            RegistroAluno = registroAluno;
            Professor = new Professor();
        }

    }

}
