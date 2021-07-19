using System;

namespace Common.Classes.Pessoa.Fisica
{
    public class Aluno : PessoaFisica
    {
        public Data DataMatricula { get; set; }
        public int Ra { get; set; }
        public Professor Professor { get; set; }
        public Aluno()
        {
            DataNascimento = new DateTime();
            DataMatricula = new Data();
            Professor = new Professor();
        }
        public void ImprimirDados()
        {
            Console.WriteLine("Aluno");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Data de nascimento do Aluno: {DataNascimento}");
            Console.WriteLine($"Endereço do Aluno: {Endereco}");
            Console.WriteLine($"Telefone do Aluno: {Telefone}");
            Console.WriteLine($"Email do Aluno: {Email}");
            Console.WriteLine($"Nacionalidade do Aluno: {Nacionalidade}");
            Console.WriteLine($"Cidade do Aluno: {Endereco.Cidade}");
            Console.WriteLine($"Estado do Aluno: {Endereco.Estado}");
            Console.WriteLine($"Data da matrícula do Aluno: {DataMatricula.ToUserString()}");
            Console.WriteLine($"RA do Aluno: {Ra}\n");
            Professor.ImprimirDados();
        }
    }
}
