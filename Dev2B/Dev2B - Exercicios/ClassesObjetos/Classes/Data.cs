using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Classes
{
    class Data
    {
        public int Dia { get; set; }
        private int Mes { get; set; }
        private int Ano { get; set; }

        public Data(int dia, int mes, int ano)
        {
            if (dia >= 1 && dia <= 30)
            {
                Dia = dia;
            }
            else
            {
                Console.WriteLine("Dia invalido...");
            }

            if (mes >= 1 && mes <= 12)
            {
                Mes = mes;
            }
            else
            {
                Console.WriteLine("Mês invalido...");
            }

            if (ano != 0)
            {
                Ano = ano;
            }
            else
            {
                Console.WriteLine("Ano invalido....");
            }
        }

        public override string ToString()
        {

            return Dia.ToString() + "/" + Mes.ToString() + "/" + Ano.ToString();
        }

        public void nextDay()
        {
            if(Dia == 30)
            {
                Mes++;
            }
            else
            {
                Dia++;
            }
        }
    }
}
