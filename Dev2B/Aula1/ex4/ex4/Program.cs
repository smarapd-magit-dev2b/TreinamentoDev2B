using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            ex4switch();
        }

        static void ex4()
        {
            int num1 = 0;
            int num2 = 0;
            String oper;

            Console.WriteLine("Digite um numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha uma operação ");
            oper = Console.ReadLine();

            if (oper == "+")
            {
                Console.WriteLine(num1 + num2);
                Console.ReadLine();

            }
            else if (oper == "-")
            {
                Console.WriteLine(num1 - num2);
                Console.ReadLine();
            }
            else if (oper == "*")
            {
                Console.WriteLine(num1 * num2);
                Console.ReadLine();
            }
            else if (oper == "/")
            {
                Console.WriteLine(num1 / num2);
                Console.ReadLine();
            }
        }

        static void ex4switch() {
            int num1 = 0;
            int num2 = 0;
            string oper;

            Console.WriteLine("Digite um numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha uma operação ");
            oper = Console.ReadLine();


            switch (oper)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    Console.ReadLine();
                    break;

                case "-":
                    Console.WriteLine(num1 - num2);
                    Console.ReadLine();
                    break;

                case "*":
                    Console.WriteLine(num1 * num2);
                    Console.ReadLine();
                    break;

                case "/":
                    Console.WriteLine(num1 / num2);
                    Console.ReadLine();
                    break;
            }

        }
    }

}
