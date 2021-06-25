using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio2HerancaClasses
{
    public abstract class Veiculo
    {
        public string Cor { get; set; }
        public decimal VelocidadeMaxima { get; set; }
        public string TipoCombustivel { get; set; }
        public string Marca { get; set; }
        public int QntMaximaPassageiros { get; set; }
        public int QntRodas { get; set; }

        public Veiculo(string marca, string cor, decimal velocidadeMaxima, string tipoCombustivel, int qntMaximaPassageiros, int qntRodas)
        {
            Marca = marca;
            Cor = cor;
            VelocidadeMaxima = velocidadeMaxima;
            TipoCombustivel = tipoCombustivel;
            QntMaximaPassageiros = qntMaximaPassageiros;
            QntRodas = qntRodas;
        }

        public void EscreverInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Cor: {Cor}");
            Console.WriteLine($"Velocidade máxima: {VelocidadeMaxima}Km/h");
            Console.WriteLine($"Tipo combustível: {TipoCombustivel}");
            Console.WriteLine($"Quantidade máxima de passageiros: {QntMaximaPassageiros}");
            Console.WriteLine($"Quantidade de rodas: {QntRodas}");
            Console.WriteLine();
        }
    }
}
