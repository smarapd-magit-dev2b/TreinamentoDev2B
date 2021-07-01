using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Exercicio2
{
    class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public decimal Preco { get; set; }
        public int QtdPortas { get; set; }
        public decimal Kilometragem { get; set; }

        public Carro()
        {
            Console.WriteLine("Digite o Id: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a Marca: ");
            Marca = Console.ReadLine();
            Console.WriteLine("Digita a cor: ");
            Cor = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite o ano de fabricação: ");
            AnoFabricacao = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite o preço: ");
            Preco = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de portas: ");
            QtdPortas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a kilometragem: ");
            Kilometragem = Convert.ToDecimal(Console.ReadLine());
        }
    }
}
