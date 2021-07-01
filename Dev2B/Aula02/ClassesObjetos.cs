using Aula02.Classes;
using System;

namespace Aula02
{
    public class ClassesObjetos
    {
        public void Exercicio01()
        {
            ItemVenda item = new ItemVenda(10, "Arroz", 20, 5);

            Console.WriteLine(item.ValorFatura());
            Console.ReadLine();
        }

        public void Exercicio02()
        {
            Empregado empregado = new Empregado("Jardel", "Sobrenome", 1.000m);

            Console.WriteLine(empregado.CalcularSalarioAtual());


            Console.WriteLine("O Novo salário será: " + empregado.ReajustarSalario(50));

        }

        public void Exercicio03()
        {
            Console.WriteLine("Informe o dia: ");
            int dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o mês: ");
            int mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            Data data = new Data(dia, mes, ano);

            data.ShowDate();
        }
        private void Exercicio04()
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o Nome:");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite a Data de Nascimento:");
            aluno.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Endereço:");
            aluno.Endereco = Console.ReadLine();

            Console.WriteLine("Digite o Telefone:");
            aluno.Telefone = Console.ReadLine();

            Console.WriteLine("Digite O E-mail");
            aluno.Email = Console.ReadLine();

            Console.WriteLine("Digite a Nacionalidade:");
            aluno.Nacionalidade = Console.ReadLine();

            Console.WriteLine("Digite a Cidade:");
            aluno.Cidade = Console.ReadLine();

            Console.WriteLine("Digite o Estado:");
            aluno.Estado = Console.ReadLine();

            Console.WriteLine("Digite a Data da Matrícula:");
            aluno.DataMatricula = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o RA:");
            aluno.RA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome do Professor:");
            aluno.Professor.Nome = Console.ReadLine();

            Console.WriteLine("Digite a Data de Nascimento de Professor:");
            aluno.Professor.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Endereço do Professor:");
            aluno.Professor.Endereco = Console.ReadLine();

            Console.WriteLine("Digite o Telefone do Professor:");
            aluno.Professor.Telefone = Console.ReadLine();

            Console.WriteLine("Digite o E-mail do Professor:");
            aluno.Professor.Email = Console.ReadLine();

            Console.WriteLine("Digite a Nacionalidade do Professor:");
            aluno.Professor.Nacionalidade = Console.ReadLine();

            Console.WriteLine("Digite a Cidade do Professor:");
            aluno.Professor.Cidade = Console.ReadLine();

            Console.WriteLine("Digite o Estado do Professor:");
            aluno.Professor.Estado = Console.ReadLine();

            Console.WriteLine("Digite a CNH do Professor:");
            aluno.Professor.CNH = Console.ReadLine();

            Console.WriteLine("Digite a Data de Admissão do Professor:");
            aluno.Professor.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Registro do Professor:");
            aluno.Professor.RegistroProfessor = Console.ReadLine();

            Console.WriteLine("Digite o Sálario do Professor:");
            aluno.Professor.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome da Disciplina:");
            aluno.Professor.Disciplina.Nome = Console.ReadLine();

            Console.WriteLine("Digite o CID da Disciplina:");
            aluno.Professor.Disciplina.CID = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Curso da Disciplina:");
            aluno.Professor.Disciplina.Curso = Console.ReadLine();

            Console.WriteLine("Digite a Data de Inclusão da Disciplina:");
            aluno.Professor.Disciplina.DataInclusao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine();

            Console.WriteLine("Nome:" + aluno.Nome);

            Console.WriteLine("Data de Nascimento:" + aluno.DataNascimento.ToShortDateString());

            Console.WriteLine("Endereço:" + aluno.Endereco);

            Console.WriteLine("Telefone:" + aluno.Telefone);

            Console.WriteLine("E-mail:" + aluno.Email);

            Console.WriteLine("Nacionalidade:" + aluno.Nacionalidade);

            Console.WriteLine("Cidade:" + aluno.Cidade);

            Console.WriteLine("Estado:" + aluno.Estado);

            Console.WriteLine("Data da Matrícula:" + aluno.DataMatricula.ToShortDateString());

            Console.WriteLine("RA:" + aluno.RA);

            Console.WriteLine("Nome de Professor:" + aluno.Professor.Nome);

            Console.WriteLine("Data de Nascimento do Professor: " + aluno.Professor.DataNascimento.ToShortDateString());

            Console.WriteLine("Endereço do Professor:" + aluno.Professor.Endereco);

            Console.WriteLine("Telefone do Professor:" + aluno.Professor.Telefone);

            Console.WriteLine("E-mail do Professor:" + aluno.Professor.Email);

            Console.WriteLine("Nacionalidade do Professor:" + aluno.Professor.Nacionalidade);

            Console.WriteLine("Cidade do Professor:" + aluno.Professor.Cidade);

            Console.WriteLine("Estado do Professor:" + aluno.Professor.Estado);

            Console.WriteLine("CNH do Professor:" + aluno.Professor.CNH);

            Console.WriteLine("Data da Admissão do Professor:" + aluno.Professor.DataAdmissao.ToShortDateString());

            Console.WriteLine("Registro do Professor:" + aluno.Professor.RegistroProfessor);

            Console.WriteLine("Salário do Professor:" + aluno.Professor.Salario);

            Console.WriteLine("Nome da Disciplina:" + aluno.Professor.Disciplina.Nome);

            Console.WriteLine("CID da Disciplina:" + aluno.Professor.Disciplina.CID);

            Console.WriteLine("Curso da Disciplina:" + aluno.Professor.Disciplina.Curso);

            Console.WriteLine("Data de Inclusão da Disciplina:" + aluno.Professor.Disciplina.DataInclusao.ToShortDateString());

            Console.WriteLine("____________________________________________________________________");

            Console.ReadLine();

        }

        public void Execute()
        {
            //Exercicio01();
            //Exercicio02();
            //Exercicio03();
            //Exercicio04();
        }
    }
}
