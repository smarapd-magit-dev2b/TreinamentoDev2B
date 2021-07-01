using System;
using System.Collections;


namespace Aula4.ClassesExe01 {
    class Pessoa {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Salario { get; set; }
        public int QntFilhos { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }

        public override string ToString() {
            return $"Nome: {Nome}\nTelefone: {Telefone}\nData de Nascimento: {DataNascimento.ToString("dd/MM/yyyy")}\nSalário: {Salario}\nQuantidade de filhos: {QntFilhos}\n" +
                   $"Altura: {Altura}\nPeso: {Peso}\nNome do Pai: {NomePai}\nNome da Mãe: {NomeMae}\n\n";
        }


    }
}
