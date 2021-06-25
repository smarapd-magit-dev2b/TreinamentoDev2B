using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2.Classes
{
    public class Empregado
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public decimal Salario { get; set; }

        public Empregado(string nome, string sobrenome, decimal salario)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Salario = salario;
        }

        public void dados()
        {
            Console.WriteLine($"O empregado {Nome}{Sobrenome} ganha {Salario} mensalmente.");
            Console.ReadLine();
        }

        public void SalarioAnual()
        {
            decimal slrAnual;
            slrAnual = Salario * 12;
            Console.WriteLine($"O empregado {Nome}{Sobrenome} ganha {slrAnual} anualmente.");
        }

        public void Reajuste()
        {
            decimal reajuste;
            reajuste = (Salario * 125) / 100;

            Console.WriteLine($"O empregado {Nome}{Sobrenome} começará a receber {reajuste} por conta de um reajuste de 25%.");
        }
    }
}
