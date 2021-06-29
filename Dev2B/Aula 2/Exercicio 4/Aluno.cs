using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_4.Classe
{
    public class Aluno
    {
        // Propriedades------------------------

        public string Nome { get; set; }

        public DateTime DataNasc { get; set; }

        public string Endereço { get; set; }

        public int Telefone { get; set; }

        public string Email { get; set; }

        public string Nacionalidade { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public DateTime DataMatri { get; set; }

        public int RA { get; set; }

        public string Professor { get; set; }

        //Construtor---------------------------
        public Aluno(string nome, DateTime datanasc, string endereço, int telefone, string email, string nacionalidade, string cidade, string estado, DateTime datamatri, int ra, string professor)
        {
            Nome = nome;
            DataNasc = datanasc;
            Endereço = endereço;
            Telefone = telefone;
            Email = email;
            Nacionalidade = nacionalidade;
            Cidade = cidade;
            Estado = estado;
            DataMatri = datamatri;
            RA = ra;
            Professor = professor;

        }

     //Metodo-------------------------------

     public void Escreverinformacoes3()
     {

            Console.WriteLine(Nome);
            Console.WriteLine(DataNasc);
            Console.WriteLine(Endereço);
            Console.WriteLine(Telefone);
            Console.WriteLine(Email);
            Console.WriteLine(Nacionalidade);
            Console.WriteLine(Cidade);
            Console.WriteLine(Estado);
            Console.WriteLine(DataMatri);
            Console.WriteLine(RA);
            Console.WriteLine(Professor);

     }

        
    }
}
