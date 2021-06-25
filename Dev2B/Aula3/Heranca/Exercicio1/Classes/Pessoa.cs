using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3.Domain
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        public Pessoa(string nome, string endereco, string telefone, string celular)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Celular = celular;
        }

        public string InprimirInformacoes()
        {
            return $"Nome: {Nome}\nEndereço: {Endereco}\nTelefone: {Telefone}\nCelular: {Celular}";
        }
    }
}
