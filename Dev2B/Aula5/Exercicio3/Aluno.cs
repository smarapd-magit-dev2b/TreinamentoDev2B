using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Exercicio3
{
    class Aluno
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string Ra { get; set; }
        public DateTime DataNascimento { get; set; }

        public Aluno()
        {
            Console.WriteLine("Digite o id: ");
            Id = Console.ReadLine();
            Console.WriteLine("Digite o nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Digita a idade: ");
            Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome do pai: ");
            NomePai = Console.ReadLine();
            Console.WriteLine("Digite o nome da mae: ");
            NomeMae = Console.ReadLine();
            Console.WriteLine("Digite o RA: ");
            Ra = Console.ReadLine();
            Console.WriteLine("Digite a data de nascimento: ");
            DataNascimento = Convert.ToDateTime(Console.ReadLine());

        }
    }
}
