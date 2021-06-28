using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.Classes
{
    public abstract class Veiculo
    {
        public string Cor { get; set; }
        public decimal ValocidadeMaxima { get; set; }
        public string TipoCombustivel { get; set; }
        public string Marca { get; set; }
        public int QuantidadeMaxPassageiros { get; set; }
        public int QuantidadeRodas { get; set; }

        public Veiculo(string cor, decimal valocidadeMaxima, string tipoCombustivel, string marca, int quantidadeMaxPassageiros, int quantidadeRodas)
        {
            Cor = cor;
            ValocidadeMaxima = valocidadeMaxima;
            TipoCombustivel = tipoCombustivel;
            Marca = marca;
            QuantidadeMaxPassageiros = quantidadeMaxPassageiros;
            QuantidadeRodas = quantidadeRodas;
        }

        public void EscreverDadosComuns()
        {
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"\nValocidade Maxima: {ValocidadeMaxima}");
            Console.WriteLine($"\nTipo de Combustivel: {TipoCombustivel}");
            Console.WriteLine($"\nMarca: {Marca}");
            Console.WriteLine($"\nQuantidade Maxima de Passageiros: {QuantidadeMaxPassageiros}");
            Console.WriteLine($"\nQuantidade de Rodas: {QuantidadeRodas}");
        }

        public abstract void EscreverDadosEspecificos();
    }
}
