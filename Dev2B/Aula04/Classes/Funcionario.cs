using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.Classes
{
    public class Funcionario : PessoaFisica
    {
        public string Cnh { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        public Funcionario(string nome, string endereco, string telefone, string celular, string rg, string cpf, int qntFilhos
             , string estadoCivil, decimal salario, string cnh, DateTime dataAdmissao)
             : base(nome, endereco, telefone, celular, rg, cpf, qntFilhos, estadoCivil)
        {
            Salario = salario;
            Cnh = cnh;
            DataAdmissao = dataAdmissao;
        }

    }
}
