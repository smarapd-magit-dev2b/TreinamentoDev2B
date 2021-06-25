using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Exercicio2HerancaClasses
{
    public class Carro : Veiculo
    {
        public int QntPortas { get; set; }
        public bool PossuiStep { get; set; }
        public bool PossuiTracaoTraseira { get; set; }

        public Carro(string marca, string cor, decimal velocidadeMaxima, string tipoCombustivel, int qntMaximaPassageiros, int qntRodas)
            : base(marca, cor, velocidadeMaxima, tipoCombustivel, qntMaximaPassageiros, qntRodas)
        {

        }
    }
}
