using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.Classes
{
    public class Aviao:Veiculo
    {
        public int QuantidadePilotos { get; set; }
        public string Porte { get; set; }

        public Aviao(string cor, decimal valocidadeMaxima, string tipoCombustivel,
            string marca, int quantidadeMaxPassageiros, int quantidadeRodas, int quantidadePilotos, string porte)
            : base(cor, valocidadeMaxima, tipoCombustivel, marca, quantidadeMaxPassageiros, quantidadeRodas)
        {
            QuantidadePilotos = quantidadePilotos;
            Porte = porte;
        }
        

        public override void EscreverDadosEspecificos()
        {
            base.EscreverDadosComuns();
            Console.WriteLine($"\nQuantidade de pilotos: {QuantidadePilotos}");
            Console.WriteLine($"\nPorte: {Porte}");            

        }
        
    }
}
