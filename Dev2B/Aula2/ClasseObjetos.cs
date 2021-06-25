using Domain;
using System;

namespace Aula2
{
    public class ClasseObjetos
    {
        public void Execute()
        {
            Exercicio1();
            Exercicio2();
            Exercicio3();
            Exercicio4();
        }

        private void Exercicio1()
        {
            Console.WriteLine("Numero do item: ");
            int numeroDoItem = int.Parse(Console.ReadLine());
            Console.WriteLine("Descriçao do item: ");
            string descricao = Console.ReadLine();
            Console.WriteLine("Quantidade do item: ");
            int quantidadeComprada = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor do item: ");
            decimal valor = decimal.Parse(Console.ReadLine());


            ItemVenda itemVenda = new ItemVenda(numeroDoItem, descricao, quantidadeComprada, valor);
            Console.WriteLine($"O valor total de {itemVenda.QuantidadeComprada} {itemVenda.Desgricao} comprado(s) é {itemVenda.CalcularValorTotal()}");
        }

        private void Exercicio2()
        {
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Sobrenome: ");
            string sobrenome = Console.ReadLine();
            Console.WriteLine("Salario mensal: ");
            decimal salario = decimal.Parse(Console.ReadLine());


            Empregado empregado = new Empregado(nome, sobrenome, salario);


            Console.WriteLine($"Salario anual: {empregado.CalcularSalarioAnual()}");
            Console.WriteLine("Salario anterior: " + empregado.SalarioMensal);
            empregado.ReajustarSalario(50);
            Console.WriteLine("Salario ajustado: " + empregado.SalarioMensal);
            Console.WriteLine($"Salario anual reajustado: {empregado.CalcularSalarioAnual()}");

        }

        private void Exercicio3()
        {
            Data data = new Data(30, 12, 2019);
            Console.WriteLine(data);
            data.ProximoDia();
            Console.WriteLine(data);

            Data data2 = new Data();
            Console.WriteLine(data2);
            data2.ProximoDia();
            Console.WriteLine(data2);
        }

        private void Exercicio4()
        {
            Endereco enderecoAluno = new Endereco("Ribeirao Preto", "São Paulo", "Rua tanto faz");
            Endereco enderecoProfessor = new Endereco("Sertaozinho", "São Paulo", "Rua qualquer");

            Disciplina disciplina = new Disciplina("Programacao 10", 123, "Software", DateTime.Now);

            Professor professor = new Professor()
            {
                Nome = "Glenison",
                DataNascimento = new DateTime(1990, 1, 1),
                Disciplina = disciplina,
                CNH = "251615616165",
                DataAdimicao = DateTime.Now,
                Email = "Alguem email qualquer",
                Nacionalidade = "Ingles",
                RegistroProfessor = "56165161651561",
                Salario = 5000m,
                Telefone = "1515151515",
                Endereco = enderecoProfessor
            };


            Aluno aluno = new Aluno()
            {
                Nome = "Gabriel",
                Email = "emailqualquer@email.com",
                Nacionalidade = "Brasileiro",
                Telefone = "8282828282",
                DataMatricula = DateTime.Now,
                DataNascimento = new DateTime(1998, 12, 1),
                Endereco = enderecoAluno,
                RA = "827333",
                Professor = professor
            };

            Console.WriteLine($"************* ALUNO *************");
            Console.WriteLine($"Nome: {aluno.Nome}");
            Console.WriteLine($"Nacionalidade: {aluno.Nacionalidade}");
            Console.WriteLine($"Email: {aluno.Email}");
            Console.WriteLine($"Telefone: {aluno.Telefone}");
            Console.WriteLine($"Data da Matricula: {aluno.DataMatricula.ToShortDateString()}");
            Console.WriteLine($"Data de nascimento: {aluno.DataNascimento.ToShortDateString()}");
            Console.WriteLine($"Registro de Aluno (RA): {aluno.RA}");
            Console.WriteLine($"Rua: {aluno.Endereco.Rua}");
            Console.WriteLine($"Cidade: {aluno.Endereco.Cidade}");
            Console.WriteLine($"Estado: {aluno.Endereco.Estado}");
            Console.WriteLine("\n");
            Console.WriteLine($"************* Professor *************");
            Console.WriteLine($"Nome: {professor.Nome}");
            Console.WriteLine($"Nacionalidade: {professor.Nacionalidade}");
            Console.WriteLine($"Email: {professor.Email}");
            Console.WriteLine($"Telefone: {professor.Telefone}");
            Console.WriteLine($"Resgitro de Professor: {professor.RegistroProfessor}");
            Console.WriteLine($"Data de adimiçao: {professor.DataAdimicao.ToShortDateString()}");
            Console.WriteLine($"Data de nascimento: {professor.DataNascimento.ToShortDateString()}");
            Console.WriteLine($"Salario: {professor.Salario}");
            Console.WriteLine($"CNH: {professor.CNH}");
            Console.WriteLine($"Rua: {professor.Endereco.Rua}");
            Console.WriteLine($"Cidade: {professor.Endereco.Cidade}");
            Console.WriteLine($"Estado: {professor.Endereco.Estado}");
            Console.WriteLine($"Nome da disciplina: {professor.Disciplina.Nome}");
            Console.WriteLine($"CID Disciplica: {professor.Disciplina.CID}");
            Console.WriteLine($"Curso: {professor.Disciplina.Curso}");
            Console.WriteLine($"Data Inclusao: {professor.Disciplina.DataInclusao.ToShortDateString()}");
            
        }

    }
}