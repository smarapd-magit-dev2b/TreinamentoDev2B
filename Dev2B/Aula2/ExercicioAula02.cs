using System;
using System.Globalization;

using Aula02.Exercicio01;
using Aula02.Exercicio02;
using Aula02.Exercicio03;
using Aula02.Exercicio04;

namespace Aula2 {
    public class ExercicioAula02 {
        public void Executar() {
            Exercicio01();
            Exercicio02();
            Exercicio03();
            Exercicio04();
        }
        private void Exercicio01() {
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
        private void Exercicio02() {
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
        private void Exercicio03() {
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
        private void Exercicio04() {

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Data de Nascimento do Aluno: ");
            aluno.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Endereço: ");
            aluno.Endereço = Console.ReadLine();

            Console.Write("Telefone: ");
            aluno.Telefone = int.Parse(Console.ReadLine());

            Console.Write("Email: ");
            aluno.Email = Console.ReadLine();

            Console.Write("Nacionalidade: ");
            aluno.Nascionalidade = Console.ReadLine();

            Console.Write("Cidade: ");
            aluno.Cidade = Console.ReadLine();

            Console.Write("Estado: ");
            aluno.Estado = Console.ReadLine();

            Console.Write("Data de Matricula: ");
            aluno.DataMatricula = DateTime.Parse(Console.ReadLine());

            Console.Write("RA: ");
            aluno.RA = long.Parse(Console.ReadLine());

            Console.Clear();

            //dados professor
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
            aluno.Professor.Nascionalidade = Console.ReadLine();

            Console.Write("Cidade: ");
            aluno.Professor.Cidade = Console.ReadLine();

            Console.Write("Estado: ");
            aluno.Professor.Estado = Console.ReadLine();

            Console.Write("Data de Adimissão: ");
            aluno.Professor.DataAdimissao = DateTime.Parse(Console.ReadLine());

            Console.Write("CNH: ");
            aluno.Professor.CNH = long.Parse(Console.ReadLine());

            Console.Write("Salário: R$");
            aluno.Professor.Salario = decimal.Parse(Console.ReadLine());

            Console.Write("Registro: ");
            aluno.Professor.RegistroProfessor = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("------------------------------------FICHA ALUNO-----------------------------------\n" +
                              $"\nNome: {aluno.Nome}\nData de Nascimento: {aluno.DataNascimento.ToShortDateString()}\n" +
                              $"\nEndereço: {aluno.Endereço}\nTelefone: {aluno.Telefone}\n" +
                              $"\nEmail: {aluno.Email}\nNascionalidade: {aluno.Nascionalidade}\n" +
                              $"\nCidade: {aluno.Cidade}/{aluno.Estado}\n" +
                              $"\nData de Matricula: {aluno.DataMatricula.ToShortDateString()}\nRA: {aluno.RA}");

            Console.WriteLine("----------------------------------FICHA PROFESSOR---------------------------------\n" +
                             $"\nNome: {aluno.Professor.Nome}\nData de Nascimento: {aluno.Professor.DataNascimento.ToShortDateString()}\n" +
                             $"\nEndereço: {aluno.Endereço}\nTelefone: {aluno.Professor.Telefone}\n" +
                             $"\nEmail: {aluno.Professor.Email}\nNasciolidade: {aluno.Professor.Nascionalidade}\n" +
                             $"\nCidade: {aluno.Professor.Cidade}/{aluno.Professor.Estado}\n" +
                             $"\nCNH: {aluno.Professor.CNH}\nData de Adimissão: {aluno.Professor.DataAdimissao.ToShortDateString()}\n" +
                             $"\nResgistro do Professor: {aluno.Professor.RegistroProfessor}\nSalario: R${aluno.Professor.Salario}\n" +
                             $"\nDisciplina: {aluno.Professor.Disciplina.GetNome()}\nCurso:{aluno.Professor.Disciplina.GetCurso()}\n" +
                             $"\nCID: {aluno.Professor.Disciplina.GetCID()}\nData de Inclusão: {aluno.Professor.Disciplina.GetDate().ToShortDateString()}");
        }
    }
}
