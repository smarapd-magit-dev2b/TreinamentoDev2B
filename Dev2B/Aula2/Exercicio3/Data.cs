﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Exercicio3
{
    class Data
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        public Data()
        {
            Dia = Convert.ToInt32(Console.ReadLine());
            Mes = Convert.ToInt32(Console.ReadLine());
            Ano = Convert.ToInt32(Console.ReadLine());
        }
        public string toString()
        {
            string data = Convert.ToString(Dia) + "/" +  Convert.ToString(Mes) + "/" + Convert.ToString(Ano);
            return data;
        }
        public void proximoDia()
        {
            if(Dia == 30)
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
