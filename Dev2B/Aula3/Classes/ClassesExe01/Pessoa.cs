using System;

namespace Aula3.Classes.ClassesExe01 {
    public abstract class Pessoa {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Telefone { get; set; }
        public int Celular { get; set; }

        public Pessoa(string nome, string endereco, int telefone) {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public void MostrarInformacoes() {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Telefone: " + Telefone);
            Console.WriteLine("Endereço: " + Endereco);
        }

    }
}
