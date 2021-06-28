using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.Classes
{
    class Cliente : PessoaFisica
    {
        
        public Cliente(string nome, string endereco, string telefone, string celular, string rg, string cpf, int qntFilhos, string estadoCivil) 
            : base(nome, endereco, telefone, celular, rg, cpf, qntFilhos, estadoCivil)
        {
        }
        
    }
}
