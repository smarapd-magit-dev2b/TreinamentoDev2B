using Aula02.ClassesAula02;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02
{
    public class ExerciciosAula02
    {
        public void Execute()
        {
            //Exercicio01();
            //Exercicio02();
            //Exercicio03();
            Exercicio04();
            //Exercicio05();
        }
        private void Exercicio01()
        {
            Console.Write("Digite o número do item: ");
            int NumeroItem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a descrição do item: ");
            string Descricao = (Console.ReadLine());
            Console.Write("Digite quantidade comprada deste item: ");
            int QtdComprada = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor unitário item: ");
            decimal PrecoUnit = Convert.ToDecimal(Console.ReadLine());

            CItemVenda item1 = new CItemVenda(NumeroItem, Descricao, QtdComprada, PrecoUnit);

            item1.calculaValorTotal();
            item1.EscreverValores();
        }

        private void Exercicio02()
        {
            Console.Write("Digite o nome do funcionário: ");
            string Nome = (Console.ReadLine());
            Console.Write("Digite o sobrenome do funcionário: ");
            string Sobrenome = (Console.ReadLine());
            Console.Write("Digite o salário mensal do funcionário: ");
            decimal SalarioMensal = Convert.ToDecimal(Console.ReadLine());

            CEmpregados empregado1 = new CEmpregados(Nome, Sobrenome, SalarioMensal);

            empregado1.EscreverValores();
            empregado1.calculaSalarioAtual();
            empregado1.reajustarSalario();
        }
        private void Exercicio03()
        {
            int dia = 0, mes = 0, ano = 0;
            bool rodando = true;

            while (rodando)
            {
                Console.Write("Dia: ");
                dia = int.Parse(Console.ReadLine());

                if (dia > 0 && dia <= 30)
                {

                    Console.Write("Mês: ");
                    mes = int.Parse(Console.ReadLine());
                    if (mes > 0 && mes <= 12)
                    {

                        Console.Write("Ano: ");
                        ano = int.Parse(Console.ReadLine());
                        if (ano > 0)
                        {
                            rodando = false;
                        }
                        else
                            Console.WriteLine("Ano Invalido...");
                    }
                    else
                        Console.WriteLine("Mês Invalido...");
                }
                else
                    Console.WriteLine("Dia Invalido...");
            }
            CData data = new CData(dia, mes, ano);

            Console.WriteLine(data);
            data.ProximoDia();
        }

        private void Exercicio04()
        {
            CAluno aluno = new CAluno();

            //DADOS DO ALUNO
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Data de Nascimento do Aluno: ");
            aluno.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Endereço: ");
            aluno.Endereço = Console.ReadLine();

            Console.Write("Telefone: ");
            aluno.Telefone = Convert.ToInt32(Console.ReadLine());

            Console.Write("Email: ");
            aluno.Email = Console.ReadLine();

            Console.Write("Nacionalidade: ");
            aluno.Nacionalidade = Console.ReadLine();

            Console.Write("Cidade: ");
            aluno.Cidade = Console.ReadLine();

            Console.Write("Estado: ");
            aluno.Estado = Console.ReadLine();

            Console.Write("Data de Matricula: ");
            aluno.DataMatricula = DateTime.Parse(Console.ReadLine());

            Console.Write("RA: ");
            aluno.RA = long.Parse(Console.ReadLine());

            Console.Clear();

            //DADOS DO PROFESSOR
            Console.Write("Nome do Professor: ");
            aluno.Professor.Nome = Console.ReadLine();

            Console.Write("Data de Nascimento: ");
            aluno.Professor.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Rua: ");
            aluno.Professor.Endereço = Console.ReadLine();

            Console.Write("Telefone: ");
            aluno.Professor.Telefone = int.Parse(Console.ReadLine());

            Console.Write("Email: ");
            aluno.Professor.Email = Console.ReadLine();

            Console.Write("Nascionalidade: ");
            aluno.Professor.Nacionalidade = Console.ReadLine();

            Console.Write("Cidade: ");
            aluno.Professor.Cidade = Console.ReadLine();

            Console.Write("Estado: ");
            aluno.Professor.Estado = Console.ReadLine();

            Console.Write("Data de Adimissão: ");
            aluno.Professor.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.Write("CNH: ");
            aluno.Professor.CNH = long.Parse(Console.ReadLine());

            Console.Write("Salário: R$");
            aluno.Professor.Salario = decimal.Parse(Console.ReadLine());

            Console.Write("Registro: ");
            aluno.Professor.RegistroProfessor = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("------------------------------------FORMULÁRIO DO ALUNO-----------------------------------");
            Console.WriteLine($"\nNome: {aluno.Nome}\nData de Nascimento: {aluno.DataNascimento.ToShortDateString()}");
            Console.WriteLine($"\nEndereço: {aluno.Endereço}\nTelefone: {aluno.Telefone}");
            Console.WriteLine($"\nEmail: {aluno.Email}\nNascionalidade: {aluno.Nacionalidade}");
            Console.WriteLine($"\nCidade: {aluno.Cidade}/{aluno.Estado}");
            Console.WriteLine($"\nData de Matricula: {aluno.DataMatricula.ToShortDateString()}\nRA: {aluno.RA}");

            Console.WriteLine("----------------------------------FORMULÁRIO DO PROFESSOR---------------------------------");
            Console.WriteLine($"\nNome: {aluno.Professor.Nome}\nData de Nascimento: {aluno.Professor.DataNascimento.ToShortDateString()}");
            Console.WriteLine($"\nEndereço: {aluno.Endereço}\nTelefone: {aluno.Professor.Telefone}");
            Console.WriteLine($"\nEmail: {aluno.Professor.Email}\nNasciolidade: {aluno.Professor.Nacionalidade}");
            Console.WriteLine($"\nCidade: {aluno.Professor.Cidade}/{aluno.Professor.Estado}");
            Console.WriteLine($"\nCNH: {aluno.Professor.CNH}\nData de Adimissão: {aluno.Professor.DataAdmissao.ToShortDateString()}");
            Console.WriteLine($"\nResgistro do Professor: {aluno.Professor.RegistroProfessor}\nSalario: R${aluno.Professor.Salario}");
            Console.WriteLine($"\nDisciplina: {aluno.Professor.Disciplina.GetNome()}\nCurso:{aluno.Professor.Disciplina.GetCurso()}");
            Console.WriteLine($"\nCID: {aluno.Professor.Disciplina.GetCID()}\nData de Inclusão: {aluno.Professor.Disciplina.GetDate().ToShortDateString()}");
        }
        private void Exercicio05()
        {
            Console.WriteLine("Hello World");

        }
    }
}