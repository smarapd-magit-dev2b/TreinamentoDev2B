using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_3
{
   public class Data
    {
        private int dia; 
        public int Dia
        {
             get { return dia; }
             
            set
            {
                if (value <= 30 && value > 0)

                    dia = value;

                else

                    Console.WriteLine("Não existe essa data");
            }
        }

        private int mes;
        public int Mes
        {
          get { return mes; }
          
          set
          {
                if (value > 0 && value <= 12)

                    mes = value;

                else

                    Console.WriteLine("Não existe esse mes");

           }

        }

        private int ano;
        public int Ano
        {
            get { return ano; }

            set
            {
                if (value < 0)

                    Console.WriteLine("Não existe esse ano");

                else

                    ano = value;

            }


        }
      
     //Construtor---------------------------

     public Data(int dia, int mes, int ano)
     {
            Dia = dia;
            Mes = mes;
            Ano = ano;

     }

     public Data()
     {

           Console.WriteLine(" \n Data atual: " + DateTime.Now.ToShortDateString());

     }

     //Metodo-------------------------------

        public void Escrever()
        {
           Console.WriteLine(Dia + "/" + Mes + "/" + Ano);

        }
        public void proximodia()
        {

            if (dia == 30)
            {
                if (mes == 12)
                {
                    
                    ano = ano + 1;
                }
                else

                    mes = mes + 1;

            }

            else
                dia = dia + 1;

        }
    }
}
