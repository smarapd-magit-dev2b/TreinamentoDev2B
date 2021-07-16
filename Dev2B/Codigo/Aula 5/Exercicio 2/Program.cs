using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_2
{
    class Program
    {
        public static int Count { get; private set; }

        static void Main(string[] args)
        {
            //Variaveis---------------------

            int val;

            var listaCarro = new List<Atributos>()
            {


            };

            do
            {
                Console.Clear();
                Console.WriteLine("\n * * * * * M E N U * * * * * ");

                Console.WriteLine("\n [1] Cadastrar novo Veiculo ");

                Console.WriteLine("\n [2] Listar os carros cadastrados ");

                Console.WriteLine("\n [3] Excluir carro");

                Console.WriteLine("\n [9] Sair ");

                Console.Write("\n Digite a Opção: ");

                val = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (val)
                {


                    case 1:
                        Console.Clear();
                        Console.Write("Cadastro do Carro ");

                        Console.Write("\n Id: ");
                        var id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\n Marca: ");
                        var marca = Console.ReadLine();

                        Console.Write("\n Cor: ");
                        var cor = Console.ReadLine();

                        Console.Write("\n Ano de Fabricação: ");
                        var ano = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\n Preço: ");
                        var preço = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("\n Quantidade de Portas: ");
                        var portas = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\n Kilometragem: ");
                        var kilo = Convert.ToDecimal(Console.ReadLine());



                        listaCarro.Add(new Atributos
                        {
                            Id = id,
                            Marca = marca,
                            Cor = cor,
                            AnoFabricação = ano,
                            Preço = preço,
                            QuantidadePortas = portas,
                            Kilometragem = kilo,
                        });

                        break;

                    case 2:
                        Console.Clear();

                        if (listaCarro.Count == 0)
                        {

                            Console.WriteLine("Lista Vazia !!!!");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {

                            foreach (var carro in listaCarro)
                            {

                                Console.Write($" Id: {carro.Id} Marca: {carro.Marca}");

                            }
                            Console.ReadKey();
                            break;

                        }


                    case 3:

                        if (listaCarro.Count == 0)
                        {
                            Console.WriteLine("Não é possivel excluir, Lista Vazia !!!!");
                            Console.ReadKey();
                            break;

                        }

                        else
                        {
                            
                            Console.Write("Digite o Id ");
                            var remove = Convert.ToInt32(Console.ReadLine());

                            var removeCarro = listaCarro.FirstOrDefault(x => x.Id == remove);

                            if (removeCarro != null)
                            {
                                listaCarro.Remove(removeCarro);
                                Console.WriteLine("Carro excluido");
                                Console.ReadKey();
                                
                            }
                            else
                            {

                                Console.WriteLine("Digite um id valido !!!");
                                Console.ReadKey();

                            }
                            


                        }


                        break;
                }


            } while (val != 9);

        }
    }
}
