using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    public class CAluno
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereço { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Nacionalidade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime DataMatricula { get; set; }
        public long RA { get; set; }
        public CProfessor Professor { get; set; }

            public CAluno()
            {
                Professor = new CProfessor();
            }
        }
    }
