using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Exercicio1
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Salario { get; set; }
        public int QtdFilhos { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }

        public Pessoa()
        {
            Console.WriteLine("Digite o nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite o telefone: ");
            Telefone = Console.ReadLine();
            Console.WriteLine("Digita a data de nascimento: ");
            DataNascimento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite o salario: ");
            Salario = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de filhos: ");
            QtdFilhos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a altura: ");
            Altura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o peso: ");
            Peso = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o nome do pai: ");
            NomePai = Console.ReadLine();
            Console.WriteLine("Digite o nome da mae: ");
            NomeMae = Console.ReadLine();
        }
    }
}
