using Aula5.Exercicio1Classes;
using Aula5.Exercicio2Classes;
using Aula5.Exercicio3Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula5
{
    public class ColecoesLista
    {
        private void Exercicio1() 
        {
            var listaPessoas = new List<Pessoa>();
            int i;

            do
            {
                Console.Clear();
                Console.WriteLine("----- MENU -----\n");
                Console.WriteLine("1 --- Cadastrar nova pessoa!");
                Console.WriteLine("2 --- Exibir lista de pessoas cadastradas!");
                Console.WriteLine("0 --- Sair!");
                Console.Write("\n Digite a opção desejada: ");
                i = int.Parse(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("----- CADASTRO DE NOVA PESSOA -----\n");
                        Console.Write("Nome: ");
                        var nome = Console.ReadLine();
                        Console.Write("Telefone: ");
                        var telefone = Console.ReadLine();
                        Console.Write("Data de nascimento: ");
                        var dataNascimento = DateTime.Parse(Console.ReadLine());
                        Console.Write("Salário: ");
                        var salario = decimal.Parse(Console.ReadLine());
                        Console.Write("Quantidade de filhos: ");
                        var qntFilhos = int.Parse(Console.ReadLine());
                        Console.Write("Altura: ");
                        var altura = decimal.Parse(Console.ReadLine());
                        Console.Write("Peso: ");
                        var peso = decimal.Parse(Console.ReadLine());
                        Console.Write("Nome do pai: ");
                        var nomeDoPai = Console.ReadLine();
                        Console.Write("Nome da Mãe: ");
                        var nomeDaMae = Console.ReadLine();

                        listaPessoas.Add(new Pessoa
                        {
                            Nome = nome,
                            Telefone = telefone,
                            DataNascimento = dataNascimento,
                            Salario = salario,
                            QntFilhos = qntFilhos,
                            Altura = altura,
                            Peso = peso,
                            NomeDoPai = nomeDoPai,
                            NomeDaMae = nomeDaMae
                        });

                        Console.WriteLine($"\n{nome} registrado(a) com sucesso!");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        if (listaPessoas.Count == 0) 
                        {
                            Console.WriteLine("----- LISTA DE PESSOAS CADASTRADAS -----\n");
                            Console.WriteLine("Lista Vazia!!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("----- LISTA DE PESSOAS CADASTRADAS -----\n");

                            foreach (var pessoa in listaPessoas)
                            {
                                Console.WriteLine($"Nome: {pessoa.Nome}");
                            }

                            Console.ReadKey();
                        }
                        break;

                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo do programa .....");
                        break;

                    default:
                        Console.WriteLine("\nEntrada inválida! Digite um opção existente!");
                        Console.ReadKey();
                        break;
                }
            } while (i != 0);
        }

        private void Exercicio2()
        {
            var listaCarros = new List<Carro>();
            int i;

            do
            {
                Console.Clear();
                Console.WriteLine("----- MENU -----\n");
                Console.WriteLine("1 --- Cadastrar novo carro!");
                Console.WriteLine("2 --- Exibir lista de carro(s) cadastrados!");
                Console.WriteLine("3 --- Excluir carro(s) cadastrados!");
                Console.WriteLine("0 --- Sair!");
                Console.Write("\n Digite a opção desejada: ");
                i = int.Parse(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("----- CADASTRO DE NOVO CARRO -----\n");
                        Console.Write("ID: ");
                        var id = int.Parse(Console.ReadLine());
                        Console.Write("Marca: ");
                        var marca = Console.ReadLine();
                        Console.Write("Cor: ");
                        var cor = Console.ReadLine();
                        Console.Write("Ano de fabricação: ");
                        var ano = int.Parse(Console.ReadLine());
                        Console.Write("Preço: ");
                        var preco = decimal.Parse(Console.ReadLine());
                        Console.Write("Quantidade de portas: ");
                        var qntPortas = int.Parse(Console.ReadLine());
                        Console.Write("Kilometragem: ");
                        var kilometragem = decimal.Parse(Console.ReadLine());

                        listaCarros.Add(new Carro
                        {
                            Id = id,
                            Marca = marca,
                            Cor = cor,
                            AnoFabricacao = ano,
                            Preco = preco,
                            QntPortas = qntPortas,
                            Kilometragem = kilometragem,
                        });

                        Console.WriteLine($"\nCarro registrado(a) com sucesso!");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        if (listaCarros.Count == 0)
                        {
                            Console.WriteLine("----- LISTA DE CARRO(S) CADASTRADO(S) -----\n");
                            Console.WriteLine("Lista Vazia!!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("----- LISTA DE CARRO(S) CADASTRADO(S) -----\n");

                            foreach (var carro in listaCarros)
                            {
                                Console.WriteLine($"Id: {carro.Id} Marca: {carro.Marca}");
                            }

                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        Console.Clear();
                        if (listaCarros.Count == 0)
                        {
                            Console.WriteLine("----- EXCLUIR CARROS(S) CADASTRADOS -----\n");
                            Console.WriteLine("Exclusão inválida! Lista Vazia!!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("----- EXCLUIR CARROS(S) CADASTRADOS -----\n");

                            foreach (var carro in listaCarros)
                            {
                                Console.WriteLine($"Id: {carro.Id} Marca: {carro.Marca}");
                            }

                            Console.Write("\nDigite o Id do carro que deseja excluir: ");
                            var idRemove = int.Parse(Console.ReadLine());

                            var removeCarro = listaCarros.FirstOrDefault(x => x.Id == idRemove);

                            if (removeCarro != null)
                            {
                                listaCarros.Remove(removeCarro);

                                Console.WriteLine($"\nCarro {removeCarro.Id} excluido!");
                                Console.ReadKey();
                            }
                            else
                            {
                                    Console.Write("O id informado é inválido! Digite um id válido!");
                                    Console.ReadKey();
                            }
                        }
                        break;

                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo do programa .....");
                        break;

                    default:
                        Console.WriteLine("\nEntrada inválida! Digite um opção existente!");
                        Console.ReadKey();
                        break;
                }
            } while (i != 0);
        }
        private void Exercicio3()
        {
            var listaAlunos = new List<Aluno>();
            int i;

            do
            {
                Console.Clear();
                Console.WriteLine("----- MENU -----\n");
                Console.WriteLine("1 --- Cadastrar novo Aluno(a)!");
                Console.WriteLine("2 --- Exibir lista de aluno(s) cadastrados!");
                Console.WriteLine("3 --- Pesquisar aluno(s) cadastrados!");
                Console.WriteLine("4 --- Excluir aluno(s) cadastrados!");
                Console.WriteLine("5 --- Alterar nome do aluno(a)!");
                Console.WriteLine("0 --- Sair!");
                Console.Write("\n Digite a opção desejada: ");
                i = int.Parse(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("----- CADASTRO DE NOVO CARRO -----\n");
                        Console.Write("ID: ");
                        var id = Console.ReadLine();
                        Console.Write("Nome: ");
                        var nome = Console.ReadLine();
                        Console.Write("Nome do pai: ");
                        var nomeDoPai = Console.ReadLine();
                        Console.Write("Nome da mãe: ");
                        var nomeDaMae = Console.ReadLine();
                        Console.Write("RA: ");
                        var ra = int.Parse(Console.ReadLine());
                        Console.Write("Data de nascimento: ");
                        var dataDeNascimento = DateTime.Parse(Console.ReadLine());

                        listaAlunos.Add(new Aluno
                        {
                            Id = id,
                            Nome = nome,
                            NomeDoPai = nomeDoPai,
                            NomeDaMae = nomeDaMae,
                            RA = ra,
                            DataDeNascimento = dataDeNascimento,
                        });

                        Console.WriteLine($"\nAluno registrado(a) com sucesso!");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        if (listaAlunos.Count == 0)
                        {
                            Console.WriteLine("----- LISTA DE ALUNO(S) CADASTRADO(S) -----\n");
                            Console.WriteLine("Lista Vazia!!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("----- LISTA DE ALUNO(S) CADASTRADO(S) -----\n");

                            foreach (var aluno in listaAlunos)
                            {
                                Console.WriteLine($"Nome: {aluno.Nome} RA: {aluno.RA}");
                            }

                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        Console.Clear();
                        if (listaAlunos.Count == 0)
                        {
                            Console.WriteLine("----- PESQUISAR ALUNOS(S) CADASTRADOS -----\n");
                            Console.WriteLine("Pesquisa inválida! Lista Vazia!!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("----- PESQUISAR ALUNOS(S) CADASTRADOS -----\n");

                            Console.Write("\nDigite o Id ou Nome do aluno que deseja pesquisar: ");
                            var idNomePesquisa = Console.ReadLine();

                            var pesquisaAluno = listaAlunos.FirstOrDefault(x => x.Id == idNomePesquisa || x.Nome == idNomePesquisa);

                            if (pesquisaAluno != null)
                            {
                                Console.WriteLine($"Nome: {pesquisaAluno.Nome} RA: {pesquisaAluno.RA}");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("\nNão existe nenhum aluno com o id ou nome desejado!");
                                Console.ReadKey();
                            }
                        }
                        break;

                    case 4:
                        Console.Clear();
                        if (listaAlunos.Count == 0)
                        {
                            Console.WriteLine("----- EXCLUIR ALUNOS(S) CADASTRADOS -----\n");
                            Console.WriteLine("Exclusão inválida! Lista Vazia!!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("----- EXCLUIR ALUNOS(S) CADASTRADOS -----\n");

                            foreach (var aluno in listaAlunos)
                            {
                                Console.WriteLine($"Nome: {aluno.Nome} Id: {aluno.Id}");
                            }

                            Console.Write("\nDigite o Id ou Nome do aluno que deseja excluir: ");
                            var idNomeRemove = Console.ReadLine();

                            var removeAluno = listaAlunos.FirstOrDefault(x => x.Id == idNomeRemove || x.Nome == idNomeRemove);

                            if (removeAluno != null)
                            {
                                listaAlunos.Remove(removeAluno);

                                Console.WriteLine($"\nAluno {removeAluno.Id} excluido!");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("\nO id informado é inválido! Digite um id válido!");
                                Console.ReadKey();
                            }
                        }
                        break;

                    case 5:
                        Console.Clear();
                        if (listaAlunos.Count == 0)
                        {
                            Console.WriteLine("----- ALTERAR ALUNOS(S) CADASTRADOS -----\n");
                            Console.WriteLine("Alteração inválida! Lista Vazia!!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("----- ALTERAR ALUNOS(S) CADASTRADOS -----\n");

                            foreach (var aluno in listaAlunos)
                            {
                                Console.WriteLine($"Nome: {aluno.Nome} Id: {aluno.Id}");
                            }

                            Console.Write("\nDigite o Id ou Nome do aluno que deseja alterar: ");
                            var idNomeAlterar = Console.ReadLine();

                            var alterarAluno = listaAlunos.FirstOrDefault(x => x.Id == idNomeAlterar || x.Nome == idNomeAlterar);

                            if (alterarAluno != null)
                            {
                                Console.Write($"\nDigite um novo nome para o aluno com id({alterarAluno.Id}): ");
                                var novoNome = Console.ReadLine();
                                alterarAluno.Nome = novoNome;
                            }
                            else
                            {
                                Console.Write("\nNão existe nenhum aluno com o id ou nome desejado!");
                                Console.ReadKey();
                            }
                        }

                        break;

                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo do programa .....");
                        break;

                    default:
                        Console.WriteLine("\nEntrada inválida! Digite um opção existente!");
                        Console.ReadKey();
                        break;
                }
            } while (i != 0);
        }
        private void Exercicio4()
        {

        }
        private void Exercicio5()
        {

        }

        public void Executar()
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            Exercicio4();
            //Exercicio5();
        }

    }
}
