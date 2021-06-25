using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3.Domain
{
    public class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(string nome, string endereco, string telefone, string celular, string cnpj) : base(nome, endereco, telefone, celular)
        {
            CNPJ = cnpj;
        }

        public string CNPJ { get; set; }

        
    }
}
