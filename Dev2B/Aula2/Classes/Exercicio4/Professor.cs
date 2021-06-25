using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Professor
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Nacionalidade { get; set; }
        public string CNH { get; set; }
        public DateTime DataAdimicao { get; set; }
        public string RegistroProfessor { get; set; }
        public decimal Salario { get; set; }
        public Disciplina Disciplina { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }

        public Professor()
        {
            Disciplina = new Disciplina();
            Endereco = new Endereco();
        }

        public Professor(string nome, DateTime dataNascimento, string email, 
            string nacionalidade, string cNH, DateTime dataAdimicao, 
            string registroProfessor, decimal salario, Disciplina disciplina, string telefone, Endereco endereco)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Email = email;
            Nacionalidade = nacionalidade;
            CNH = cNH;
            DataAdimicao = dataAdimicao;
            RegistroProfessor = registroProfessor;
            Salario = salario;
            Disciplina = disciplina;
            Telefone = telefone;
            Endereco = endereco;
        }
    }
}
