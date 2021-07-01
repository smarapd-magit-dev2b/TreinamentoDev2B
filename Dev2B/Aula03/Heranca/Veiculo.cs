using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Heranca
{
    public class Veiculo
    {
        public string Cor { get; set; }
        public int VelocidadeMaxima { get; set; }
        public string TipoCombustivel { get; set; }
        public string Marca { get; set; }
        public int QuantidadeRodas { get; set; }

        public void MostrarInformacoes()
        {
            Console.WriteLine("Cor :" + Cor);
            Console.WriteLine("Velocidade Máxima: " + VelocidadeMaxima);
            Console.WriteLine("Tipo de Combustível: " + TipoCombustivel);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Quantidade de Rodas: " + QuantidadeRodas);
        }
    }
}
