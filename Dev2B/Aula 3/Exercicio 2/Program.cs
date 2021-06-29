using System;

namespace Herança_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis-----------------------
            
            Carro C1;
            Moto M1;
            Avião A1;

            //Carro---------------------------
           
            Console.WriteLine("Informações do Carro:");

            Console.WriteLine("\n Cor do Carro ");
            string corc = Console.ReadLine();

            Console.WriteLine("\n Velocidade Maxima: ");
            int maximac = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Combustivel: ");
            string combustivelc = Console.ReadLine();

            Console.WriteLine("\n Marca ");
            string marca = Console.ReadLine();

            Console.WriteLine("\n Quantidade de rodas: ");
            int rodasc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Quantidade de Passageiros: ");
            int passageiroc = Convert.ToInt32(Console.ReadLine());

            C1 = new Carro(corc, maximac, combustivelc, marca, rodasc, passageiroc);

            //Moto---------------------------

            Console.WriteLine("Informações do Moto:");

            Console.WriteLine("\n Cor da Moto ");
            string corm = Console.ReadLine();

            Console.WriteLine("\n Velocidade Maxima: ");
            int maximam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Combustivel: ");
            string combustivelm = Console.ReadLine();

            Console.WriteLine("\n Marca ");
            string marcam = Console.ReadLine();

            Console.WriteLine("\n Quantidade de rodas: ");
            int rodasm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Quantidade de Passageiros: ");
            int passageirom = Convert.ToInt32(Console.ReadLine());

            M1 = new Moto(corm, maximam, combustivelm, marcam, rodasm, passageirom);

            //Avião---------------------------

            Console.WriteLine("Informações do Avião:");

            Console.WriteLine("\n Cor do Avião ");
            string cora = Console.ReadLine();

            Console.WriteLine("\n Velocidade Maxima: ");
            int maximaa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Combustivel: ");
            string combustivela = Console.ReadLine();

            Console.WriteLine("\n Marca ");
            string marcaa = Console.ReadLine();

            Console.WriteLine("\n Quantidade de rodas: ");
            int rodasa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Quantidade de Passageiros: ");
            int passageiroa = Convert.ToInt32(Console.ReadLine());

            A1 = new Avião(cora, maximaa, combustivela, marcaa, rodasa, passageiroa);



        }
    }
}
