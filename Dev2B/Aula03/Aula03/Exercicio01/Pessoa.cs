using System;

namespace Aula03.Exercicio01 {
    public abstract class Pessoa {
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public int Celular { get; set; }

        public Pessoa(string nome, int telefone) {
            Nome = nome;
            Telefone = telefone;
        }

        public abstract void EscreverInformacoes();
    }
}
