using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.ClassesAula02
{
    public class Data
    {
        private int Dia { get; set; }
        private int Mes { get; set; }
        private int Ano { get; set; }

        public Data(int dia, int mes, int ano)
        {
            Dia = dia;
            Mes = mes;
            Ano = ano;
        }
        public void ProximoDia()
        {

            if (Dia == 30 && Mes == 12)
            {
                Ano++;
            }

            if (Mes == 12 && Dia == 30)
            {
                Mes = 1;
            }
            else if (Dia == 30)
            {
                Mes++;
            }

            if (Dia == 30)
            {
                Dia = 1;
            }
            else
            {
                Dia++;
            }

            Console.WriteLine($"Proximo dia: {Dia}/{Mes}/{Ano}");
        }
        public override string ToString()
        {
            return "Dia Atual " + Dia + "/" + Mes + "/" + Ano;
        }
    }
}
