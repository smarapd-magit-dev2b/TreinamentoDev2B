using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7.Correto
{
    public abstract class Carro
    {
        public string Marca { get; set; }
        public int AnoLancamento { get; set; }
        public string Cor { get; set; }
        public decimal ValorCarro { get; set; }

        public Carro(string marca, int anoLancamento, string cor, decimal valorCarro)
        {
            Marca = marca;
            AnoLancamento = anoLancamento;
            Cor = cor;
            ValorCarro = valorCarro;
        }

        public abstract decimal ValorIpva();
    }
}
