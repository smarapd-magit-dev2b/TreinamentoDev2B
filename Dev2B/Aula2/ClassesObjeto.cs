using Aula2.Exercicio1Classes;
using Aula2.Exercicio2Classes;
using Aula2.Exercicio3Classes;
using Aula2.Exercicio4Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2
{
    public class ClassesObjeto
    {
        private void Exercicio1()
        {
            ItemVenda item = new ItemVenda();

            Console.Write("Digite o código do item: ");
            item.NumeroItem = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição do item: ");
            item.Descricao = Console.ReadLine();

            Console.Write("Digite a quatidade de item comprada: ");
            item.QuantidadeComprada = int.Parse(Console.ReadLine());

            Console.Write("Digite o preço unitário do item: ");
            item.PrecoUnitario = decimal.Parse(Console.ReadLine());

            Console.WriteLine();

            item.EscreverProduto();
        }

        private void Exercicio2()
        {
            Empregado empregado = new Empregado();

            Console.Write("Digite o nome do empregado: ");
            empregado.Nome = Console.ReadLine();

            Console.Write("Digite o sobrenome do empregado: ");
            empregado.SobreNome = Console.ReadLine();

            Console.Write("Digite o salário mensal do empregado: ");
            empregado.SalarioMensal = decimal.Parse(Console.ReadLine());

            empregado.EscreverEmpregado();
        }

        private void Exercicio3()
        {
            Data data = new Data();
            bool validacao = true;

            Console.Write("Digite um dia: ");
            int dia = int.Parse(Console.ReadLine());

            do
            {
                if (dia > 0 && dia <= 30)
                {
                    data.Dia = dia;
                    validacao = false;
                }
                else
                {
                    Console.WriteLine("Dia inválido!");
                    Console.Write("Insira um dia válido: ");
                    dia = int.Parse(Console.ReadLine());
                }
            } while (validacao);

            validacao = true;

            Console.Write("\nDigite um mes: ");
            int mes = int.Parse(Console.ReadLine());

            do
            {
                if (mes > 0 && mes <= 12)
                {
                    data.Mes = mes;
                    validacao = false;
                }
                else
                {
                    Console.WriteLine("Mes inválido!");
                    Console.Write("Insira um mes válido: ");
                    mes = int.Parse(Console.ReadLine());
                }
            } while (validacao);

            validacao = true;

            Console.Write("\nDigite um ano: ");
            int ano = int.Parse(Console.ReadLine());

            do
            {
                if (ano > 0)
                {
                    data.Ano = ano;
                    validacao = false;
                }
                else
                {
                    Console.WriteLine("Ano inválido!");
                    Console.Write("Insira um ano válido: ");
                    ano = int.Parse(Console.ReadLine());
                }
            } while (validacao);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Dia de hoje: {data.toString()}");
            data.ProximoDia();
            Console.WriteLine($"Próximo dia: {data.toString()}");
        }

        private void Exercicio4()
        {
            Aluno aluno = new Aluno();
            Professor professor = new Professor();
            Disciplina disciplina = new Disciplina();

            Console.WriteLine("----- Preencha os campos abaixo com dados do ALUNO -----");
            Console.Write("Nome: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            aluno.DataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("Endereco: ");
            aluno.Endereco = Console.ReadLine();
            Console.Write("Telefone: ");
            aluno.Telefone = Console.ReadLine();
            Console.Write("Email: ");
            aluno.Email = Console.ReadLine();
            Console.Write("Nacionalidade: ");
            aluno.Nacionalidade = Console.ReadLine();
            Console.Write("Cidade: ");
            aluno.Cidade = Console.ReadLine();
            Console.Write("Estado: ");
            aluno.Estado = Console.ReadLine();
            Console.Write("Data da matrícula: ");
            aluno.DataMatricula = DateTime.Parse(Console.ReadLine());
            Console.Write("Registro do aluno: ");
            aluno.RegistroAluno = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("----- Preencha os campos abaixo com dados do PROFESSOR -----");
            Console.Write("Nome: ");
            aluno.Professor.Nome = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            aluno.Professor.DataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("Endereco: ");
            aluno.Professor.Endereco = Console.ReadLine();
            Console.Write("Telefone: ");
            aluno.Professor.Telefone = Console.ReadLine();
            Console.Write("Email: ");
            aluno.Professor.Email = Console.ReadLine();
            Console.Write("Nacionalidade: ");
            aluno.Professor.Nacionalidade = Console.ReadLine();
            Console.Write("Cidade: ");
            aluno.Professor.Cidade = Console.ReadLine();
            Console.Write("Estado: ");
            aluno.Professor.Estado = Console.ReadLine();
            Console.Write("Cnh: ");
            aluno.Professor.Cnh = Console.ReadLine();
            Console.Write("Data da Admissão: ");
            aluno.Professor.DataAdmissao = DateTime.Parse(Console.ReadLine());
            Console.Write("Registro do professor: ");
            aluno.Professor.RegistroProfessor = Console.ReadLine();
            Console.Write("Salário: ");
            aluno.Professor.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("----- Preencha os campos abaixo com dados da DISCIPLINA -----");
            Console.Write("Nome: ");
            aluno.Professor.Disciplina.Nome = Console.ReadLine();
            Console.Write("Cid: ");
            aluno.Professor.Disciplina.Cid = Console.ReadLine();
            Console.Write("Curso: ");
            aluno.Professor.Disciplina.Curso = Console.ReadLine();
            Console.Write("Data de inclusão: ");
            aluno.Professor.Disciplina.DataInclusao = DateTime.Parse(Console.ReadLine());

            aluno.EscreverAluno();
        }

        public void Executar()
        {
            Exercicio1();
            Exercicio2();
            Exercicio3();
            Exercicio4();
        }
    }
}
