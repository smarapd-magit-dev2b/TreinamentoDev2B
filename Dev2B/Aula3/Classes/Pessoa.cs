using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Domain
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Pessoa(string nome, string telefone, string endereco)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }

        public abstract void EscreverInformacoes();
    }
}
