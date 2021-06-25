using System;
using Aula3.Interfaces;

namespace Aula3.Classes
{
    public class NewContaCorrente : ITransacao
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

        public int AplicarTaxaServico()
        {
            var valorFinal = Convert.ToInt32(MovimentacoesSaques) * (Convert.ToInt32(MovimentacoesSaques) / 3);
            return valorFinal;
        }


    }
}
