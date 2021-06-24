using System;
using System.Collections.Generic;
using System.Text;

namespace Escola
{
    public class Professor
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string  Email { get; set; }
        public string Nacionalidade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CNH { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
        public decimal Salario { get; set; }
        public Disciplina Disciplina { get; set; }
        

        public Professor()
        {
            
            Disciplina  = new Disciplina();
            DateTime dataAdmissao = new DateTime(2007, 09, 07);
            DataAdmissao = dataAdmissao;
            DateTime dataNascimento = new DateTime(1990, 12, 25);
            DataNascimento = dataNascimento;

        }

        public void dadosProfessor()
        {
            Console.WriteLine($"Dados do professor {Nome}, mestra aulas de {Disciplina.Curso}, comecou seus estudos em {Disciplina.Data} feitas pelo curso {Disciplina.Nome} que foi admitido pela escola em {DataAdmissao}.\n");
            Console.WriteLine($"{Nome} nasceu em {DataNascimento}, na cidade de {Cidade} no estado de {Estado}, e reside na Rua {Endereco}.\n");
            Console.WriteLine($"Documentos de {Nome}.\n");
            Console.WriteLine($">{Email}");
            Console.WriteLine($">{Nacionalidade}");
            Console.WriteLine($">{CNH}");
        }
        
        
    }
}
