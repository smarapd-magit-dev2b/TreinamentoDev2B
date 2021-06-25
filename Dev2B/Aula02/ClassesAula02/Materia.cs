using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    public class Materia
    {
        private String Nome { get; set; }
        private int CID { get; set; }
        private string Curso { get; set; }
        private DateTime DataInclusao { get; set; }

        public Materia()
        {
            Nome = "Programação";
            CID = 123;
            Curso = "Analise e Desenvolvimento de Sistemas";
            DataInclusao = Convert.ToDateTime("12 / 10 / 2010");
        }

        public string GetNome()
        {
            return Nome;
        }
        public int GetCID()
        {
            return CID;
        }
        public string GetCurso()
        {
            return Curso;
        }
        public DateTime GetDate()
        {
            return DataInclusao;
        }
    }
}
