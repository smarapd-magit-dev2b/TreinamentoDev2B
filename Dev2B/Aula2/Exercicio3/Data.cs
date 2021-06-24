using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Exercicio3
{
    public class Data
    {
        private int Dia { get; set; }
        private int Mes { get; set; }
        private int Ano { get; set; }

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
                if (ano>0)
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

        public Data()
        {
            Dia = DateTime.Now.Day;
            Mes = DateTime.Now.Month;
            Ano = DateTime.Now.Year;
        }

        public string ToStringMetodo()
        {
            return $"{Dia.ToString()}/{Mes.ToString()}/{Ano.ToString()}";
        }

        public void AvancarProximoDia()
        {
            if (Dia == 30)
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

        public void EscreverData()
        {
            string proximaData;            
            Console.WriteLine($"\nO dia é {Dia}.");
            Console.WriteLine($"O mês é {Mes}.");
            Console.WriteLine($"O ano é {Ano}.");
            AvancarProximoDia();
            proximaData = ToStringMetodo();
            Console.WriteLine($"A próxima data é {proximaData}.");           
        }




    }
}
