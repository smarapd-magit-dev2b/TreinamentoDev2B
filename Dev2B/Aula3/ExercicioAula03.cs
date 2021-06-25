﻿using Aula3.Classes.ClassesExe01;
using Aula3.Classes.ClassesExe02;
using System.Globalization;
using System;
using Aula3.Classes.ClassesExe03;

namespace Aula3 {

    public class ExercicioAula03 {
        public void Executar() {
            Exercicio01();
            Exercicio02();
            Exercicio03();
        }
        private void Exercicio01() {

            Console.WriteLine("---------FICHA CLIENTE--------");

            Console.Write("Nome do Cliente: ");
            var nome = Console.ReadLine();

            Console.Write("CPF do Cliente: ");
            var cpf = int.Parse(Console.ReadLine());

            Console.Write("Telefone do Cliente: ");
            var telefone = int.Parse(Console.ReadLine());

            Console.Write("Celular do Cliente: ");
            var celular = int.Parse(Console.ReadLine());

            Console.Write("RG do Cliente: ");
            var rg = int.Parse(Console.ReadLine());

            Console.Write("Endereço do Cliente: ");
            var endereco = Console.ReadLine();

            Console.Write("Quantidade de Filhos: ");
            var qntfilhos = int.Parse(Console.ReadLine());

            Console.Write("Estado Civil: ");
            var estadocivil = Console.ReadLine();

            Cliente cliente = new Cliente(nome, endereco, telefone, rg, cpf, qntfilhos, estadocivil);

            Console.Clear();
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("---------FICHA FUNCINARIO--------");

            Console.Write("Nome do Funcionario: ");
            nome = Console.ReadLine();

            Console.Write("CPF do Funcionario: ");
            cpf = int.Parse(Console.ReadLine());

            Console.Write("Telefone do Funcionario: ");
            telefone = int.Parse(Console.ReadLine());

            Console.Write("Celular do Funcionario: ");
            celular = int.Parse(Console.ReadLine());

            Console.Write("RG do Funcionario: ");
            rg = int.Parse(Console.ReadLine());

            Console.Write("Endereço do Funcionario: ");
            endereco = Console.ReadLine();

            Console.Write("Quantidade de Filhos: ");
            qntfilhos = int.Parse(Console.ReadLine());

            Console.Write("Estado Civil: ");
            estadocivil = Console.ReadLine();

            Console.Write("Data de Adimissão: ");
            var dataadm = DateTime.Parse(Console.ReadLine());

            Console.Write("Salário: ");
            var salario = decimal.Parse(Console.ReadLine());

            Funcionario funcionario = new Funcionario(nome, endereco, telefone, rg, cpf, qntfilhos, estadocivil, dataadm, salario);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.Clear();

            Console.WriteLine("---------FICHA FORNECEDOR--------");

            Console.Write("Nome do Fornecedor: ");
            nome = Console.ReadLine();

            Console.Write("CPF do Fornecedor: ");
            cpf = int.Parse(Console.ReadLine());

            Console.Write("Endereço do Fornecedor: ");
            endereco = Console.ReadLine();

            Console.Write("Telefone do Fornecedor: ");
            telefone = int.Parse(Console.ReadLine());

            Console.Write("CNPJ do Fornecedor: ");
            var cnpj = int.Parse(Console.ReadLine());

            Console.Write("Segmento do Fornecedor: ");
            var segmento = Console.ReadLine();

            Console.Write("Produto do Fornecedor: ");
            var produto = Console.ReadLine();

            Fornecedor fornecedor = new Fornecedor(nome, endereco, telefone, cnpj, segmento, produto);

            //////////////////////////////////////////////////////////////////////////////////////
            Console.Clear();

            // Mostrando os resultados
            Console.WriteLine("Cliente");
            cliente.MostrarInformacoes();

            Console.WriteLine("\nFuncionario");
            funcionario.MostrarInformacoes();

            Console.WriteLine("\nFornecedor");
            fornecedor.MostrarInformacoes();

        }
        private void Exercicio02() {
            var i = 1;

            Aviao aviao = new Aviao("Branco", 300, "Diesel", "AirGood", 3, 100, 3, 120, "Grande");
            Moto moto = new Moto("Vermela", 200, "Gasolina", "Honda", 2, 2, true);
            Carro carro = new Carro("Prata", 250, "Etanol", "FIAT", 4, 4, 4, true, false);

            Console.WriteLine("FICHA TÉCNICA DO AVIÃO");
            Console.WriteLine("------------------------------------");
            aviao.FichaMecanica();
            Console.WriteLine("Qnt. de Pilotos: " + aviao.QntPilotos);
            Console.WriteLine("Qnt. de Acentos: " + aviao.QntAcentos);
            Console.WriteLine("Porte: " + aviao.Porte);
            Console.WriteLine("------------------------------------");
            Console.ReadKey();

            ////////////////////////////////////////////////////////////////

            Console.WriteLine("FICHA TÉCNICA DO CARRO");
            Console.WriteLine("------------------------------------");
            carro.FichaMecanica();
            Console.WriteLine("Qnt. de Portas: " + carro.QntPortas);
            Console.WriteLine("Possui Step: " + carro.PossuiStep);
            Console.WriteLine("Possui Tração Traseira: "+ carro.PossuiTracaoTraseira);
            Console.WriteLine("------------------------------------");
            Console.ReadKey();

            //////////////////////////////////////////////////////////////////

            Console.WriteLine("FICHA TÉCNICA DA MOTO");
            Console.WriteLine("------------------------------------");
            aviao.FichaMecanica();
            Console.WriteLine("Possui Carenagem: " + aviao.QntPilotos);
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
        }
        private void Exercicio03() {
            bool rodando = true;

            while (rodando) {
                Console.Clear();

                Console.WriteLine("-------------Calculadora------------");
                Console.WriteLine("Digite [+] para somar");
                Console.WriteLine("Digite [-] para subtrair");
                Console.WriteLine("Digite [*] para multiplicar");
                Console.WriteLine("Digite [/] para dividir");
                Console.WriteLine("Digite [S] para sair");
                var opcao = Console.ReadLine();

                switch (opcao) {
                    case "+":
                        Console.Write("Digite o primeiro valor: ");
                        var valor1 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        
                        Console.Write("Digite o primeiro valor: ");
                        var valor2 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Soma soma = new Soma(valor1, valor2);
                        soma.Calcular();
                        Console.ReadKey();
                        break;

                    case "-":
                        Console.Write("Digite o primeiro valor: ");
                        valor1 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Digite o primeiro valor: ");
                        valor2 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Subtracao subtracao = new Subtracao(valor1, valor2);
                        subtracao.Calcular();
                        Console.ReadKey();
                        break;

                    case "*":
                        Console.Write("Digite o primeiro valor: ");
                        valor1 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Digite o primeiro valor: ");
                        valor2 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Multiplicacao multiplicacao = new Multiplicacao(valor1, valor2);
                        multiplicacao.Calcular();
                        Console.ReadKey();
                        break;

                    case "/":
                        Console.Write("Digite o primeiro valor: ");
                        valor1 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Digite o primeiro valor: ");
                        valor2 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Divisao divisao = new Divisao(valor1, valor2);
                        divisao.Calcular();
                        Console.ReadKey();
                        break;

                    case "S":
                        Console.WriteLine("Saindo.....");
                        rodando = false;
                        break;

                    default:
                        Console.WriteLine("Opção Invalida...");
                        Console.ReadKey();
                        break;
                    

                }
            
            
            }
        }
        private void Exercicio04() {

        }
    }
}
