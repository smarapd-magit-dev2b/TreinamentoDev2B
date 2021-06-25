using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio2HerancaClasses
{
    public class Moto : Veiculo
    {
        public bool PossuiCarenagem { get; set; }

        public Moto(string marca, string cor, decimal velocidadeMaxima, string tipoCombustivel, int qntMaximaPassageiros, int qntRodas)
            : base(marca, cor, velocidadeMaxima, tipoCombustivel, qntMaximaPassageiros, qntRodas)
        {

        }
    }
}
