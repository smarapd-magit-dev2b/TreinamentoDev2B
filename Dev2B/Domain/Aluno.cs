using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Aluno
    {
        public string Nome { get; set; }
        public Data DataNascimento { get; set; }
        public string Endereco { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Nacionalidade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Data DataMatricula { get; set; }
        public int Ra { get; set; }
        public Professor Professor { get; set; }
        public Aluno()
        {
            DataNascimento = new Data();
            DataMatricula = new Data();
            Professor = new Professor();
        }
    }
}
