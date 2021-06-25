using System;

namespace Aula02.Exercicio04 {
    public class Professor {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereço { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Nascionalidade { get; set; }
        public String Cidade { get; set; }
        public string Estado { get; set; }
        public long CNH { get; set; }
        public DateTime DataAdimissao { get; set; }
        public int RegistroProfessor { get; set; }
        public decimal Salario { get; set; }
        public Disciplina Disciplina { get; set; }

        public Professor() {
            Disciplina = new Disciplina();

        }
    }
}
