using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exercicio3
{
    public class Data
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        public Data (int dia, int mes, int ano)
        {
            Dia = dia;
            Mes = mes;
            Ano = ano;

            if (Dia > 0 && Dia <= 30)
                Dia = dia;
            else
                Console.WriteLine("Dia Inválido.");
            if (Mes > 0 && Mes <= 12)
                Mes = mes;
            else
                Console.WriteLine("Mês Inválido.");
            if (Ano > 1 && Ano < 9999)
                Ano = ano;
            else
                Console.WriteLine("Ano Inválido.");
        }

        public void Dia_Atual()
        {
            Dia = DateTime.Now.Day;
            Mes = DateTime.Now.Month;
            Ano = DateTime.Now.Year;
        }

        public override string ToString()
        {
            return ($"Dia_Atual {Dia}/{Mes}/{ Ano}");
        }

        public void ProximoDia()
        {
            if (Dia > 0 && Dia <= 30)
                Dia++;
            else
            {
                Mes++;
                if (Mes > 1 && Mes <= 12)
                    Mes++;
                else
                    Ano++;
            }
        }
    }
}
