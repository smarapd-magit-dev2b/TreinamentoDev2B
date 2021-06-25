using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio1HerancaClasses
{
    public abstract class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public int QuantidadeFilhos { get; set; }
        public string EstadoCivil { get; set; }

        public PessoaFisica(string nome, string endereco, string telefone)
            : base(nome, endereco, telefone)
        {

        }
    }
}
