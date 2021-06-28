using Aula03.Classes.ClassesAbstr;
using Aula03.Classes.ClassesInterf;
using System;

namespace Aula03
{
    public class AbstrataInterface
    {
        public void Execute()
        {
            //Ex2Abstrata();
            //Ex2Interface();

        }

        static void Ex2Abstrata()
        {
            Calculadora calculadora = new Calculadora();
            Console.WriteLine("Insira o primeiro valor:");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor:");
            int valor2 = Convert.ToInt32(Console.ReadLine());
            Classes.ClassesAbstr.Soma soma = new Classes.ClassesAbstr.Soma(valor1, valor2);
            Classes.ClassesAbstr.Subtracao subtracao = new Classes.ClassesAbstr.Subtracao(valor1, valor2);
            Classes.ClassesAbstr.Divisao divisao = new Classes.ClassesAbstr.Divisao(valor1, valor2);
            Classes.ClassesAbstr.Multiplicacao multiplicacao = new Classes.ClassesAbstr.Multiplicacao(valor1, valor2);
            decimal resultado = calculadora.RealizarCalculo(soma);
            Console.WriteLine("A soma é: " + resultado);
            resultado= calculadora.RealizarCalculo(subtracao);
            Console.WriteLine("A subtracao é: " + resultado);
            resultado = calculadora.RealizarCalculo(divisao);
            Console.WriteLine("A divisao é: " + resultado);
            resultado = calculadora.RealizarCalculo(multiplicacao);
            Console.WriteLine("A multiplicacao é: " + resultado);

        }

        static void Ex2Interface()
        {            
            Console.WriteLine("Insira o primeiro valor:");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor:");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Classes.ClassesInterf.Subtracao subtracao = new Classes.ClassesInterf.Subtracao(valor1, valor2);
            Console.WriteLine("A subtração é " + subtracao.Calcular());

            Classes.ClassesInterf.Divisao divisao = new Classes.ClassesInterf.Divisao(valor1, valor2);
            Console.WriteLine("A divisão é " + divisao.Calcular());

            Classes.ClassesInterf.Soma soma = new Classes.ClassesInterf.Soma(valor1, valor2);
            Console.WriteLine("A soma é " + soma.Calcular());

            Classes.ClassesInterf.Multiplicacao multiplicacao = new Classes.ClassesInterf.Multiplicacao(valor1, valor2);
            Console.WriteLine("A multiplicação é " + multiplicacao.Calcular());

        }
    }
}
