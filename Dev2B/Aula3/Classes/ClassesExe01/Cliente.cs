using System;

namespace Aula3.Classes.ClassesExe01 {
    public class Cliente : Pessoa {
        public int RG { get; set; }
        public int CPF { get; set; }
        public int QntFilhos { get; set; }
        public string EstadoCivil { get; set; }

        public Cliente(string nome, string endereco, int telefone, int rg, int cpf, int qntfilhos, string estadocivil)
            : base(nome, endereco, telefone) {
            RG = rg;
            CPF = cpf;
            QntFilhos = qntfilhos;
            EstadoCivil = estadocivil;
        }
    }
}
