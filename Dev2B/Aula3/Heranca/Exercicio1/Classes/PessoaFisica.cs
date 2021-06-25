using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3.Domain
{
    public abstract class PessoaFisica : Pessoa
    {
        public PessoaFisica(string nome, string endereco, string telefone, string celular, string rg, string cpf, int qntFilhos, string estadoCivil) : base(nome, endereco, telefone, celular)
        {
            RG = rg;
            CPF = cpf;
            QuantidadeFilhos = qntFilhos;
            EstadoCivil = estadoCivil;
        }

        public string RG { get; set; }
        public string CPF { get; set; }
        public int QuantidadeFilhos { get; set; }
        public string EstadoCivil { get; set; }

       
    }
}
