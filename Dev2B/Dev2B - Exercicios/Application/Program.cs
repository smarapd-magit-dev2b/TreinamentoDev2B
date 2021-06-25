using Aula1;
using Aula2;
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

            classes.Execute();
            estrutura.Execute();
            
        }
    }
}
