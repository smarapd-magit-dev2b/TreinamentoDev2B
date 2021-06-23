using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Exercicio4
{
    class Professor
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Nacionalidade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cnh { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string RegistroProfessor { get; set; }
        public decimal Salario { get; set; }
        public Disciplina Disciplina { get; set; }

        public Professor(string nome, DateTime dataNascimento, string endereco, string telefone, string email, string nacionalidade, string cidade, string estado, string cnh, DateTime dataAdmissao, string registroProfessor, decimal salario)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            Nacionalidade = nacionalidade;
            Cidade = cidade;
            Estado = estado;
            Cnh = cnh;
            DataAdmissao = dataAdmissao;
            RegistroProfessor = registroProfessor;
            Salario = salario;
            Disciplina = new Disciplina();
        }

        public Professor()
        {
        }
    }
}
