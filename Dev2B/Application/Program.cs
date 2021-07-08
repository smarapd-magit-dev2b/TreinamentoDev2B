using Aula01;
using Aula02;
using Aula03;
using Aula04;
using Aula05_Lista;
using Aula06_Lambdas;
using Aula07_ClassesEstaticas;
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
            ExerciciosAula04 ClassesAula04 = new Aula04.ExerciciosAula04();
            ExerciciosAula05 ClassesAula05 = new Aula05_Lista.ExerciciosAula05();
            ExerciciosAula06 ClassesAula06 = new Aula06_Lambdas.ExerciciosAula06();
            ExerciciosAula07 ClassesAula07 = new Aula07_ClassesEstaticas.ExerciciosAula07();

            ExerciciosAula01.Execute();
            ClassesAula02.Execute();
            ClassesAula03.Execute();
            ClassesAula04.Execute();
            ClassesAula05.Execute();
            ClassesAula06.Execute();
            ClassesAula07.Execute();

        }
    }

}
