using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exercicio4
{
    public class Aluno
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
        public DateTime DataMatricula { get; set; }
        public int RA { get; set; }
        public Professor Professor { get; set; }

        public Aluno()
        {
            Professor = new Professor();
        }
    }
}
