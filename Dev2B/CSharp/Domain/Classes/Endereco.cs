using System;

namespace Common.Classes
{
    public class Endereco
    {
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public void Imprimir() => Console.WriteLine($"Endereço\n\nCidade: {Cidade}\nEstado{Estado}\n");
    }
}
