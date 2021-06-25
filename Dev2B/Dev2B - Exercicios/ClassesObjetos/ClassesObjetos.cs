using Aula2.Classes;
using System;


namespace Aula2
{
    public class ClassesObjetos
    {
        public void Execute()
        {
            Exercicio1();
            Exercicio2();
            Exercicio3();
            Exercicios4();
        }
        private void Exercicio1()
        {
            Console.WriteLine("Exercicio 1 - Classes & Objetos");
            int opcao;

            ItemVenda feijao = new ItemVenda(1, "Feijão Broto Legal", -10.00m, -5);
            ItemVenda arroz = new ItemVenda(2, "Arroz do Bom", 15.00m, 2);

            do
            {
                Console.WriteLine("\n\n1) Feijão.\n2) Arroz.\n0) Sair.\nDeseja mostrar os dados de qual produto?");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (opcao == 1)
                {
                    feijao.validacoes();
                    feijao.dados();
                }
                if (opcao == 2)
                {
                    arroz.validacoes();
                    arroz.dados();
                }
                
            } while (opcao != 0);
        }

        private void Exercicio2()
        {
            Console.WriteLine("Exercicio 2 - Classes & Objetos");
            int escolha;

            Empregado Empregado1 = new Empregado("João", "Paulo", 2000.00m);
            Empregado Empregado2 = new Empregado("Pedro", "Augusto", 1500.00m);
            Empregado Empregado3 = new Empregado("João", "Paulo", 3000.00m);

            Console.WriteLine("1) Monstrar os empregados.\n2) Mostrar salario anual dos empregados.\n3) Fazer reajuste de 25% no salario dos empregados.\nResposta: ");
            escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    {
                        Empregado1.dados();
                        Empregado2.dados();
                        Empregado3.dados();
                        break;
                    }
                case 2:
                    {
                        Empregado1.SalarioAnual();
                        Empregado2.SalarioAnual();
                        Empregado3.SalarioAnual();
                        break;
                    }
                case 3:
                    {
                        Empregado1.Reajuste();
                        Empregado2.Reajuste();
                        Empregado3.Reajuste();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Desligando...");
                        break;
                    }

            }
        }

        private void Exercicio3()
        {
            Console.WriteLine("Exercicio 3 - Classes & Objetos");
            string resposta;

            Data data = new Data(5, 10, 2021);

            Console.WriteLine($"{data.ToString()}");
            do
            {
                Console.WriteLine("Deseja consulta a data seguinte?");
                resposta = Console.ReadLine();

                if (resposta == "sim")
                {
                    data.nextDay();
                    Console.WriteLine($"{data.ToString()}");
                }
                else
                {
                    Console.WriteLine("Saindo...");
                }
            } while (resposta != "nao");
        }

        private void Exercicios4()
        {
            Console.WriteLine("Exercicio 4 - Classes & Objetos");
            Aluno Aluno = new Aluno("Gabriel")
            {

                Endereco = "Tijolos Amarelos",
                Email = "gab@gmail.com",
                Nacionalidade = "Brasileiro",
                Cidade = "Ribeirã Preto",
                Estado = "SP",
                Telefone = "(16)12345-7890",
                RA = "2468791",
            };


            Console.WriteLine("Inserção de dados de professor!");
            Console.WriteLine("Nome: ");
            Aluno.Professor.Nome = Console.ReadLine();
            Console.WriteLine("Endereço: ");
            Aluno.Professor.Endereco = Console.ReadLine();
            Console.WriteLine("Estado: ");
            Aluno.Professor.Estado = Console.ReadLine();
            Console.WriteLine("Nacionalidade : ");
            Aluno.Professor.Nacionalidade = Console.ReadLine();
            Console.WriteLine("Cidade: ");
            Aluno.Professor.Cidade = Console.ReadLine();
            Console.WriteLine("CNH: ");
            Aluno.Professor.CNH = Console.ReadLine();
            Console.WriteLine("Registro: ");
            Aluno.Professor.Registro = Console.ReadLine();
            Console.WriteLine("Salario: ");
            Aluno.Professor.Salario = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Curso que o {Aluno.Professor.Nome} fez: ");
            Aluno.Professor.Disciplina.Curso = Console.ReadLine();
            Console.WriteLine($"Nome do curso feito pelo Professor {Aluno.Professor.Nome}");
            Aluno.Professor.Disciplina.Nome = Console.ReadLine();
            Console.WriteLine($"CID do curso feito pelo Professor {Aluno.Professor.Nome}");
            Aluno.Professor.Disciplina.CID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Data de inclusão ao curso de {Aluno.Professor.Disciplina.Curso}, que esta sendo feito pelo Professor {Aluno.Professor.Nome}");
            Aluno.Professor.Disciplina.Nome = Console.ReadLine();



            Console.WriteLine("");
            Aluno.getDados();
            Aluno.Professor.dadosProfessor();



            Console.ReadLine();
        }

        
    }
}
