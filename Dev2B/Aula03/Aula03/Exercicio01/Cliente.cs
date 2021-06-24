using System;

namespace Aula03.Exercicio01 {
    public class Cliente : Pessoa {
      
        public long CPF { get; set; }
        public long RG { get; set; }
        public int QntFilhos { get; set; }
        public string EstadoCivil { get; set; }

        public Cliente(string nome, int telefone) : base(nome, telefone){

        }
    }
}
