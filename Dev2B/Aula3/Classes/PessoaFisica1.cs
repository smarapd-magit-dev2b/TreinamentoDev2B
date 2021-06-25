using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Classes
{
    public abstract class PessoaFisica1 : Pessoa1
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public int QtdFilhos { get; set; }
        public string EstadoCivil { get; set; }

        public PessoaFisica1(string nome, string endereco, string telefone, string cpf)
            : base(nome, endereco, telefone)
        {
            Cpf = cpf;
        }
    }
}
