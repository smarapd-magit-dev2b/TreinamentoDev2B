using System;

namespace Aula4.Exercicio1.Classes
{
    public class Pessoa
    {
        public Pessoa()
        {
            Console.WriteLine("Informe o nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("Informe o Telefone:");
            Telefone = Console.ReadLine();
            Console.WriteLine("Informe a data de nascimento:");
            DataNascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Salario:");
            Salario = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe a QuantidadeFilhos:");
            QuantidadeFilhos = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a Altura:");
            Altura = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Nome de Pai:");
            NomePai = Console.ReadLine();
            Console.WriteLine("Informe o Nome da Mae:");
            NomeMae = Console.ReadLine();
        }

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Salario { get; set; }
        public int QuantidadeFilhos { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
    }
}