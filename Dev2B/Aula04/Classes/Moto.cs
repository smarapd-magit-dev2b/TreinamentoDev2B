using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.Classes
{
    public class Moto: Veiculo
    {
        public bool PossuiCarenagem { get; set; }

        public Moto(string cor, decimal valocidadeMaxima, string tipoCombustivel,
            string marca, int quantidadeMaxPassageiros, int quantidadeRodas, bool possuiCarenagem)
            : base(cor, valocidadeMaxima, tipoCombustivel, marca, quantidadeMaxPassageiros, quantidadeRodas)
        {
            PossuiCarenagem = possuiCarenagem;
        }


        public override void EscreverDadosEspecificos()
        {
            base.EscreverDadosComuns();
            Console.WriteLine($"\nCarenagem: {PossuiCarenagem}");
        }
        
    }
}
