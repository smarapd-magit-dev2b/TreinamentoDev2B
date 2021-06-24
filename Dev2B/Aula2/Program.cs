using Aula2.Exercicio1;
using Aula2.Exercicio2;
using Aula2.Exercicio3;
using Aula2.Exercicio4;
using System;

namespace Aula2
{    
    class Program
    {
        static void Ex1()
        {            
            Console.WriteLine("Insira o numero do item: ");
            int numItem= Convert.ToInt32(Console.ReadLine());
            //var numItem = Convert.ToInt32(Console.ReadLine());
            // pode usar o tipo var no lugar de int por exemplo

            Console.WriteLine("Insira a descrição do item: ");
            string descricaoItem = Console.ReadLine();

            Console.WriteLine("Insira a quantidade do item: ");
            int quantidade= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o preço do item: ");
            decimal precoUnitario= Convert.ToDecimal(Console.ReadLine());

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

            Empregado empregado1 = new Empregado(nome, sobrenome,salario);

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
            Console.WriteLine("Preencha os dados do Aluno:");
            string nomeA= Console.ReadLine();
            DateTime dataNascimentoA= Convert.ToDateTime(Console.ReadLine());
            string enderecoA= Console.ReadLine();
            string telefoneA= Console.ReadLine();
            string emailA= Console.ReadLine();
            string nacionalidadeA= Console.ReadLine();
            string cidadeA= Console.ReadLine();
            string estadoA= Console.ReadLine();
            DateTime dataMatricula= Convert.ToDateTime(Console.ReadLine());
            string registroAluno= Console.ReadLine();

            Console.WriteLine("Preencha os dados do Professor:");
            string nomeP= Console.ReadLine(); ;
            DateTime dataNascimentoP= Convert.ToDateTime(Console.ReadLine()); ;
            string enderecoP= Console.ReadLine(); ;
            string telefoneP= Console.ReadLine(); ;
            string emailP= Console.ReadLine(); ;
            string nacionalidadeP= Console.ReadLine(); ;
            string cidadeP= Console.ReadLine(); ;
            string estadoP= Console.ReadLine(); ;
            string cnh= Console.ReadLine(); ;
            DateTime dataAdmissao= Convert.ToDateTime(Console.ReadLine()); ;
            string registroProfessor= Console.ReadLine(); ;
            decimal salario= Convert.ToDecimal(Console.ReadLine()); ;

            Console.WriteLine("Preencha os dados da Disciplina:");
            string nomeD= Console.ReadLine(); ;
            string cid= Console.ReadLine(); ;
            string curso= Console.ReadLine(); ;
            DateTime datainclusao= Convert.ToDateTime(Console.ReadLine());


            
            
            Disciplina disciplina1 = new Disciplina(nomeD, cid, curso, datainclusao);
            Professor professor1 = new Professor(nomeP, dataNascimentoP, enderecoP, telefoneP, emailP, nacionalidadeP, cidadeP, estadoP, cnh, dataAdmissao, registroProfessor, salario,disciplina1);
            Aluno aluno1 = new Aluno(nomeA, dataNascimentoA, enderecoA, telefoneA, emailA, nacionalidadeA, cidadeA, estadoA, dataMatricula, registroAluno, professor1);
            aluno1.EscreverAluno();

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Ex1();
            //Ex2();
            //Ex3();
            Ex4();
        }
    }
}
