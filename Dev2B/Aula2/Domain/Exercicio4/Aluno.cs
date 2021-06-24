using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Aluno
    {
        public string Nome { get; set; }
        public string RA { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Nacionalidade { get; set; }
        public DateTime DataMatricula { get; set; }
        public Endereco Endereco { get; set; }
        public Professor Professor { get; set; }
        public string Telefone { get; set; }

        public Aluno()
        {
            Professor = new Professor();
            Endereco = new Endereco();
        }

        public Aluno(string nome, string rA, DateTime dataNascimento, 
            string email, string nacionalidade, DateTime dataMatricula, 
            Endereco endereco, Professor professor, string telefone)
        {
            Nome = nome;
            RA = rA;
            DataNascimento = dataNascimento;
            Email = email;
            Nacionalidade = nacionalidade;
            DataMatricula = dataMatricula;
            Endereco = endereco;
            Professor = professor;
            Telefone = telefone;
        }
    }
}
