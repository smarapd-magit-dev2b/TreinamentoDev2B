using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Disciplina
    {
        public string Nome { get; set; }
        public int CID { get; set; }
        public string Curso { get; set; }
        public DateTime DataInclusao { get; set; }

        public Disciplina()
        {

        }
        public Disciplina(string nome, int cID, string curso, DateTime dataInclusao)
        {
            Nome = nome;
            CID = cID;
            Curso = curso;
            DataInclusao = dataInclusao;
        }
    }
}
