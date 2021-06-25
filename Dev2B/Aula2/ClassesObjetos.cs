using Domain;
using System;

namespace Aula2
{
    public class ClassesObjetos
    {
        public void Execute()
        {
            Menu menu = new Menu("Exercícios de Classes e Objetos");
            menu.AddItem("Exercício 1");
            menu.AddItem("Exercício 2");
            menu.AddItem("Exercício 3");
            menu.AddItem("Exercício 4");
            bool run = true;
            do
            {
                menu.Print();
                Console.Write("Digite o número que deseja executar: ");
                try
                {
                    var escolha = int.Parse(Console.ReadLine());
                    switch (escolha)
                    {
                        case 1:
                            Console.Clear();
                            Ex1();
                            break;
                        case 2:
                            Console.Clear();
                            Ex2();
                            break;
                        case 3:
                            Ex3();
                            break;
                        case 4:
                            Ex4();
                            break;
                        case 0:
                            Console.Clear();
                            run = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine($"{escolha} não está na lista!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Digite apenas números!\n");
                }
            } while (run);
        }
        private void Ex1()
        {
            ItemVenda ps5 = new ItemVenda(23, "PS5", 99, 5999.9m);
            Console.WriteLine($"O valor total do produto será de R${ps5.CalcularValorTotal()}");
        }
        private void Ex2()
        {
            Empregado manuel = new Empregado("Manoel", "Robson", 15200);
            Console.WriteLine($"O salário anual de {manuel.Nome} é R${manuel.CalcularSalarioAtual()}");
            manuel.ReajustarSalario(0.15m);
            Console.WriteLine($"Com um aumento de 15%, seu salário mensal será {manuel.Salario}");
        }
        private void Ex3()
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
        private void Ex4()
        {
            Aluno aluno = new Aluno()
            {
                Nome = "Lucas",
                Telefone = 00928922,
                Email = "arroba@arroba",
                Nacionalidade = "Cubano",
                Ra = 3812938,
            };
            aluno.Endereco.Rua = "Rua Domingos Rizzo";
            aluno.Endereco.Cidade = "Jardim Nópolis";
            aluno.Endereco.Estado = "Serjipe";
            aluno.DataMatricula.Dia = 13;
            aluno.DataMatricula.Mes = 10;
            aluno.DataMatricula.Ano = 1333;
            aluno.Professor.Nome = "Glenilsson";
            aluno.Professor.DataNascimento.Dia = 21;
            aluno.Professor.DataNascimento.Mes = 10;
            aluno.Professor.DataNascimento.Ano = 2048;
            aluno.Professor.Endereco.Rua = "Rua Onório Reberbes";
            aluno.Professor.Telefone = 3902193;
            aluno.Professor.Email = "luras@arroba";
            aluno.Professor.Nacionalidade = "Romano";
            aluno.Professor.Endereco.Cidade = "Sutão";
            aluno.Professor.Endereco.Estado = "Santa Catarina";
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
