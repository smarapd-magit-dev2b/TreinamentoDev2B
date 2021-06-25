using Aula1;
using Aula2;
using Aula3;
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Estrutura estrutura = new Estrutura();
            ClassesObjetos classes = new ClassesObjetos();
            AbstractInterface absinter = new AbstractInterface();

            classes.Execute();
            estrutura.Execute();
            absinter.Execute();
            
        }
    }
}
