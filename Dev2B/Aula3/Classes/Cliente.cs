using System;
using System.Collections.Generic;
using System.Text;
using Aula3.Classes;

namespace Aula3.Exercicio1
{
    public class Cliente : PessoaFisica1
    {
        public string Profissao { get; set; }

        public Cliente(string nome, string endereco, string telefone, string cpf)
              : base(nome, endereco, telefone, cpf)
        {
            Cpf = cpf;
        }
    }
}
