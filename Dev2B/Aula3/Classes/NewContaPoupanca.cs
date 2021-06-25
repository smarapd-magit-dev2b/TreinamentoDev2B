using System;
using System.Collections.Generic;
using System.Text;
using Aula3.Interfaces;

namespace Aula3.Classes
{
    public class NewContaPoupanca : ITransacao
    {
        public int NumeroConta { get; set; }
        public string MovimentacoesSaques { get; set; }
        public string MovimentacoesDepositos { get; set; }
        public int Agencia { get; set; }

        public void ImpreExtrato()
        {
            Console.WriteLine(MovimentacoesDepositos);
            Console.WriteLine(MovimentacoesSaques);
        }

        public string Depositar()
        {
            return MovimentacoesDepositos;
        }

        public string Sacar()
        {
            return MovimentacoesSaques;
        }
        public int AplicarRendimento()
        {
            var valorFinal = Convert.ToInt32(MovimentacoesDepositos) * (Convert.ToInt32(MovimentacoesDepositos) / 3);
            return valorFinal;
        }
    }
}
