using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Exercicio5__Extra_
{
    class Proprietario
    {
        public Proprietario(string nome, string cpf, string rg, Endereco endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Endereco = endereco;
        }

        private string Nome { get; set; }
        private string Cpf { get; set; }
        private DateTime DataNascimento { get; set; }
        private string Rg { get; set; }
        private Endereco Endereco { get; set; }


    }
}
