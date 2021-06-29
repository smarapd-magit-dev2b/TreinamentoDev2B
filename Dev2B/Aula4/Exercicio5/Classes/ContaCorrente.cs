using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4.Exercicio5.Classes
{
    public class ContaCorrente
    {
        public int NumeroConta { get; set; }
        public decimal Saldo { get; set; }
        public bool ContaEspecial { get; set; }
        public decimal Limite { get; set; }


        public void Sacar(decimal valor)
        {
            if(Saldo - valor >= Limite)
            {

            }
        }

        public void Depositar(decimal valor)
        {

        }
    }
}
