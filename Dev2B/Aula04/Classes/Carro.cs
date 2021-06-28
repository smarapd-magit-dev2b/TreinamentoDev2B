using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.Classes
{
    public class Carro: Veiculo
    {
        public bool TracaoTraseira { get; set; }
        public bool Step { get; set; }
        public int QuantidadePortas { get; set; }

        public Carro(string cor, decimal valocidadeMaxima, string tipoCombustivel,
            string marca, int quantidadeMaxPassageiros, int quantidadeRodas, bool tracaoTraseira, bool step, int quantidadePortas)
            : base(cor, valocidadeMaxima, tipoCombustivel, marca, quantidadeMaxPassageiros, quantidadeRodas)
        {
            TracaoTraseira = tracaoTraseira;
            Step = step;
            QuantidadePortas = quantidadePortas;
        }

        public override void EscreverDadosEspecificos()
        {
            base.EscreverDadosComuns();
            Console.WriteLine($"\nQuantidade de Portas: {QuantidadePortas}");
            Console.WriteLine($"\nStep: {Step}");
            Console.WriteLine($"\nTracao Traseira: {TracaoTraseira}");
        }
       
    }
}
