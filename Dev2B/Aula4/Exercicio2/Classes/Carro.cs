using System;

namespace Aula4.Exercicio2.Classes
{
    public class Carro
    {
        public Carro(int id)
        {
            Id = id;
            Console.WriteLine("Informe a marca do carro");
            Marca = Console.ReadLine();
            Console.WriteLine("Informe a cor do carro");
            Cor = Console.ReadLine();
            Console.WriteLine("Informe o ano de fabricação do carro");
            AnoFabricacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o preço do carro");
            Preco = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de portas do carro");
            QuantidadePortas = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a kilometragem do carro");
            Kilometragem = decimal.Parse(Console.ReadLine());
        }

        public int Id { get; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public int AnoFabricacao { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadePortas { get; set; }
        public decimal Kilometragem { get; set; }
    }
}