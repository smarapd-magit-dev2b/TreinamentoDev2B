using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05_Lista.ClassesAula05
{

    public class Carro
    {

        public string Id { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public decimal Preco { get; set; }
        public int QtdPortas { get; set; }
        public int Kilometragem { get; set; }

        public Carro(string id, string marca, string cor, DateTime anoFabricacao, decimal preco, int qtdPortas, int kilometragem)
        {
            Id = id;
            Marca = marca;
            Cor = cor;
            AnoFabricacao = anoFabricacao;
            Preco = preco;
            QtdPortas = qtdPortas;
            Kilometragem = kilometragem;
        }
    }
}


