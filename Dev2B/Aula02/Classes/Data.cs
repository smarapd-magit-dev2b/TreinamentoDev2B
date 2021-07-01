using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02.Classes
{
    public class Data
    {
        private int Dia { get; set; }
        private int Mes { get; set; }
        private int Ano { get; set; }

        public Data(int dia, int mes, int ano)
        {
            bool valid = false;

            do
            {
                if (dia >= 1 && dia <= 30)
                {
                    valid = true;
                }
                {
                    Console.WriteLine("Dia inválido");
                    dia = Convert.ToInt32(Console.ReadLine());
                }
            } while (!valid);
            Dia = dia;

            valid = false;
            do
            {
                if (mes >= 1 && mes <= 12)
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Mês inválido.");
                    mes = Convert.ToInt32(Console.ReadLine());
                }
            } while (!valid);
            Mes = mes;

            do
            {
                if (ano > 0)
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Ano inválido.");
                    ano = Convert.ToInt32(Console.ReadLine());
                }
            } while (!valid);
            Ano = ano;
        }
        public Data()
        {
            Dia = DateTime.Now.Day;
            Mes = DateTime.Now.Month;
            Ano = DateTime.Now.Year;
        }

        public string TransformDate()
        {
            return $"{Dia.ToString()}/{Mes.ToString()}/{Ano.ToString()}";
        }

        public void NextDay()
        {
            if(Dia == 30)
            {
                Dia = 1;
                if (Mes == 12)
                {
                    Mes = 1;
                    Ano++;
                }
                else
                    Mes++;
            }
            else
            {
                Dia++;
            }
        }
        public void ShowDate()
        {
            Console.WriteLine($"O dia é {Dia}.");
            Console.WriteLine($"O mês é {Mes}.");
            Console.WriteLine($"O ano é {Ano}.");
            NextDay();
        }
    }
}
