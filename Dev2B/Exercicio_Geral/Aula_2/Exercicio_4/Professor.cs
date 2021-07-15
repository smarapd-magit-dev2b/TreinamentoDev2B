using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_2.Exercicio_4
{
    public class Professor
    {
        //Propriedades-------------------------

        public string Nome { get; set; }

        public DateTime DataNasc { get; set; }

        public string Endereço { get; set; }

        public int Telefone { get; set; }

        public string Email { get; set; }

        public string Nacionalidade { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public int Cnh { get; set; }

        public DateTime DataAdmi { get; set; }

        public int RegistroProf { get; set; }

        public decimal Salario { get; set; }

        public string Disciplina { get; set; }

        //Construtor---------------------------
        public Professor(string nome, DateTime datanasc, string endereço, int telefone, string email, string nacionalidade, string cidade, string estado, int cnh, DateTime dataadmi, int registroprof, decimal salario, string disciplina)
        {
            Nome = nome;
            DataNasc = datanasc;
            Endereço = endereço;
            Telefone = telefone;
            Email = email;
            Nacionalidade = nacionalidade;
            Cidade = cidade;
            Estado = estado;
            Cnh = cnh;
            DataAdmi = dataadmi;
            RegistroProf = registroprof;
            Salario = salario;
            Disciplina = disciplina;

        }
        //Metodo-------------------------------

        public void Escreverinformacoes2()

        {
            Console.WriteLine(Nome);
            Console.WriteLine(DataNasc);
            Console.WriteLine(Endereço);
            Console.WriteLine(Telefone);
            Console.WriteLine(Email);
            Console.WriteLine(Nacionalidade);
            Console.WriteLine(Cidade);
            Console.WriteLine(Estado);
            Console.WriteLine(Cnh);
            Console.WriteLine(DataAdmi);
            Console.WriteLine(RegistroProf);
            Console.WriteLine(Salario);
            Console.WriteLine(Disciplina);

        }

    }
}
