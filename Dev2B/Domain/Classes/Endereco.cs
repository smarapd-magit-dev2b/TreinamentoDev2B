using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Endereco
    {
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        internal void Imprimir()
        {
            Console.WriteLine($"Endereço\n\nCidade: {Cidade}\nEstado{Estado}");
        }
    }
}
