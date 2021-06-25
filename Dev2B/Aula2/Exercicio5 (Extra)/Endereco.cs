using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Exercicio5__Extra_
{
    class Endereco
    {
        public Endereco()
        {
            Console.WriteLine("Digite os dados de endereço:");
            Console.WriteLine("Rua: ");
            Rua = Console.ReadLine();
            Console.WriteLine("Bairro: ");
            Bairro = Console.ReadLine();
            Console.WriteLine("Cidade: ");
            Cidade = Console.ReadLine();
            Console.WriteLine("Estado: ");
            Estado = Console.ReadLine();
            Console.WriteLine("Cep: ");
            Cep = Console.ReadLine();
            Console.WriteLine("Complemento: ");
            Complemento = Console.ReadLine();
        }

        private string Rua { get; set; }
        private string Bairro { get; set; }
        private string Cidade { get; set; }
        private string Estado { get; set; }
        private string Cep { get; set; }
        private string Complemento { get; set; }
        

    }
}
