using System;
using Aula1;
using Aula2;
using Aula3;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            EstruturasComando estruturasComando = new EstruturasComando();
            ClassesObjetos classesObjetos = new ClassesObjetos();
            Herancas herancas = new Herancas();

            estruturasComando.Execute();
            classesObjetos.Execute();
            herancas.Execute();
        }
    }
}
