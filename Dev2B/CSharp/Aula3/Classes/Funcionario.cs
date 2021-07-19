using System;

namespace Aula3.Classes
{
    public class Funcionario : PessoaFisica
    {
        public string Rg { get; set; }
        public string Cnh { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        public override string ToString() =>
            "\nFuncionário\n\n" +
            base.ToString() +
            $"RG: {Rg}\n" +
            $"CNH: {Cnh}\n" +
            $"Salário: {Salario}\n" +
            $"Data de Admissão: {DataAdmissao:dd/MM/yyyy}";
    }
}
