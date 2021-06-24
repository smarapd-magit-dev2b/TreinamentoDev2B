using System;
using Domain;
using Domain.Exercicio3;
using Domain.Exercicio4;

namespace Aula2Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            static void Ex1 (){
                Console.WriteLine("Informe o código do item: ");
                int codigo = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o nome do item: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Informe a quantidade: ");
                int qtd = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o preço: ");
                decimal preco = decimal.Parse(Console.ReadLine());

                ItemVenda item = new ItemVenda(codigo, nome, qtd, preco);

                Console.Clear();

                item.EscreverInformacoes();
                Console.ReadLine();
            }

            static void Ex2()
            {
                Console.WriteLine("Informe o nome do funcionário: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Informe o sobrenome do funcionário: ");
                string sobrenome = Console.ReadLine();

                Console.WriteLine("Informe o salário mensal: ");
                decimal salario = decimal.Parse(Console.ReadLine());

                Empregado funcionario = new Empregado(nome, sobrenome, salario);

                Console.Clear();

                funcionario.EscreverInformacoes();

                Console.ReadLine();
            }

            static void Ex3()
            {
                Console.WriteLine("Informe o dia: ");
                int d = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o mês: ");
                int m = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o ano: ");
                int a = int.Parse(Console.ReadLine());

                Data data = new Data(d, m, a);

                Console.WriteLine(data.ToString());
                data.ProximoDia();
                Console.WriteLine(data.ToString());

                Console.ReadLine();
            }

            static void Ex4()
            {
                Aluno aluno = new Aluno();

                aluno.Nome = "Filipe";
                aluno.DataNascimento = Convert.ToDateTime("18/11/1996");
                aluno.Endereco = "Rua Lima";
                aluno.Telefone = "16991943816";
                aluno.Email = "filipe.cezar@gmail.com";
                aluno.Nacionalidade = "Brasileiro";
                aluno.Cidade = "Sertãozinho";
                aluno.Estado = "SP";
                aluno.DataMatricula = Convert.ToDateTime("24/06/2021");
                aluno.RA = 1234;

                aluno.Professor.Nome = "Glenison";
                aluno.Professor.DataNascimento = Convert.ToDateTime("01/02/1986");
                aluno.Professor.Endereco = "Rua Antonio Machado";
                aluno.Professor.Telefone = "16991234567";
                aluno.Professor.Email = "glenison@gmail.com";
                aluno.Professor.Nacionalidade = "brasileiro";
                aluno.Professor.Cidade = "Ribeirão Preto";
                aluno.Professor.Estado = "SP";
                aluno.Professor.DataAdmissao = Convert.ToDateTime("22/06/2021");
                aluno.Professor.RegistroProfessor = 123456;
                aluno.Professor.Salario = 1999m;

                aluno.Professor.Disciplina.Nome = "Programação C#";
                aluno.Professor.Disciplina.CID = 1;
                aluno.Professor.Disciplina.Curso = "Programação";
                aluno.Professor.Disciplina.DataInclusao = Convert.ToDateTime("20/06/2021");

                Console.WriteLine("Informações Aluno");
                Console.WriteLine("Nome: " + aluno.Nome);
                Console.WriteLine("Data de Nascimento: " + aluno.DataNascimento.ToShortDateString());
                Console.WriteLine("Endereço: " + aluno.Endereco);
                Console.WriteLine("Telefone: " + aluno.Telefone);
                Console.WriteLine("Email" + aluno.Email);
                Console.WriteLine("Nacionalidade: " + aluno.Nacionalidade);
                Console.WriteLine("Cidade: " + aluno.Cidade);
                Console.WriteLine("Estado:" + aluno.Estado);
                Console.WriteLine("Data da matrícula: " + aluno.DataMatricula.ToShortDateString());
                Console.WriteLine("Registro do Aluno (RA): " + aluno.RA);

                Console.WriteLine("\nInformações Professor");
                Console.WriteLine("Nome: " + aluno.Professor.Nome);
                Console.WriteLine("Data de Nascimento: " + aluno.Professor.DataNascimento.ToShortDateString());
                Console.WriteLine("Endereço: " + aluno.Professor.Endereco);
                Console.WriteLine("Telefone: " + aluno.Professor.Telefone);
                Console.WriteLine("Email" + aluno.Professor.Email);
                Console.WriteLine("Nacionalidade: " + aluno.Professor.Nacionalidade);
                Console.WriteLine("Cidade: " + aluno.Professor.Cidade);
                Console.WriteLine("Estado:" + aluno.Professor.Estado);
                Console.WriteLine("Data de admissão: " + aluno.Professor.DataAdmissao.ToShortDateString());
                Console.WriteLine("Registro do Professor: " + aluno.Professor.RegistroProfessor);
                Console.WriteLine("Salário R$: " + aluno.Professor.Salario);

                Console.WriteLine("\nInformações Disciplina");
                Console.WriteLine("Nome: " + aluno.Professor.Disciplina.Nome);
                Console.WriteLine("Código de identificação (CID): " + aluno.Professor.Disciplina.CID);
                Console.WriteLine("Data de inclusão: " + aluno.Professor.Disciplina.DataInclusao.ToShortDateString());
            }
        }
    }
}
