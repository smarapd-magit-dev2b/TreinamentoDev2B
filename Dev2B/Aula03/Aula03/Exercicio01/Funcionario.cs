using System;

namespace Aula03.Exercicio01 {
    class Funcionario : Pessoa {
        public int RG { get; set; }
        public int CNH { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string EstadoCivil { get; set; }
    }
}
