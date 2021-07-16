using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel----------------------

            Data d1;
            Data d2;

            //Dia---------------------------

            Console.WriteLine("\n Digite o dia: ");
            int dia = Convert.ToInt32(Console.ReadLine());

            //Mes---------------------------

            Console.WriteLine("\n Digite o mes: ");
            int mes = Convert.ToInt32(Console.ReadLine());

            //Ano---------------------------

            Console.WriteLine("\n Digite o ano ");
            int ano = Convert.ToInt32(Console.ReadLine());

            d1 = new Data(dia, mes, ano);

            d2 = new Data();

            //Mensagem----------------------

            Console.WriteLine("\n Data: ");
            d1.Escrever();

            d2.proximodia();
            





        }
    }
}
