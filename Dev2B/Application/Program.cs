using Aula1;
using Aula2;
using Aula3;

using System;

namespace Application {
    class Program {
        static void Main(string[] args) {
            ExercicioAula01 Exe1 = new ExercicioAula01();
            ExercicioAula02 Exe2 = new ExercicioAula02();
            ExercicioAula03 Exe3 = new ExercicioAula03();

            Exe1.Executar();
            Exe2.Executar();
            Exe3.Executar();
        }
    }
}
