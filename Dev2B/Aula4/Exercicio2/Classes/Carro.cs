using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4.Exercicio2.Classes
{
    public class Carro
    {
        public int Id { get; private set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public int AnoFabricacao { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadePortas { get; set; }
        public decimal Kilometragem { get; set; }

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
            Preco = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de portas do carro");
            QuantidadePortas = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a kilometragem do carro");
            Kilometragem = Decimal.Parse(Console.ReadLine());

        }
    }
}
