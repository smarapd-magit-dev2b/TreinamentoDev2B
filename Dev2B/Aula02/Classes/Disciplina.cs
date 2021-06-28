using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.Classes
{
    public class Disciplina
    {
        public string Nome { get; set; }
        public string Cid { get; set; }
        public string Curso { get; set; }
        public DateTime DataInclusao { get; set; }

       
        public void EscreverDisciplina()
        {
            Console.WriteLine($"\nO nome é {Nome}.");
            Console.WriteLine($"O cid é {Cid}.");
            Console.WriteLine($"O curso é {Curso}.");
            Console.WriteLine($"A data é {DataInclusao}.");
        }
    }
}
