using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio1HerancaClasses
{
    public class Fornecedor : Pessoa
    {
        public string Cnpj { get; set; }
        public string Segmento { get; set; }
        public string Produto { get; set; }

        public Fornecedor(string nome, string endereco, string telefone)
            : base(nome, endereco, telefone)
        {

        }
    }
}
