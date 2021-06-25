using Aula01;
using Aula02;
using Aula03;
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciciosAula01 ExerciciosAula01 = new Aula01.ExerciciosAula01();
            ExerciciosAula02 ClassesAula02 = new Aula02.ExerciciosAula02();
            ExerciciosAula03 ClassesAula03 = new Aula03.ExerciciosAula03();


            ExerciciosAula01.Execute();
            ClassesAula02.Execute();
            ClassesAula03.Execute();

        }
    }
}
