using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio1HerancaClasses
{
    public class Funcionario : PessoaFisica
    {
        public string Cnh { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        public Funcionario(string nome, string endereco, string telefone)
            : base(nome, endereco, telefone)
        {

        }
    }
}
