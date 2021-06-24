using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Disciplina
    {
        public string Nome { get; set; }
        public int Cid { get; set; }
        public string Curso { get; set; }
        public Data DataInclusao { get; set; }
        public Disciplina()
        {
            DataInclusao = new Data();
        }
        public void ImprimirDados()
        {
            Console.WriteLine("Disciplina");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CID: {Cid}");
            Console.WriteLine($"Curso: {Curso}");
            Console.WriteLine($"Data de inclusão: {DataInclusao.ToUserString()}");
        }
    }
}
