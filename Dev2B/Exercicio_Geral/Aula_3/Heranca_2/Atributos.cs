using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_3.Heranca_2
{
    public class Atributos
    {
        public string Cor { get; set; }

        public int VelocidadeMaxima { get; set; }

        public string Combustivel { get; set; }

        public string Marca { get; set; }

        public int QuantidadeRodas { get; set; }

        public int QuantidadePassageiros { get; set; }

        //Contrutor-------------------------

        public Atributos(string cor, int velocidademaxima, string combustivel, string marca, int quantidaderodas, int quantidadepassageiros)
        {
            Cor = cor;
            VelocidadeMaxima = velocidademaxima;
            Combustivel = combustivel;
            Marca = marca;
            QuantidadeRodas = quantidaderodas;
            QuantidadePassageiros = quantidadepassageiros;

        }

    }
}
