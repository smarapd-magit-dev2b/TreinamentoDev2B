
using Aula07_ClassesEstaticas;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aula07_ClassesEstaticas.ClassesAula07;
using Aula06_Lambdas.ClassesAula06;

namespace Aula07_ClassesEstaticas
{
    public class ExerciciosAula07
    {
        public void Execute()
        {
            try
            {
                //Exercicio01();

            }
            catch (NegocioException negocioException)
            {
                Console.WriteLine(negocioException.Message);
            }
            catch (Exception negocioException)
            {
                Console.WriteLine($"Erro genérico: {negocioException.Message}");
            }
            finally
            {
                PessoaHelper.SaveInFile(ColecaoPessoa, "Lista.txt");
            }

        }

        List<Pessoa> ColecaoPessoa = new List<Pessoa>

            {
                new Pessoa
                {
                    Id = 1,
                    Nome = "José",
                    Altura = 1.9m,
                    DataNascimento = new DateTime(1993, 12, 9),
                    Peso = 80.0m,
                    Raca = "Branca",
                    Endereco = new Endereco { Logradouro = "Rua Altair Gonçalves", Bairro = "Vila Tibério", Complemento = "Apartamento", Numero = 85 },
                    Filhos = new List<Pessoa>
                                    {
                                        new Pessoa
                                        {
                                            Id = 2,
                                            Nome = "Felipe",
                                            Altura = 1.5m,
                                            DataNascimento = new DateTime(2000, 3, 3),
                                            Peso = 50.0m,
                                            Raca = "Branca",
                                            Endereco = new Endereco { Logradouro = "Rua Altair Gonçalves", Bairro = "Vila Tibério", Complemento = "Apartamento", Numero = 85 },
                                            Filhos = null
                                        },
                                        new Pessoa
                                        {
                                            Id = 3,
                                            Nome = "Luis",
                                            Altura = 1.9m,
                                            DataNascimento = new DateTime(1990, 3, 15),
                                            Peso = 100.0m,
                                            Raca = "Branca",
                                            Endereco = new Endereco { Logradouro = "Rua Altair Gonçalves", Bairro = "Vila Tibério", Complemento = "Apartamento", Numero = 85 },
                                            Filhos = null
                                        }
                                    }
                },
                new Pessoa
                {
                    Id = 4,
                    Nome = "Willian",
                    Altura = 1.7m,
                    DataNascimento = new DateTime(1950, 10, 4),
                    Peso = 100.0m,
                    Raca = "Negro",
                    Endereco = new Endereco { Logradouro = "Rua Guilherme Schmdit", Bairro = "Centro", Complemento = "Casa", Numero = 111 },
                    Filhos = new List<Pessoa>
                                    {
                                        new Pessoa
                                        {
                                            Id = 5,
                                            Nome = "Joaquim",
                                            Altura = 2m,
                                            DataNascimento = new DateTime(1986, 5, 3),
                                            Peso = 50.0m,
                                            Raca = "Negro",
                                            Endereco = new Endereco { Logradouro = "Avenida Benedito Ferreira", Bairro = "Vila Almeida", Complemento = "Apartamento", Numero = 99 },
                                            Filhos = null
                                        },
                                        new Pessoa
                                        {
                                            Id = 6,
                                            Nome = "Gabriel",
                                            Altura = 1.3m,
                                            DataNascimento = new DateTime(2005, 5, 15),
                                            Peso = 69.0m,
                                            Raca = "Negro",
                                            Endereco = new Endereco { Logradouro = "Rua Guilherme Schmdit", Bairro = "Centro", Complemento = "Casa", Numero = 111 },
                                            Filhos = null
                                        },
                                        new Pessoa
                                        {
                                            Id = 7,
                                            Nome = "Pedro",
                                            Altura = 1.86m,
                                            DataNascimento = new DateTime(1995, 7, 22),
                                            Peso = 69.5m,
                                            Raca = "Negro",
                                            Endereco = new Endereco { Logradouro = "Rua Guilherme Schmdit", Bairro = "Centro", Complemento = "Casa", Numero = 111 },
                                            Filhos = null
                                        }
                                    }
                },
                new Pessoa
                {
                    Id = 4,
                    Nome = "Silas",
                    Altura = 1.78m,
                    DataNascimento = new DateTime(1968, 2, 2),
                    Peso = 92.0m,
                    Raca = "Branca",
                    Endereco = new Endereco { Logradouro = "Rua Joaquim Nabuco", Bairro = "Bairro Xis", Complemento = "Casa", Numero = 854 },
                    Filhos = null
                }
            };

        private void Exercicio01()
        {
            //- Criar uma exceção do tipo NegocioException
            //- Buscar Pessoas com mais de 90 anos, caso não encontrar lançar uma exceção NegocioException e mostrar a seguinte mensagem: "Erro de negócio: não existe pessoas com mais de 90 anos". Criar a classe DateTimeHelper que retorna a idade de uma data passada por parâmetro
            //- Criar uma classe Helper de coleção de pessoas, ela terá um método que receberá a lista de pessoas e salva em um arquivo.Basicamente ao invés de Console.WriteLine, salvar os resultados em arquivo.
            //File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo), ex.ToString());
            //File.AppendAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo), ex.ToString());

            {
                var Pessoas = ColecaoPessoa.Where(x => DateTimeHelper.GetIdade(x.DataNascimento) > 90).Count();
                if (Pessoas == 0)
                {
                    throw new NegocioException("Erro de negócio: não existe pessoas com mais de 90 anos");
                }                
            }
        }
    }
}
