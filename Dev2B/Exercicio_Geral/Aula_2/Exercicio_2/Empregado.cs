using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_2.Exercicio_2
{
    public class Empregado
    {
        //Nome------------------------------
        public string Nome { get; set; }

        //Sobrenome-------------------------
        public string Sobrenome { get; set; }

        //Salario---------------------------

        private decimal salario;

        public decimal Salario
        {
            get { return salario; }
            set
            {
                if (value >= 0)

                    salario = value;

                else

                    salario = 0;
            }

        }

        //Construtor------------------------

        public Empregado(string nome, string sobrenome, decimal salario)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Salario = salario;

        }

        //Metodo----------------------------

        public decimal calcularSalarioAtual()
        {

            return Salario * 12;

        }

        public decimal reajustarSalario()
        {

            return Salario * 20 / 100;
        }
    }
}
