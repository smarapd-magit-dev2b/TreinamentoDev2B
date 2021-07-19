using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5.Exercicio4Classes
{
    public class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public int AnoFabricacao { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadePortas { get; set; }
        public string Kilometragem { get; set; }
        public Carro(int id, string marca, string cor, int anoFabricacao, decimal preco, int qtdPortas, string km)
        {
            Id = id;
            Marca = marca;
            Cor = cor;
            AnoFabricacao = anoFabricacao;
            Preco = preco;
            QuantidadePortas = qtdPortas;
            Kilometragem = km;
        }

        public override string ToString()
        {
            return $"\nID: {Id}. \nMarca: {Marca}. \nCor: {Cor}. \nAno de Fabricação: {AnoFabricacao}." +
                $" \nPreço: R${Preco}. \nQuantidade de portas: {QuantidadePortas}. \nKilometragem: {Kilometragem} km.";
        }
    }
}
