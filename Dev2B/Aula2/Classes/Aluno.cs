using System;

namespace Aula02.Exercicio04 {
    public class Aluno {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereço { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Nascionalidade { get; set; }
        public String Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime DataMatricula { get; set; }
        public long RA { get; set; }
        public Professor Professor { get; set; }

        public Aluno() {
            Professor = new Professor();
        }
    }
}
