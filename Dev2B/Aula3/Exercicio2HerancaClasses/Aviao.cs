using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio2HerancaClasses
{
    public class Aviao : Veiculo
    {
        public int QntPilotos { get; set; }
        public int QntAcentos { get; set; }
        public string Porte { get; set; }

        public Aviao(string marca, string cor, decimal velocidadeMaxima, string tipoCombustivel, int qntMaximaPassageiros, int qntRodas)
            : base(marca, cor, velocidadeMaxima, tipoCombustivel, qntMaximaPassageiros, qntRodas)
        {

        }
    }
}
