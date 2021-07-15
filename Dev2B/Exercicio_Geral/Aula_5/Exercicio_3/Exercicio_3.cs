using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula_5.Exercicio_3
{
    public class Exercicio_3
    {
    
       public void Executar_Aula5Ex3()
        {

            //Variaveis---------------------

            int val;

            var listaAluno = new List<Atributos>()
            {


            };

            do
            {
                Console.Clear();

                Console.WriteLine("\n * * * * * M E N U * * * * * ");

                Console.WriteLine("\n [1] Cadastrar novo Aluno ");

                Console.WriteLine("\n [2] Listar os Alunos cadastrados ");

                Console.WriteLine("\n [3] Excluir Aluno");

                Console.WriteLine("\n [4] Pesquisar Aluno");

                Console.WriteLine("\n [5] Mudar nome do Aluno");

                Console.WriteLine("\n [9] Sair ");

                Console.Write("\n Digite a Opção: ");

                val = Convert.ToInt32(Console.ReadLine());


                switch (val)
                {


                    case 1:

                        Console.Clear();

                        Console.Write("Cadastro do Aluno ");

                        Console.Write("\n Id: ");
                        var id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\n Nome: ");
                        var nome = Console.ReadLine();

                        Console.Write("\n Idade: ");
                        var idade = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\n Nome do Pai: ");
                        var nomepai = Console.ReadLine();

                        Console.Write("\n Nome da Mãe: ");
                        var nomemae = Console.ReadLine();

                        Console.Write("\n RA: ");
                        var ra = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\n Data de Nascimento: ");
                        var datanascimento = Convert.ToDateTime(Console.ReadLine());



                        listaAluno.Add(new Atributos
                        {
                            Id = id,
                            Nome = nome,
                            Idade = idade,
                            NomePai = nomepai,
                            NomeMae = nomemae,
                            RA = ra,
                            DataNascimento = datanascimento,
                        });

                        break;

                    case 2:

                        Console.Clear();

                        if (listaAluno.Count == 0)
                        {

                            Console.WriteLine("\n Lista Vazia !!!!");
                            Console.ReadKey();

                        }
                        else
                        {

                            foreach (var aluno in listaAluno)
                            {

                                Console.Write($" Id: {aluno.Id} Nome: {aluno.Nome}");

                            }
                            Console.ReadKey();

                        }

                        break;

                    case 3:
                        Console.Clear();

                        if (listaAluno.Count == 0)
                        {
                            Console.WriteLine("\n Não é possivel excluir, Lista Vazia !!!!");
                            Console.ReadKey();
                            break;

                        }

                        else
                        {
                            Console.Clear();

                            Console.WriteLine("\n * * * * * M E N U * * * * * ");

                            Console.WriteLine("\n [1] Pesquisar pelo Id ");

                            Console.WriteLine("\n [2] Pesquisar por Nome ");

                            Console.Write("\n Digite a Opção: ");

                            val = Convert.ToInt32(Console.ReadLine());

                            switch (val)
                            {

                                case 1:

                                    Console.Write("Digite o Id ");
                                    var remove = Convert.ToInt32(Console.ReadLine());

                                    var removeAluno = listaAluno.FirstOrDefault(x => x.Id == remove);

                                    if (removeAluno != null)
                                    {
                                        listaAluno.Remove(removeAluno);
                                        Console.WriteLine("\n Aluno excluido com Sucesso !!!");
                                        Console.ReadKey();

                                    }
                                    else
                                    {

                                        Console.WriteLine("Digite um id valido !!!");
                                        Console.ReadKey();

                                    }

                                    break;

                                case 2:

                                    Console.Write("Digite o Nome ");
                                    var removen = Console.ReadLine();

                                    var removeAlunon = listaAluno.FirstOrDefault(x => x.Nome == removen);

                                    if (removeAlunon != null)
                                    {
                                        listaAluno.Remove(removeAlunon);
                                        Console.WriteLine("\n Aluno excluido com Sucesso !!!");
                                        Console.ReadKey();

                                    }
                                    else
                                    {

                                        Console.WriteLine("Digite um Nome valido !!!");
                                        Console.ReadKey();

                                    }

                                    break;

                            }

                        }


                        break;

                    case 4:

                        Console.Clear();

                        if (listaAluno.Count == 0)
                        {
                            Console.WriteLine("\n Não é possivel pesquisar, Lista Vazia !!!!");
                            Console.ReadKey();
                            break;

                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("\n * * * * * M E N U * * * * * ");

                            Console.WriteLine("\n [1] Pesquisar pelo Id ");

                            Console.WriteLine("\n [2] Pesquisar por Nome ");

                            Console.Write("\n Digite a Opção: ");

                            val = Convert.ToInt32(Console.ReadLine());

                            switch (val)
                            {

                                case 1:

                                    Console.Write("\n Digite o Id ");
                                    var pesquisa = Convert.ToInt32(Console.ReadLine());

                                    var pesquisaAluno = listaAluno.FirstOrDefault(x => x.Id == pesquisa);

                                    if (pesquisaAluno != null)
                                    {
                                        Console.WriteLine($"Nome: {pesquisaAluno.Nome} RA: {pesquisaAluno.RA}");
                                        Console.WriteLine("\n Aluno encontrado com Sucesso !!!");
                                        Console.ReadKey();

                                    }
                                    else
                                    {

                                        Console.WriteLine("\n Digite um id valido !!!");
                                        Console.ReadKey();

                                    }

                                    break;

                                case 2:

                                    Console.Write("\n Digite o Nome ");
                                    var pesquisan = Console.ReadLine();

                                    var pesquisaAlunon = listaAluno.FirstOrDefault(x => x.Nome == pesquisan);

                                    if (pesquisaAlunon != null)
                                    {

                                        Console.WriteLine($"Nome: {pesquisaAlunon.Nome} RA: {pesquisaAlunon.RA}");
                                        Console.WriteLine("\n Aluno encontrado com Sucesso !!!");
                                        Console.ReadKey();

                                    }
                                    else
                                    {

                                        Console.WriteLine("\n Digite um Nome valido !!!");
                                        Console.ReadKey();

                                    }

                                    break;

                            }




                        }

                        break;

                    case 5:

                        Console.Clear();

                        if (listaAluno.Count == 0)
                        {
                            Console.WriteLine("\n Não é possivel mudar, Lista Vazia !!!!");

                            Console.ReadKey();

                            break;

                        }
                        else
                        {
                            Console.Clear();

                            Console.WriteLine("\n * * * * * M E N U * * * * * ");

                            Console.WriteLine("\n [1] Pesquisar pelo Id ");

                            Console.WriteLine("\n [2] Pesquisar por Nome ");

                            Console.Write("\n Digite a Opção: ");

                            val = Convert.ToInt32(Console.ReadLine());

                            switch (val)
                            {

                                case 1:

                                    Console.Write("\n Digite o Id ");
                                    var mudar = Convert.ToInt32(Console.ReadLine());

                                    var mudarAluno = listaAluno.FirstOrDefault(x => x.Id == mudar);

                                    if (mudarAluno != null)
                                    {
                                        Console.Write("\n Digite um novo nome para o aluno: ");
                                        var novoNome = Console.ReadLine();
                                        mudarAluno.Nome = novoNome;
                                        Console.WriteLine("Nome alterado com Sucesso !!!");
                                        Console.ReadKey();

                                    }
                                    else
                                    {

                                        Console.WriteLine("\n Digite um id valido !!!");
                                        Console.ReadKey();

                                    }

                                    break;

                                case 2:

                                    Console.Write("\n Digite o Nome ");
                                    var mudarn = Console.ReadLine();

                                    var mudarAlunon = listaAluno.FirstOrDefault(x => x.Nome == mudarn);

                                    if (mudarAlunon != null)
                                    {

                                        Console.Write("\n Digite um novo nome para o aluno: ");
                                        var novoNome = Console.ReadLine();
                                        mudarAlunon.Nome = novoNome;
                                        Console.WriteLine("Nome alterado com Sucesso !!!");
                                        Console.ReadKey();

                                    }
                                    else
                                    {

                                        Console.WriteLine("\n Digite um Nome valido !!!");
                                        Console.ReadKey();

                                    }

                                    break;

                            }

                        }

                        break;

                }

            } while (val != 9);

        }
    
    
    
    }
}
