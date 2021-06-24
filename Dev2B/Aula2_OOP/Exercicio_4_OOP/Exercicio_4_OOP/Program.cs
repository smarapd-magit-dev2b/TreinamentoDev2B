using Escola;
using System;

namespace Exercicio_4_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno Aluno = new Aluno("Gabriel") {

                Endereco = "Tijolos Amarelos",
                Email = "gab@gmail.com",
                Nacionalidade = "Brasileiro",
                Cidade = "Ribeirã Preto",
                Estado = "SP",
                Telefone = "(16)12345-7890",        
                RA = "2468791",
            };


            Console.WriteLine("Inserção de dados de professor!");
            Console.WriteLine("Nome: ");
            Aluno.Professor.Nome = Console.ReadLine();
            Console.WriteLine("Endereço: ");
            Aluno.Professor.Endereco = Console.ReadLine();
            Console.WriteLine("Estado: ");
            Aluno.Professor.Estado = Console.ReadLine();
            Console.WriteLine("Nacionalidade : ");
            Aluno.Professor.Nacionalidade = Console.ReadLine();
            Console.WriteLine("Cidade: ");
            Aluno.Professor.Cidade = Console.ReadLine();
            Console.WriteLine("CNH: ");
            Aluno.Professor.CNH = Console.ReadLine();
            Console.WriteLine("Registro: ");
            Aluno.Professor.Registro = Console.ReadLine();
            Console.WriteLine("Salario: ");
            Aluno.Professor.Salario = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Curso que o {Aluno.Professor.Nome} fez: ");
            Aluno.Professor.Disciplina.Curso = Console.ReadLine();
            Console.WriteLine($"Nome do curso feito pelo Professor {Aluno.Professor.Nome}");
            Aluno.Professor.Disciplina.Nome = Console.ReadLine();
            Console.WriteLine($"CID do curso feito pelo Professor {Aluno.Professor.Nome}");
            Aluno.Professor.Disciplina.CID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Data de inclusão ao curso de {Aluno.Professor.Disciplina.Curso}, que esta sendo feito pelo Professor {Aluno.Professor.Nome}");
            Aluno.Professor.Disciplina.Nome = Console.ReadLine();



            Console.WriteLine("");
            Aluno.getDados();
            Aluno.Professor.dadosProfessor();
            
            

            Console.ReadLine();


            
                

            
            

        }
    }
}
