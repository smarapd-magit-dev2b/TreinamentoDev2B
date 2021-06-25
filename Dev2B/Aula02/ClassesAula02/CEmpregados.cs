using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02
{
    public class CEmpregados
    {
        private string Nome { get; set; }
        private string Sobrenome { get; set; }
        private decimal SalarioMensal { get; set; }

        public CEmpregados(string nome, string sobrenome, decimal salarioMensal)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            SalarioMensal = salarioMensal;

            if (SalarioMensal < 0)
                SalarioMensal = 0;
        }

        public void EscreverValores()
        {
            Console.WriteLine($"\n          Formulário Final            ");
            Console.WriteLine($"Nome Completo: {Nome} {Sobrenome} ");
            Console.WriteLine($"Salário Mensal: {SalarioMensal}");
        }
        public void calculaSalarioAtual()
        {
            decimal valorSalarioAnual = (SalarioMensal * 12);
            Console.WriteLine($"Valor Anual: {valorSalarioAnual}");
        }

        public void reajustarSalario()
        {
            decimal valorReajusteSalario = (SalarioMensal * 110) / 100;
            Console.WriteLine($"Valor Total: {valorReajusteSalario}");

        }
    }
}
