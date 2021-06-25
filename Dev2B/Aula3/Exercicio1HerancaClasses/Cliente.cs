using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio1HerancaClasses
{
    public class Cliente : PessoaFisica
    {
        public Cliente(string nome, string endereco, string telefone)
            : base(nome, endereco, telefone)
        {

        }
    }
}
