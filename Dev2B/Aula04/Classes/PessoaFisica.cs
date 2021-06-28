using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.Classes
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public int QuantidadeFilhos { get; set; }
        public string EstadoCivil { get; set; }

        public PessoaFisica(string nome, string endereco, string telefone, string celular, string rg, string cpf, int qntFilhos, string estadoCivil) :
            base(nome, telefone, celular, endereco)
        {
            Rg = rg;
            Cpf = cpf;
            QuantidadeFilhos = qntFilhos;
            EstadoCivil = estadoCivil;
        }

    }
}
