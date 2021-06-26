using Domain.Classes;
using Domain.Interfaces;
using System;

namespace Aula2
{
    public class Exercicio1 : IExecute
    {
        public void Execute()
        {
            Console.Write("Exercício 1\n\n" +
                "Item da Venda\n\n" +
                "Digite o Número do Item: ");
            var numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Nome do Item: ");
            var descricao = Console.ReadLine();

            Console.Write("Digite a Quantidade de compra desse Item: ");
            var qtdCompra = int.Parse(Console.ReadLine());

            Console.Write("Digite o Preço do Item: ");
            var preco = int.Parse(Console.ReadLine());

            var item = new ItemVenda(numero, descricao, qtdCompra, preco);
            Console.WriteLine($"O valor total do Item {item.Numero} ({item.Descricao}) será de R${item.CalcularValorTotal()}");
        }
    }
}
