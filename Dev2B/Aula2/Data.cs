using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2
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
            bool validador = false;

            do
            {
                if (dia >= 1 && dia <= 30)
                {
                    validador = true;
                }

                else
                {
                    Console.WriteLine("Dia inválido. Insira um novo dia");
                    dia = Convert.ToInt32(Console.ReadLine());
                }
            } while (!validador);
            Dia = dia;

            validador = false;
            do
            {
                if (mes >= 1 && mes <= 12)
                {
                    validador = true;
                }

                else
                {
                    Console.WriteLine("Mês inválido. Insira um novo mês");
                    mes = Convert.ToInt32(Console.ReadLine());
                }
            } while (!validador);
            Mes = mes;

            do
            {
                if (ano > 0)
                {
                    validador = true;
                }

                else
                {
                    Console.WriteLine("Ano inválido. Insira um novo ano");
                    ano = Convert.ToInt32(Console.ReadLine());
                }
            } while (!validador);
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
}
