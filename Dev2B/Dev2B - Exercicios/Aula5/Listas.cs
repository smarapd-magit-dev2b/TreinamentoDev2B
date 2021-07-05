using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

namespace Aluno
{
    public class Listas
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
            string resposta;

            DadosPessoa dado = new DadosPessoa();

            var ListaPessoa = new List<DadosPessoa>();

            do
            {
                Console.WriteLine("Informe o nome: ");
                dado.Nome = Console.ReadLine();
                Console.WriteLine("Informe o Telefone: ");
                dado.Telefone = Console.ReadLine();
                Console.WriteLine("Informe a quantidade de filhos: ");
                dado.QntdFilhos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o Nome do pai: ");
                dado.NomePai = Console.ReadLine();
                Console.WriteLine("Informe o nome da mãe: ");
                dado.NomeMae = Console.ReadLine();
                Console.WriteLine("Informe o salario: ");
                dado.Salario = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Informe seu peso: ");
                dado.Peso = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Informe sua Altura: ");
                dado.Altura = Convert.ToDecimal(Console.ReadLine());

                ListaPessoa.Add(new DadosPessoa()
                {
                    Nome = dado.Nome,
                    Telefone = dado.Telefone,
                    QntdFilhos = dado.QntdFilhos,
                    NomePai = dado.NomePai,
                    NomeMae = dado.NomeMae,
                    Salario = dado.Salario,
                    Peso = dado.Peso,
                    Altura = dado.Altura
                });

                Console.WriteLine("\nDeseja cadastrar mais alguma pessoa?");
                resposta = Console.ReadLine();


            } while (resposta != "nao");


