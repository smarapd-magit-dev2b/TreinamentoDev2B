using Domain;
using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            do
            {
                Console.Write("Escolha uma opção:");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 0:
                        run = false;
                        break;
                    default:
                        break;
                }
            } while (run);
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
        }
        private static void Ex1()
        {
            ItemVenda ps5 = new ItemVenda(23, "PS5", 99, 5999.9m);
            Console.WriteLine($"O valor total do produto será de R${ps5.CalcularValorTotal()}");
        }
        private static void Ex2()
        {
            Empregado manuel = new Empregado("Manoel", "Robson", 15200);
            Console.WriteLine($"O salário anual de {manuel.Nome} é R${manuel.CalcularSalarioAtual()}");
            manuel.ReajustarSalario(0.15m);
            Console.WriteLine($"Com um aumento de 15%, seu salário mensal será {manuel.Salario}");
        }
        private static void Ex3()
        {
            //Retornar Data invalida
            Data data = new Domain.Data(31, 2, 2014);
            Console.WriteLine($"Data atual: {data.ToUserString()}");

            //Retornar data válida e pular de ano
            data.Dia = 31;
            data.Mes = 12;
            data.Ano = 2021;
            Console.WriteLine($"Data atual: {data.ToUserString()}");
            data.ProximoDia();
            Console.WriteLine($"Data atual: {data.ToUserString()}");
        }
        private static void Ex4()
        {
            Aluno aluno = new Aluno() {
                Nome = "Lucas",
                Endereco = "Rua Domingos Rizzo",
                Telefone = 00928922,
                Email = "arroba@arroba",
                Nacionalidade = "Cubano",
                Cidade = "Jardim Nópolis",
                Estado = "Serjipe",
                Ra = 3812938,
            };
            aluno.DataMatricula.Dia = 13;
            aluno.DataMatricula.Mes = 10;
            aluno.DataMatricula.Ano = 1333;
            aluno.Professor.Nome = "Glenilsson";
            aluno.Professor.DataNascimento.Dia = 21;
            aluno.Professor.DataNascimento.Mes = 10;
            aluno.Professor.DataNascimento.Ano = 2048;
            aluno.Professor.Endereco = "Rua Onório Reberbes";
            aluno.Professor.Telefone = 3902193;
            aluno.Professor.Email = "luras@arroba";
            aluno.Professor.Nacionalidade = "Romano";
            aluno.Professor.Cidade = "Sutão";
            aluno.Professor.Estado = "Santa Catarina";
            aluno.Professor.Cnh = 3213;
            aluno.Professor.DataAdmissao.Dia = 12;
            aluno.Professor.DataAdmissao.Mes = 12;
            aluno.Professor.DataAdmissao.Ano = 3021;
            aluno.Professor.Registro = 33213423;
            aluno.Professor.Salario = 20000;
            aluno.Professor.Disciplina.Nome = "Redes";
            aluno.Professor.Disciplina.Cid = 321312;
            aluno.Professor.Disciplina.Curso = "Ciência";
            aluno.Professor.Disciplina.DataInclusao.Dia = 5;
            aluno.Professor.Disciplina.DataInclusao.Mes = 5;
            aluno.Professor.Disciplina.DataInclusao.Ano = 100005;

            aluno.ImprimirDados();
        }
    }
}
