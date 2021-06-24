using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exercicio4
{
    public class Professor
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Nacionalidade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CNH { get; set; }
        public DateTime DataAdmissao { get; set; }
        public int RegistroProfessor { get; set; }
        public decimal Salario { get; set; }
        public Disciplina Disciplina { get; set; }

        public Professor()
        {
            Disciplina = new Disciplina();
        }
    }
}