            foreach (var pessoa in ListaPessoa)
            {
                Console.WriteLine(pessoa);
            }

        }
        private void Exercicio2()
        {
            string resposta;
            int contador = 0;

            DadosCarro dado = new DadosCarro();
            var ListaCarros = new List<DadosCarro>();

            do
            {
                Console.WriteLine("Informe a cor: ");
                dado.Cor = Console.ReadLine();
                Console.WriteLine("Informe a marca: ");
                dado.Marca = Console.ReadLine();
                Console.WriteLine("Informe o valor: ");
                dado.Preco = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Informe o numero de portas: ");
                dado.QntdPortas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe a kilometragem: ");
                dado.Kilometragem = Convert.ToDecimal(Console.ReadLine());

                contador++;


                ListaCarros.Add(new DadosCarro()
                {
                    Id = contador,
                    Cor = dado.Cor,
                    QntdPortas = dado.QntdPortas,
                    Marca = dado.Marca,
                    Preco = dado.Preco,
                    Kilometragem = dado.Kilometragem,

                });

                Console.WriteLine("\nDeseja cadastrar mais algum carro?");
                resposta = Console.ReadLine();


            } while (resposta != "nao");

            foreach (var carro in ListaCarros)
            {
                Console.WriteLine(carro);
            }
            Console.WriteLine($"------------------------------------------\n");
            //excluir carro por id
            int id;

            Console.WriteLine($"\n\nInforme o ID que deseja excluir:");
            id = Convert.ToInt32(Console.ReadLine());
            var ExcluirId = ListaCarros.FirstOrDefault(x => x.Id == id);

            ListaCarros.Remove(ExcluirId);
            Console.WriteLine($"O {id} foi excluido!\n");
            foreach (var carro in ListaCarros)
            {
                Console.WriteLine($"\n{carro}");
            }

            Console.ReadLine();



        }
        private void Exercicio3()
        {

            string resposta;
            int contador = 0;
            EnumMenu opcao;
            var ListaALunos = new List<DadosAluno>();
            DadosAluno dado = new DadosAluno();

            do
            {
                Console.WriteLine("Opçãos disponiveis:");
                Console.WriteLine("1) Inserir Alunos.\n2) Listar alunos.\n3) Alterar dados de um aluno.\n4) Deletar um aluno.\n5) Pesquisar aluno especifico.\n0) Sair.");
                opcao = (EnumMenu)Enum.Parse(typeof(EnumMenu), Console.ReadLine());

                switch (opcao)
                {
                    case EnumMenu.Cadastro:
                        {
                            do
                            {
                                Console.WriteLine($"Informe o nome do aluno {contador}: ");
                                dado.Nome = Console.ReadLine();
                                Console.WriteLine("Informe a idade: ");
                                dado.Idade = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Informe o nome do Pai: ");
                                dado.NomePai = Console.ReadLine();
                                Console.WriteLine("Informe o nome da Mãe: ");
                                dado.NomeMae = Console.ReadLine();
                                Console.WriteLine("Informe o RA: ");
                                dado.RA = Console.ReadLine();
                                Console.WriteLine("Informe a data de nascimento: ");
                                dado.DataNascimento = Convert.ToDateTime(Console.ReadLine()).Date;

                                contador++;


                                ListaALunos.Add(new DadosAluno()
                                {
                                    Id = contador,
                                    Nome = dado.Nome,
                                    NomeMae = dado.NomeMae,
                                    NomePai = dado.NomePai,
                                    Idade = dado.Idade,
                                    DataNascimento = dado.DataNascimento,
                                    RA = dado.RA

                                });

                                Console.WriteLine("\nDeseja cadastrar mais algum aluno?");
                                resposta = Console.ReadLine();


                            } while (resposta != "nao");

                            break;
                        }
                    case EnumMenu.Lista:
                        {
                            foreach (var aluno in ListaALunos)
                            {
                                Console.WriteLine($"\n\n{aluno}");
                            }

                            break;
                        }
                    case EnumMenu.Alterar:
                        {
                            Console.WriteLine("Informe o ID do aluno que deseja alterar o nome: ");
                            int key = Convert.ToInt32(Console.ReadLine());
                            var pesquisarAluno = ListaALunos.FirstOrDefault(A => A.Id == key);

                            if (pesquisarAluno != null)
                            {
                                Console.WriteLine("Informe o novo nome do aluno: ");
                                pesquisarAluno.Nome = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("ID inexistente...");
                            }

                            break;
                        }
                    case EnumMenu.Deletar:
                        {
                            Console.WriteLine("\n\nInforme o ID do aluno que deseja deletar: ");
                            int key = Convert.ToInt32(Console.ReadLine());

                            var deletarAluno = ListaALunos.FirstOrDefault(A => A.Id == key);

                            if (deletarAluno != null)
                            {
                                ListaALunos.Remove(deletarAluno);
                                Console.WriteLine($"Aluno deletado...\n\n");
                            }
                            else
                            {
                                Console.WriteLine("ID inexistente...");
                            }

                            break;
                        }
                    case EnumMenu.Pesquisar:
                        {
                            Console.WriteLine("Informe o ID ou NOME do aluno que queira inspecionar: ");
                            int key = Convert.ToInt32(Console.ReadLine());
                            string name = Console.ReadLine();

                            var printarAluno = ListaALunos.FirstOrDefault(A => A.Id == key || A.Nome == name);

                            if (printarAluno != null)
                            {
                                Console.WriteLine(printarAluno);
                            }

                            break;
                        }
                    default:
                        Console.WriteLine("Opção invalida...");
                        Console.ReadLine();
                        break;
                }

            } while (opcao != 0);
        }
        private void Exercicio4()
        {
            DadosVenda venda = new DadosVenda();

            string resposta;
            int contador = 0;
            EnumMenu opcao;

            var ListaVenda = new List<DadosVenda>();


            do
            {
                Console.WriteLine("Opçãos disponiveis:");
                Console.WriteLine("1) Cadastrar Vendas.\n2) Cadastrar itens nas vendas.\n3) Imprimir dados da venda.\n4) Deletar uma venda (ID)." +
                                  "\n5) Excluir item de uma venda (ID).\n6) Pequisar venda por Data.\n7) Pesquisar venda por um determinado periodo de tempo." +
                                  "\n8) Pesquisar venda pelo nome do vendedor.\n0) Sair.");
                opcao = (EnumMenu)Enum.Parse(typeof(EnumMenu), Console.ReadLine());

                switch (opcao)
                {
                    case EnumMenu.Cadastro:
                        {
                            do
                            {

                                Console.WriteLine("Informe o nome do vendedor: ");
                                venda.Vendedor = Console.ReadLine();
                                Console.WriteLine("Informe a data em que foi feita a venda: ");
                                venda.DataVenda = Convert.ToDateTime(Console.ReadLine()).Date;

                                contador++;

                                ListaVenda.Add(new DadosVenda()
                                {

                                    Id = contador,
                                    DataVenda = venda.DataVenda,
                                    Vendedor = venda.Vendedor

                                });

                                Console.WriteLine("\nDeseja cadastrar mais alguma venda?");
                                resposta = Console.ReadLine();

                            } while (resposta != "nao");

                            break;
                        }
                    case EnumMenu.CadastroItem:
                        {
                            int choice, flag = 0;
                            string answer;
                            Console.WriteLine("Escolha a venda que deseja cadastrar os items: ");
                            foreach (var vendas in ListaVenda)
                            {
                                Console.WriteLine($"\n|ID: {vendas.Id} | Vendedor: {vendas.Vendedor} | Data da venda: {vendas.DataVenda} |");
                            }
                            Console.WriteLine($"Escolha: {choice = Convert.ToInt32(Console.ReadLine())}");

                            var cadastrarItem = ListaVenda.FirstOrDefault(x => x.Id == choice);
                            if (cadastrarItem != null)
                            {
                                DadosItemVenda item = new DadosItemVenda();
                                do
                                {
                                    Console.WriteLine("Informe o tipo do produto: ");
                                    item.Descricao = Console.ReadLine();
                                    Console.WriteLine("Informe o valor do produto: ");
                                    item.PrecoUnitario = Convert.ToDecimal(Console.ReadLine());
                                    Console.WriteLine("Informe o a quantidade vendida do produto: ");
                                    item.QntdVendida = Convert.ToInt32(Console.ReadLine());

                                    flag++;

                                    cadastrarItem.Itens.Add(new DadosItemVenda()
                                    {
                                        Id = flag,
                                        Descricao = item.Descricao,
                                        PrecoUnitario = item.PrecoUnitario,
                                        QntdVendida = item.QntdVendida
                                    });

                                    Console.WriteLine("\nDeseja cadastrar mais algum item?");
                                    answer = Console.ReadLine();

                                } while(answer != "nao");
                                
                            }

                            break;
                        }
                    case EnumMenu.ListaVendaItens:
                        {
                            Console.WriteLine("Vendas no Bando de Dados!\n\n");
                            foreach (var sells in ListaVenda)
                            {
                                Console.WriteLine(sells);

                                foreach (var itens in sells.Itens)
                                {
                                    Console.WriteLine(itens);
                                }
                            }

                            break;
                        }
                    case EnumMenu.Deletar:
                        {
                            Console.WriteLine("Informe o ID da venda que deseja deletar: ");
                            int key = Convert.ToInt32(Console.ReadLine());
                            var deletarVenda = ListaVenda.FirstOrDefault(A => A.Id == key);

                            if (deletarVenda != null)
                            {
                                ListaVenda.Remove(deletarVenda);
                            }
                            else
                            {
                                Console.WriteLine("ID inexistente...");
                            }

                            break;
                        }
                    case EnumMenu.DeletarItem:
                        {
                            Console.WriteLine("\n\nInforme o ID da venda para navegar nos itens: ");
                            int key = Convert.ToInt32(Console.ReadLine());

                            var deletarItemVenda = venda.Itens.FirstOrDefault(A => A.Id == key);

                            if (deletarItemVenda != null)
                            {
                                ListaVenda.Remove(venda);
                                Console.WriteLine($"Item deletado...\n\n");
                            }
                            else
                            {
                                Console.WriteLine("ID inexistente...");
                            }

                            break;
                        }
                    case EnumMenu.PesquisarVendaData:
                        {
                            Console.WriteLine("Informe a data da venda que queira inspecionar: ");
                            DateTime date = Convert.ToDateTime(Console.ReadLine()).Date;
                            string name = Console.ReadLine();

                            var mostrarVendaData = ListaVenda.FirstOrDefault(data => data.DataVenda == date);

                            if (mostrarVendaData != null)
                            {
                                Console.WriteLine(mostrarVendaData);
                            }
                            else
                            {
                                Console.WriteLine("Não existe nenhuma venda referente a esta data...");
                            }
                            break;
                        }
                    case EnumMenu.PesquisarVendaPeriodo:
                        {
                            DateTime dateFirst;
                            DateTime dateLast;

                            Console.WriteLine("Informe o o periodo de tempo para verificar as vendas!");
                            Console.WriteLine($"---- Informe a data inicial do periodo: {dateFirst = Convert.ToDateTime(Console.ReadLine()).Date}");
                            Console.WriteLine($"---- Informe a data final do periodo: {dateLast = Convert.ToDateTime(Console.ReadLine()).Date}");
                            string name = Console.ReadLine();

                            var mostrarPeriodoVenda = ListaVenda.FirstOrDefault(data => data.DataVenda >= dateFirst || data.DataVenda <= dateLast);

                            if (mostrarPeriodoVenda != null)
                            {
                                Console.WriteLine(mostrarPeriodoVenda);
                            }
                            else
                            {
                                Console.WriteLine("Periodo de tempo invalido para pesquisa...");
                            }
                            break;
                        }
                    case EnumMenu.PesquisarVendaVendedor:
                        {
                            string seller;
                            Console.WriteLine($"Informe o nome do vendedor que deseja visualizar as vendas efetuadas: {seller = Console.ReadLine()}");

                            var mostrarVendedor = ListaVenda.FirstOrDefault(v => v.Vendedor == seller);

                            if (mostrarVendedor != null)
                            {
                                Console.WriteLine(venda);
                            }
                            else
                            {
                                Console.WriteLine("Nome não existe no sistema...");

                            }
                            break;
                        }
                    case EnumMenu.Sair:
                        {
                            Console.WriteLine("Saindo....");
                            break;
                        }
                    default:
                        Console.WriteLine("Fechando programa...");
                        Console.ReadLine();
                        break;
                }

            } while (opcao != 0);

        }
    }
}
