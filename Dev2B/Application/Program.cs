using Aula01;
using Aula02;
using Aula03;
using Aula04;
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nExercícios Treinamento Dev2b - Amanda Jaria\n");
            EstruturasComando estruturasComando = new EstruturasComando();
            ClassesObjetos classesObjetos = new ClassesObjetos();
            AbstrataInterface abstrataInterface = new AbstrataInterface();
            Heranca heranca = new Heranca();

            estruturasComando.Execute();
            classesObjetos.Execute();
            abstrataInterface.Execute();
            heranca.Execute();
        }
    }
}
