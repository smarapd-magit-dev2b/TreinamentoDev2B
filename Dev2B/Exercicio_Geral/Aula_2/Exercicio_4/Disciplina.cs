using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_2.Exercicio_4
{
    public class Disciplina
    {

        //Propriedades--------------------------

        public string Nome { get; set; }

        public int Cid { get; set; }

        public string Curso { get; set; }

        public DateTime DataInclusão { get; set; }

        //Construtor---------------------------
        public Disciplina(string nome, int cid, string curso, DateTime datainclusão)
        {
            Nome = nome;
            Cid = cid;
            Curso = curso;
            DataInclusão = datainclusão;

        }


        //Metodo-------------------------------

        public void Escreverinformacoes1()
        {
            Console.WriteLine(Nome);
            Console.WriteLine(Cid);
            Console.WriteLine(Curso);
            Console.WriteLine(DataInclusão);
        }

    }
}
