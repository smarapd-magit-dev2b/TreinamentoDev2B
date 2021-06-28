using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.Classes
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Endereco { get; set; }


        public Pessoa(string nome, string telefone, string celular, string endereco)
        {
            Nome = nome;
            Telefone = telefone;
            Celular = celular;
            Endereco = endereco;
        }       

        public void EscreverInformacoes()
        {
            Console.WriteLine(Nome);
            Console.WriteLine(Endereco);
            Console.WriteLine(Telefone);
        }

    }
}
