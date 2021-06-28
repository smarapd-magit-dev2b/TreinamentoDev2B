using System;

namespace Aula2.Classes.ClassesDes01 {
    public class Proprietario {
        private string Nome { get; set; }
        private int CPF { get; set; }
        private int RG { get; set; }
        private DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }

        public Proprietario() {
            Endereco = new Endereco();
        }
        public Proprietario(string nome, int cpf) {
            Nome = nome;
            CPF = cpf;
        }
    }
}
