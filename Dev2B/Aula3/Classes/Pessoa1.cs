using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Classes
{
    public abstract class Pessoa1
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        public Pessoa1(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }
        public void EscreverInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"Telefone: {Telefone}");
        }
    }
}
