using Aula_1;
using System;
using Aula_2.Exercicio_1;
using Aula_2.Exercicio_2;
using Aula_2.Exercicio_3;
using Aula_2.Exercicio_4;
using Aula_3.Exercicio_1;
using Aula_3.Heranca_2;
using Aula_4.Abstract_1;
using Aula_4.Abstract_2;
using Aula_4.Interface_1;
using Aula_4.Interface_2;
using Aula_5.Exercicio_1;
using Aula_5.Exercicio_2;
using Aula_6.Exercicio_Geral;
using Aula_7.Exercicio_1;
using Aula_8.SOLID;

namespace Exercicio_Geral
{
    class Program
    {
        static void Main(string[] args)
        {

            //Aula 1-----------------------------

            Exercicio_Aula_1 aula1 = new Exercicio_Aula_1();
            aula1.Executar_Aula1();

            //Aula 2-----------------------------

            Exercicio_1 aula_2Ex1 = new Exercicio_1();
            aula_2Ex1.Executar_Aula2Ex1();

            Exercicio_2 aula_2Ex2 = new Exercicio_2();
            aula_2Ex2.Executar_Aula2Ex2();

            Exercicio_3 aula_2Ex3 = new Exercicio_3();
            aula_2Ex3.Executar_Aula2Ex3();

            Exercicio_4 aula_2Ex4 = new Exercicio_4();
            aula_2Ex4.Executar_Aula2Ex4();

            //Aula 3-----------------------------

            Heranca_1 aula_3Ex1 = new Heranca_1();
            aula_3Ex1.Executar_Aula3Ex1();

            Heranca_2 aula_3Ex2 = new Heranca_2();
            aula_3Ex2.Executar_Aula3Ex2();

            //Aula 4-----------------------------

            Abstract_1 aula_4Ex1 = new Abstract_1();
            aula_4Ex1.Executar_Aula4Abs1();

            Abstract_2 aula_4Ex2 = new Abstract_2();
            aula_4Ex2.Executar_Aula_4Abs2();

            Interface_1 aula_4Ex3 = new Interface_1();
            aula_4Ex3.Executar_Aula4Int1();

            Interface_2 aula_4Ex4 = new Interface_2();
            aula_4Ex4.Executar_Aula4Int2();

            //Aula 5-----------------------------

            Exercicio1_Aula5 aula_5Ex1 = new Exercicio1_Aula5();
            aula_5Ex1.Executar_Aula5Ex1();

            Exercicio2_Aula5 aula_5Ex2 = new Exercicio2_Aula5();
            aula_5Ex2.Executar_Aula5Ex2();

            //Aula 6-----------------------------

            Exercicio aula_6Ex1 = new Exercicio();
            aula_6Ex1.Executar_Aula6Ger();

            ////Aula7

            //Exercicios aula_7Ex1 = new Exercicios();
            //aula_7Ex1.Main();

            //Aula8------------------------------

            Solid aula_8 = new Solid();
            aula_8.Executar_Aula8();

        }
    }
}
