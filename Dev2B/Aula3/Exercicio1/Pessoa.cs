using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio1
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        public void MostrarNaTela(string nome, string cpf_cnpj, string rg, string endereco)
        {
            Console.WriteLine(nome);
            Console.WriteLine(cpf_cnpj);
            Console.WriteLine(cpf_cnpj);
            Console.WriteLine(endereco);
        }
    }
}
