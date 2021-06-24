using System;
using System.Collections.Generic;
using System.Text;

namespace Escola
{
    public class Disciplina
    {
        public string Nome { get; set; }
        public int CID { get; set; }
        public string Curso { get; set; }
        public DateTime Data { get; set; }

        public Disciplina()
        {
            DateTime dataInclusao = new DateTime(2000,02,28);
            Data = dataInclusao;
        }
    }
}
