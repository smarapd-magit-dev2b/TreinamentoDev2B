using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Classes
{
    public abstract class Veiculo
    {
        public string Cor { get; set; }
        public int VelocidadeMaxima { get; set; }
        public string TipoCombustivel { get; set; }
        public string Marca { get; set; }
        public int QtdRodas { get; set; }
        public int QtdMaxPassageiros { get; set; }


        public Veiculo(int vmax, string tipoCombustivel, string marca)
        {
            VelocidadeMaxima = vmax;
            TipoCombustivel = tipoCombustivel;
            Marca = marca;
        }

        public void EscreverInformacoes()
        {
            Console.WriteLine($"Velocidade máxima: {VelocidadeMaxima} km/h");
            Console.WriteLine($"Tipo de combustível: {TipoCombustivel}");
            Console.WriteLine($"Marca: {Marca}");
        }
    }
}
