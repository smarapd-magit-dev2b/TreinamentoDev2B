using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Exercicio3Classes
{
    public class Data
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        public Data()
        {

        }

        public Data(int dia, int mes, int ano)
        {
            Dia = dia;
            Mes = mes;
            Ano = ano;
        }

        public string toString()
        {
            return Convert.ToString(Dia) + "/" + Convert.ToString(Mes) + "/" + Convert.ToString(Ano);
        }

        public void ProximoDia()
        {
            if (Dia == 30)
            {
                Dia = 1;
                if (Mes == 12)
                {
                    Mes = 1;
                    Ano = Ano + 1;
                }
                else
                    Mes = Mes + 1;
            }
            else
            {
                Dia = Dia + 1;
            }
        }
}
