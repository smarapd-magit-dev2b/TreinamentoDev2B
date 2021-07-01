using System;
using System.Collections;


namespace Aula4.ClassesExe01 {
    public class Aluno {
        public string ID { get; set; }
        public string Nome { get; set; }
        public string Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public int RA { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }

        public override string ToString() {
            return $"ID: {ID}\nNome: {Nome}\nData de Nascimento: {DataNascimento.ToString("dd/MM/yyyy")}" +
                   $"\nRA: {RA}\nNome do Pai: {NomePai}\nNome da Mãe: {NomeMae}\n";
        }


    }
}

