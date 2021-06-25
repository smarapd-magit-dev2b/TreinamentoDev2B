using System;
using System.Collections.Generic;
using System.Text;
using Aula3.Classes;

namespace Aula3.Exercicio1
{
    public class Funcionario : PessoaFisica1
    {
        public string Cnh { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        public Funcionario(string nome, string endereco, string telefone, string cpf)
                : base(nome, endereco, telefone, cpf)
        {
            Cpf = cpf;
        }

    }
}
