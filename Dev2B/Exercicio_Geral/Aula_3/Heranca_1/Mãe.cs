using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_3.Exercicio_1
{
    public class Mãe
    {
        public string Nome { get; set; }

        public string Endereço { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        //Construtor-------------------------

        public Mãe(string nome, string endereço, string telefone)
        {
            Nome = nome;
            Endereço = endereço;
            Telefone = telefone;

        }

        //Metodo----------------------------

        public void Escreverinformacoes1()
        {
            Console.WriteLine(Nome);
            Console.WriteLine(Endereço);
            Console.WriteLine(Telefone);


        }



    }
}
