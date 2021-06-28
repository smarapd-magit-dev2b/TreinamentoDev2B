using Aula02.Classes;
using System;
using System.Globalization;

namespace Aula02
{
    public class ClassesObjetos
    {
        public void Execute()
        {
            Ex1();
            Ex2();
            Ex3();
            Ex4();
            ExExtra();
            
        }

        static void Ex1()
        {
            Console.WriteLine("Insira o numero do item: ");
            int numItem = Convert.ToInt32(Console.ReadLine());
            //var numItem = Convert.ToInt32(Console.ReadLine());
            // pode usar o tipo var no lugar de int por exemplo

            Console.WriteLine("Insira a descrição do item: ");
            string descricaoItem = Console.ReadLine();

            Console.WriteLine("Insira a quantidade do item: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o preço do item: ");
            decimal precoUnitario = Convert.ToDecimal(Console.ReadLine());

            ItemVenda item1 = new ItemVenda(numItem, descricaoItem, quantidade, precoUnitario);

            item1.EscreverProduto();
        }

        static void Ex2()
        {
            Console.WriteLine("Insira o nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira o sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine("Insira o salario: ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());

            Empregado empregado1 = new Empregado(nome, sobrenome, salario);

            empregado1.EscreverEmpregado();
        }

        static void Ex3()
        {
            Console.WriteLine("Insira o dia: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o mes: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            Data data1 = new Data(dia, mes, ano);

            data1.EscreverData();
        }

        static void Ex4()
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o Nome:");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite a Data de Nascimento:");
            aluno.DataNascimento = DateTime.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            Console.WriteLine("Digite o Endereço:");
            aluno.Endereco = Console.ReadLine();

            Console.WriteLine("Digite o Telefone:");
            aluno.Telefone = Console.ReadLine();

            Console.WriteLine("Digite o E-mail:");
            aluno.Email = Console.ReadLine();

            Console.WriteLine("Digite o Nacionalidade:");
            aluno.Nacionalidade = Console.ReadLine();

            Console.WriteLine("Digite o Cidade:");
            aluno.Cidade = Console.ReadLine();

            Console.WriteLine("Digite o Estado:");
            aluno.Estado = Console.ReadLine();

            Console.WriteLine("Digite o Data da Matrícula:");
            aluno.DataMatricula = DateTime.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            Console.WriteLine("Digite o RA:");
            aluno.RegistroAluno = Console.ReadLine();

            Console.WriteLine("Digite o Nome do Professor:");
            aluno.Professor.Nome = Console.ReadLine();

            Console.WriteLine("Digite a Data Nascimento do Professor:");
            aluno.Professor.DataNascimento = DateTime.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

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

            Console.WriteLine("Digite o CNH do Professor:");
            aluno.Professor.Cnh = Console.ReadLine();

            Console.WriteLine("Digite a Data da Admissão do Professor:");
            aluno.Professor.DataAdmissao = DateTime.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);

            Console.WriteLine("Digite o Registro do Professor:");
            aluno.Professor.RegistroProfessor = Console.ReadLine();

            Console.WriteLine("Digite o Salário do Professor:");
            aluno.Professor.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome da Disciplina:");
            aluno.Professor.Disciplina.Nome = Console.ReadLine();

            Console.WriteLine("Digite o CID da Disciplina:");
            aluno.Professor.Disciplina.Cid = Console.ReadLine();

            Console.WriteLine("Digite o Curso da Disciplina:");
            aluno.Professor.Disciplina.Curso = Console.ReadLine();

            Console.WriteLine("Digite a Data de Inclusão da Disciplina:");
            aluno.Professor.Disciplina.DataInclusao = DateTime.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);
            
            aluno.EscreverAluno();

        }

        static void ExExtra()
        {
            
        }
    }
}
