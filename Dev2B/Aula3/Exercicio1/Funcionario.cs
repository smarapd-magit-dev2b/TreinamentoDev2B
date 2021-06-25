using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio1
{
    class Funcionario : Pessoa
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Cnh { get; set; }
        public int QtdFilhos { get; set; }
        public string EstadoCivil { get; set; }
        public int Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
}
