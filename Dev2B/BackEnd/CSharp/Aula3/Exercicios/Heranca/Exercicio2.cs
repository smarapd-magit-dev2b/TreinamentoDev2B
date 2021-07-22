using Aula3.Classes;
using Common.Interfaces;
using System;

namespace Aula3.Exercicios.Heranca
{
    public class Exercicio2 : IExecute
    {
        public void Execute()
        {
            Aviao aviao = new Aviao()
            {
                Cor = "Cinza",
                QuantidadeAcentos = 300,
                Marca = "Venus",
                Porte = "Grande",
                QuantidadeMaximaPassageiros = 340,
                QuantidadePilotos = 3,
                QuantidadeRodas = 3,
                TipoCombustivel = "A Gás",
                VelocidadeMaxima = 15
            };

            Console.WriteLine(aviao);

            Carro carro = new Carro()
            {
                Cor = "Marrom",
                Marca = "Renö",
                QuantidadeMaximaPassageiros = 5,
                QuantidadeRodas = 4,
                TipoCombustivel = "Óleo de Cozinha",
                VelocidadeMaxima = 3000,
                PossuiStep = true,
                PossuiTracaoTraseira = false,
                QuantidadePortas = 5
            };

            Console.WriteLine(carro);

            Moto moto = new Moto() {
                Cor = "Rosa",
                Marca = "Remo",
                QuantidadeMaximaPassageiros = 9,
                QuantidadeRodas = 3,
                TipoCombustivel = "Urânio",
                VelocidadeMaxima = 2,
                PossuiCarenagem = false
            };

            Console.WriteLine(moto);
        }
    }
}
