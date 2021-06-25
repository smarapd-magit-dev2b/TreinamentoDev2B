using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    public class Professor
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereço { get; set; }
        public double Telefone { get; set; }
        public string Email { get; set; }
        public string Nacionalidade { get; set; }
        public String Cidade { get; set; }
        public string Estado { get; set; }
        public long CNH { get; set; }
        public DateTime DataAdmissao { get; set; }
        public double RegistroProfessor { get; set; }
        public decimal Salario { get; set; }
        public Materia Materias { get; set; }

        public Professor()
        {
            Materias = new Materia();

        }
    }
}
