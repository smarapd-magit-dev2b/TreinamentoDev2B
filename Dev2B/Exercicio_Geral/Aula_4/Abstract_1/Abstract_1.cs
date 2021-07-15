using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_4.Abstract_1
{
   public class Abstract_1
    {
       public void Executar_Aula4Abs1()
        {
            Console.WriteLine(" Conta Corrente ");

            Console.Write("\n Número da conta: ");
            string numerocontac = Console.ReadLine();
            
            Console.Write("\n Agência: ");
            string agenciac = Console.ReadLine();
            
            Console.Write("\n Saldo: ");
            decimal saldoc = Convert.ToDecimal(Console.ReadLine());
            
            Console.Write("\n Quantia a depositar: ");
            decimal depositoc = Convert.ToDecimal(Console.ReadLine());
            
            Console.Write("\n Quantia a sacar: ");
            decimal saquec = Convert.ToDecimal(Console.ReadLine());

            var Corrente = new ContaCorrente(numerocontac, saquec, depositoc, agenciac, saldoc);

            Console.WriteLine(" \n\nConta Poupança ");

            Console.Write("\n Número da conta: ");
            string numerocontap = Console.ReadLine();
            
            Console.Write("\n Agência: ");
            string agenciap = Console.ReadLine();
            
            Console.Write("\n Saldo: ");
            decimal saldop = Convert.ToDecimal(Console.ReadLine());
            
            Console.Write("\n Quantia a depositar: ");
            decimal depositop = Convert.ToDecimal(Console.ReadLine());
            
            Console.Write("\n Quantia a sacar: ");
            decimal saquep = Convert.ToDecimal(Console.ReadLine());

            var Poupança = new ContaCorrente(numerocontap, saquep, depositop, agenciap, saldoc);

            Corrente.ImprimeExtr();
            Poupança.ImprimeExtr();
        }
    
    }
}
