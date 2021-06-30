using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05.Classes
{
    public class Carro
    {
        public string Id { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public int AnoFabricacao { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadePortas { get; set; }
        public decimal Quilometragem { get; set; }
       

        public Carro (string id, string marca, string cor, int anoFabricacao, decimal preco, int quantidadePortas, decimal quilometragem)
        {
            Id = id;
            Marca = marca;
            Cor = cor;
            AnoFabricacao = anoFabricacao;
            Preco = preco;
            QuantidadePortas = quantidadePortas;
            Quilometragem = quilometragem;           
        }
    }
}
