using System;

namespace Aula02.Exercicio04 {
    public class Disciplina {
        private String Nome { get; set; }
        private int CID { get; set; }
        private string Curso { get; set; }
        private DateTime DataInclusao{get; set;}
        
        public Disciplina() {
            Nome = "Programação";
            CID = 123;
            Curso = "Analise e Desenvolvimento de Sistemas";
            DataInclusao = Convert.ToDateTime("12 / 10 / 2010");
        }

        public string GetNome() {
            return Nome;
        }
        public int GetCID() {
            return CID;
        }
        public string GetCurso() {
            return Curso;
        }
        public DateTime GetDate() {
            return DataInclusao;
        }
    }
}
