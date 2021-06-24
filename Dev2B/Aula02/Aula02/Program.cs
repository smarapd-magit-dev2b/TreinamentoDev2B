using System;
using System.Globalization;
using Aula02.Exercicio01;
using Aula02.Exercicio02;
using Aula02.Exercicio03;
using Aula02.Exercicio04;

namespace Aula02 {
    class Program {

        static void Main(string[] args) {
            //Exercicio01();
            //Exercicio02();
            //Exercicio03();
            //Exercicio04();
        }
        static void Exercicio01() {
            int codigo, quantidadeComprada;
            string descricao;
            decimal PrecoAux;

            Console.Write("Digite o código do produto: ");
            codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do produto: ");
            descricao = Console.ReadLine();

            Console.Write("Digite a quantidade comprada: ");
            quantidadeComprada = int.Parse(Console.ReadLine());

            if (quantidadeComprada < 0) {
                quantidadeComprada = 0;
            }

            Console.Write("Digite o preço unitario R$");
            PrecoAux = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (PrecoAux < 0) {
                PrecoAux = 0m;
            }

            ItemVendas ItemA = new ItemVendas(codigo, descricao, quantidadeComprada, PrecoAux);

            ItemA.CalcularValorTotal();
        }
        static void Exercicio02() {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.Write("Salario Mensal R$");
            decimal salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario < 0) {
                salario = 0.0m;
            }

            Empregados empregadoA = new Empregados(nome, sobrenome, salario);

            empregadoA.CalcularSalarioAtual();
            Console.Write("Qual procentagem do reajuste do salário: ");
            decimal porcentagem = decimal.Parse(Console.ReadLine());

            empregadoA.CalcularReajuste(porcentagem);

        }
        static void Exercicio03() {
            int dia = 0, mes = 0, ano = 0;
            bool rodando = true;

            while (rodando) {
                Console.Write("Dia: ");
                dia = int.Parse(Console.ReadLine());

                if (dia > 0 && dia <= 30) {

                    Console.Write("Mês: ");
                    mes = int.Parse(Console.ReadLine());
                    if (mes > 0 && mes <= 12) {

                        Console.Write("Ano: ");
                        ano = int.Parse(Console.ReadLine());
                        if (ano > 0) {
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
            Data data = new Data(dia, mes, ano);

            Console.WriteLine(data);
            data.ProximoDia();
        }
        static void Exercicio04() {
            //Instaciando a classe Aluno
            Aluno aluno = new Aluno();

            aluno.Nome = "Bruno";
            aluno.DataNascimento = Convert.ToDateTime("15 / 10 / 98");
            aluno.Endereço = "José Melos dos Reis";
            aluno.Telefone = Convert.ToInt32(123456789);
            aluno.Email = "aluno@hotmail.com";
            aluno.Nascionalidade = "brasilieiro";
            aluno.Cidade = "Sertãozinho";
            aluno.Estado = "São Paulo";
            aluno.DataMatricula = Convert.ToDateTime("02 / 02 / 2020");
            aluno.RA = 12345678910;

            //Instanciando a Classe Professor
            aluno.Professor = new Professor();
            aluno.Professor.Nome = "Glenison";
            aluno.Professor.DataNascimento = Convert.ToDateTime("12/11/2345");
            aluno.Professor.Endereço = "José Melos dos Reis";
            aluno.Professor.Telefone = 123456789;
            aluno.Professor.Email = "professor@hotmail.com";
            aluno.Professor.Nascionalidade = "brasilieiro";
            aluno.Professor.Cidade = "Ribeirão Preto";
            aluno.Professor.Estado = "São Paulo";
            aluno.Professor.DataAdimissao = Convert.ToDateTime("02 / 02 / 2020");
            aluno.Professor.CNH = 12345678910;
            aluno.Professor.Salario = 1000.00m;
            aluno.Professor.RegistroProfessor = 987654321;

            //Instanciando a Classe Disciplina
            aluno.Professor.Disciplina.Nome = "Progamação";
            aluno.Professor.Disciplina.CID = 321;
            aluno.Professor.Disciplina.Curso = "ADS";
            aluno.Professor.Disciplina.DataInclusao = Convert.ToDateTime("01 / 01 / 2015");

            Console.WriteLine("------------------------------------FICHA ALUNO-----------------------------------\n" +
                              $"\nNome: {aluno.Nome}\nData de Nascimento: {aluno.DataNascimento}\n" +
                              $"\nEndereço: {aluno.Endereço}\nTelefone: {aluno.Telefone}\n" +
                              $"\nEmail: {aluno.Email}\nNascionalidade: {aluno.Nascionalidade}\n" +
                              $"\nCidade: {aluno.Cidade}/{aluno.Estado}\n" +
                              $"\nData de Matricula{aluno.DataMatricula}\nRA: {aluno.RA}");
            
            Console.WriteLine("----------------------------------FICHA PROFESSOR---------------------------------\n" +
                             $"\nNome: {aluno.Professor.Nome}\nData de Nascimento: {aluno.Professor.DataNascimento}\n" +
                             $"\nEndereço: {aluno.Endereço}\nTelefone: {aluno.Professor.Telefone}\n" +
                             $"\nEmail: {aluno.Professor.Email}\nNasciolidade: {aluno.Professor.Nascionalidade}\n" +
                             $"\nCidade: {aluno.Professor.Cidade}/{aluno.Professor.Estado}\n" +
                             $"\nCNH: {aluno.Professor.CNH}\nData de Adimissão: {aluno.Professor.DataAdimissao}\n" +
                             $"\nResgistro do Professor: {aluno.Professor.RegistroProfessor}\nSalario: R${aluno.Professor.Salario}\n" +
                             $"\nDisciplina: {aluno.Professor.Disciplina.Nome}\nCurso:{aluno.Professor.Disciplina.Curso}\n" +
                             $"\nCID: {aluno.Professor.Disciplina.CID}\nData de Inclusão: {aluno.Professor.Disciplina.DataInclusao}");
        }
    }
}



