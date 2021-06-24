using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Professor
    {
        public string Nome { get; set; }
        public Data DataNascimento { get; set; }
        public string Endereco { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Nacionalidade { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Cnh { get; set; }
        public Data DataAdmissao { get; set; }
        public int Registro { get; set; }
        public decimal Salario { get; set; }
        public Disciplina Disciplina { get; set; }
        public Professor()
        {
            DataNascimento = new Data();
            Disciplina = new Disciplina();
            DataAdmissao = new Data();
        }
        public void ImprimirDados()
        {
            Console.WriteLine("Professor");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Data de nascimento: {DataNascimento.toString()}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Nacionalidade: {Nacionalidade}");
            Console.WriteLine($"Cidade: {Cidade}");
            Console.WriteLine($"Estado: {Estado}");
            Console.WriteLine($"CNH: {Cnh}");
            Console.WriteLine($"Data de admissão: {DataAdmissao.toString()}");
            Console.WriteLine($"Registro: {Registro}");
            Console.WriteLine($"Salario: R${Salario}\n");
            Disciplina.ImprimirDados();
        }
    }
}
