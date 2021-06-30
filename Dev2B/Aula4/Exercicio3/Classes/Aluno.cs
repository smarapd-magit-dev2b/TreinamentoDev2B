using System;

namespace Aula4.Exercicio3.Classes
{
    public class Aluno
    {
        public Aluno(int id)
        {
            Id = id;
            Console.WriteLine("Nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Nome pai: ");
            NomePai = Console.ReadLine();
            Console.WriteLine("Nome mae: ");
            NomeMae = Console.ReadLine();
            Console.WriteLine("Data Nascimento: ");
            DataNascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("RA: ");
            RA = int.Parse(Console.ReadLine());
        }

        public int Id { get; }
        public string Nome { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public int RA { get; set; }
        public DateTime DataNascimento { get; set; }

        public int Idade
        {
            get
            {
                var idade = DateTime.Now.Year - DataNascimento.Year;
                if (DataNascimento > DateTime.Now.AddYears(-idade)) idade--;
                return idade;
            }
        }

        public void AlunoToString()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Nome pai: {NomePai}");
            Console.WriteLine($"Nome mae: {NomeMae}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Data Nascimento: {DataNascimento.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"RD: {RA}");
        }
    }
}