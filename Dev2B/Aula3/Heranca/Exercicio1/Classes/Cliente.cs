using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3.Domain
{
    public class Cliente : PessoaFisica
    {
        public Cliente(string nome, string endereco, string telefone, string celular, string rg, string cpf, int qntFilhos, string estadoCivil) : base(nome, endereco, telefone, celular, rg, cpf, qntFilhos, estadoCivil)
        {
        }

       
    }
}