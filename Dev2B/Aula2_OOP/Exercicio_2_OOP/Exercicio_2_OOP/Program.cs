using Classes;
using System;

namespace Exercicio_2_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;

            empregado Empregado1 = new empregado("João", "Paulo", 2000.00m);
            empregado Empregado2 = new empregado("Pedro", "Augusto", 1500.00m);
            empregado Empregado3 = new empregado("João", "Paulo", 3000.00m);

            Console.WriteLine("1) Monstrar os empregados.\n2) Mostrar salario anual dos empregados.\n3) Fazer reajuste de 25% no salario dos empregados.\nResposta: ");
            escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    {
                        Empregado1.dados();
                        Empregado2.dados();
                        Empregado3.dados();
                        break;
                    }
                case 2:
                    {
                        Empregado1.Anaulidade();
                        Empregado2.Anaulidade();
                        Empregado3.Anaulidade();
                        break;
                    }
                case 3:
                    {
                        Empregado1.Reajuste();
                        Empregado2.Reajuste();
                        Empregado3.Reajuste();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Desligando...");
                        break;
                    }

            }
        }
    }
}
