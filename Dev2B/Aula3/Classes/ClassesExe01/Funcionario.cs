using System;

namespace Aula3.Classes.ClassesExe01 {
    public class Funcionario : Pessoa {
        public int CPF { get; set; }
        public int RG { get; set; }
        public int CNH { get; set; }
        public int QntFilhos { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime DataAdimissao { get; set; }
        public decimal Salario { get; set; }

        public Funcionario(string nome, string endereco, int telefone, int rg, int cpf, int qntfilhos, string estadocivil, DateTime dataadmissao, decimal salario)
            : base(nome, endereco, telefone) {
            RG = rg;
            CPF = cpf;
            QntFilhos = qntfilhos;
            EstadoCivil = estadocivil;
            DataAdimissao = dataadmissao;
            Salario = salario;
        }
    }
}
