using System;
using System.Globalization;

namespace Aula1 {
    public class ExercicioAula01 {
        public void Executar() {
            //Exercicio01();
            //Exercicio02();
            //Exercicio03();
            //Exercicio04IF();
            //Exercicio04SWITCH();
            //Exercicio05();
            //Exercicio06();
            //Exercicio07();
            //Exercicio08();
            //Exercicio09();
            //Exercicio10();
            //Desafio01();
            //Desafio02();
            //Desafio03();
            //Desafio04();
            //Desafio05();
        }
        private void Exercicio01() {
            bool rodando = true;
            decimal nota = 0;

            while (rodando) {
                Console.Write("Digite a nota do aluno: ");
                nota = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (nota > 10) {
                    Console.WriteLine("Nota invalida !!");
                }
                else {
                    rodando = false;
                }
            }

            if (nota >= 7) {
                Console.WriteLine("Aprovado !!");
            }
            else if (nota >= 4 && nota <= 6.99m) {
                Console.WriteLine("Exame !!");
            }
            else {
                Console.WriteLine("Reprovado !!");
            }
        }
        private void Exercicio02() {
            //declarações de variaveis
            decimal maior, menor, auxiliar = 0;
            int i = 1;

            //iniciando a variavel auxiliar
            Console.Write($"Digite o {i}° número: ");
            auxiliar = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            maior = auxiliar;
            menor = auxiliar;


            for (i = 2; i <= 10; i++) {
                Console.Write($"Digite o {i}° número: ");
                auxiliar = decimal.Parse(Console.ReadLine());

                if (auxiliar > maior) {
                    maior = auxiliar;
                }
                else if (auxiliar < menor) {
                    menor = auxiliar;
                }
            }
            Console.WriteLine($"Maior: {maior}" +
                               "\nMenor: " + menor);

        }
        private void Exercicio03() {
            Console.Write("Digite o 1° número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2° número: ");
            int n2 = int.Parse(Console.ReadLine());

            if ((n1 % 2) == 0 && (n2 % 2) == 0) {
                Console.WriteLine("Os números são múltiplos");
            }
            else {
                Console.WriteLine("Os números não são múltiplos");
            }
        }
        private void Exercicio04IF() {
            Console.Write("Digite o Primeiro Número: ");
            decimal n1 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o Segundo Número: ");
            decimal n2 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o operador da conta: + , - , * , /");
            char op = char.Parse(Console.ReadLine());

            {
                if (op == '+')
                    Console.WriteLine($"{n1} + {n2} = {n1 + n2}");

                else if (op == '-')
                    Console.WriteLine($"{n1} - {n2} = {n1 - n2}");

                else if (op == '*')
                    Console.WriteLine($"{n1} * {n2} = {n1 * n2}");

                else if (op == '/') {
                    if (n2 == 0) {
                        Console.WriteLine("Impossível realizar divisão");
                    }
                    else {
                        Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
                    }
                }

                else {
                    Console.WriteLine("Operação invalida");
                }
            }
        }
        private void Exercicio04SWITCH() {
            Console.Write("Digite o Primeiro Número: ");
            decimal n1 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o Segundo Número: ");
            decimal n2 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o operador da conta: + , - , * , /");
            char op = char.Parse(Console.ReadLine());

            switch (op) {
                case '+':
                    Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
                    break;

                case '-':
                    Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
                    break;

                case '*':
                    Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
                    break;

                case '/':
                    if (n2 == 0) {
                        Console.WriteLine("Impossível realizar a divisão");
                    }
                    else {
                        Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
                    }
                    break;

                default:
                    Console.WriteLine("Operação invalida");
                    break;
            }
        }
        private void Exercicio05() {
            int i = 0, aux = 0;

            while (i <= 100) {
                aux += i;
                i++;
            }
            Console.WriteLine("Usando o FOR: " + aux);
            aux = 0;

            for (i = 0; i <= 100; i++) {
                aux += i;
            }

            Console.WriteLine("Usando o WHILE: " + aux);
            aux = 0;
            i = 0;

            do {
                aux += i;
                i++;
            } while (i <= 100);
            Console.WriteLine("Usando o DO-WHILE: " + aux);
        }
        private void Exercicio06() {

            int i;
            Console.WriteLine("Usando o FOR:");

            for (i = 1; i <= 100; i++) {
                if (i % 3 == 0) {
                    Console.Write(i + " ");
                }
            }
            //reutilizando a variavel
            i = 1;

            Console.WriteLine("\nUsando o WHILE:");

            while (i <= 100) {
                if (i % 3 == 0) {
                    Console.Write(i + " ");
                }
                i++;
            }

            //reutilizando a variavel
            i = 1;

            Console.WriteLine("\nUsando o DO - WHILE:");
            do {
                if (i % 3 == 0) {
                    Console.Write(i + " ");
                }
                i++;
            } while (i <= 100);
        }
        private void Exercicio07() {
            int i = 1, aux = 0;
            Console.WriteLine("Usando o FOR:");
            for (i = 1; i <= 100; i++) {
                if (i % 3 != 0) {
                    aux += i;
                }
            }
            Console.WriteLine($"A soma total: {aux}");

            //reutilizando as variaveis
            i = 1;
            aux = 0;

            Console.WriteLine("Usando o While:");
            while (i <= 100) {
                if (i % 3 != 0) {
                    aux += i;
                }
                i++;
            }
            Console.WriteLine($"A soma total: {aux}");

            //reutilizando as variaveis
            i = 1;
            aux = 0;

            Console.WriteLine("Usando o DO-WHILE:");
            do {
                if (i % 3 != 0) {
                    aux += i;
                }
                i++;
            } while (i <= 100);
            Console.WriteLine($"A soma total: {aux}");
        }
        private void Exercicio08() {
            int i;
            Console.WriteLine("Usando o FOR:");
            for (i = 0; i <= 30; i++) {
                if (i % 3 == 0 || i % 4 == 0) {
                    Console.Write(i + " ");
                }
            }

            //reutilizando as variaveis
            i = 0;

            Console.WriteLine("\nUsando o WHILE: ");
            while (i <= 30) {
                if (i % 3 == 0 || i % 4 == 0) {
                    Console.Write(i + " ");
                }
                i++;
            }
            //reutilizando as variaveis
            i = 0;

            Console.WriteLine("\nUsando o DO-WHILE: ");
            do {
                if (i % 3 == 0 || i % 4 == 0) {
                    Console.Write(i + " ");
                }
                i++;
            } while (i <= 30);

        }
        private void Exercicio09() {
            bool rodando = true;
            int i;

            while (rodando) {
                Console.Write("Digite um número de 1 a 100 que deseja ver a tabuada: ");
                int n = int.Parse(Console.ReadLine());

                if (n < 0 || n > 100) {
                    Console.WriteLine("Opção Invalida...");
                }
                else {
                    Console.WriteLine("Tabuada usando o FOR");
                    for (i = 0; i <= 10; i++) {
                        Console.WriteLine($"{n} * {i} = {n * i}");
                    }

                    //zerando o contador
                    i = 0;

                    Console.WriteLine("\nTabuada usando o WHILE");
                    while (i <= 10) {
                        Console.WriteLine($"{n} * {i} = {n * i}");
                        i++;
                    }

                    //zerando o contador
                    i = 0;

                    Console.WriteLine("\nTabuada usando o DO-WHILE");
                    do {
                        Console.WriteLine($"{n} * {i} = {n * i}");
                        i++;
                    } while (i <= 10);

                    //encerrando o programa
                    Console.ReadKey();
                    rodando = false;
                }
            }
        }
        private void Exercicio10() {
            Pessoa Pessoa1 = new Pessoa();
            Pessoa Pessoa2 = new Pessoa();
            Pessoa Pessoa3 = new Pessoa();
            Pessoa Pessoa4 = new Pessoa();
            Pessoa Pessoa5 = new Pessoa();
            Pessoa Variavel = null;

            int i = 1, contadorPeso = 0, contadorIdade = 0, mais50anos = 0;
            decimal auxVariavel = 0;

            while (i <= 5) {

                if (i == 1) {
                    Variavel = Pessoa1;
                }
                else if (i == 2) {
                    Variavel = Pessoa2;
                }
                else if (i == 3) {
                    Variavel = Pessoa3;
                }
                else if (i == 4) {
                    Variavel = Pessoa4;
                }
                else if (i == 5) {
                    Variavel = Pessoa5;
                }

                Console.Write($"Idade {i}° Pessoa: ");
                Variavel.idade = int.Parse(Console.ReadLine());

                //Realizando as operações lógicas
                if (Variavel.idade > 50) {
                    mais50anos++;
                }

                Console.Write($"Altura {i}° Pessoa:");
                Variavel.altura = decimal.Parse(Console.ReadLine());

                //Realizando as operações lógicas
                if (Variavel.idade >= 10 && Variavel.idade <= 20) {
                    auxVariavel += Variavel.altura;
                    contadorIdade++;
                }

                Console.Write($"Peso {i}° Pessoa: ");
                Variavel.peso = decimal.Parse(Console.ReadLine());

                //Realizando as operações lógicas
                if (Variavel.peso < 40) {
                    contadorPeso++;
                }
                i++;
            }
            Console.Write($"A quantidade de pessoas acima de 50 anos é: {mais50anos}\n");
            Console.Write($"A média das alturas das pessoas com idade entre 10 a 20 anos é: {auxVariavel / contadorIdade}\n");
            Console.Write($"A porcentagem de pessoas com peso inferior a 40kg é: {(100 * contadorPeso) / 5}% \n");
        }
        private void Desafio01() {
            int? contador, maior, menor;
            bool rodando = true;

            while (rodando) {
                Console.Write("Digite um valor positivo: ");
                contador = int.Parse(Console.ReadLine());
                maior = contador;
                menor = contador;

                while (contador != 0 && contador > 0) {
                    if (contador > 0) {

                        Console.Write("Digite um valor positivo: ");
                        contador = int.Parse(Console.ReadLine());
                        if (contador > maior) {
                            maior = contador;
                        }
                        else if (contador < 0) {
                            Console.WriteLine("Números negativos são invalidos... ");
                            contador = 1;
                        }
                        else if (contador == 0) {
                            Console.WriteLine("Saindo...");
                        }
                        else if (contador < menor && contador > 0) {
                            menor = contador;
                        }
                    }
                    else if (contador < 0) {
                        Console.WriteLine("Números negativos são invalidos... ");
                        contador = 1;
                    }
                }
                if (maior == 0 && menor == 0) {
                    Console.WriteLine("Saindo...");
                    rodando = false;
                }

                else if (maior < 0 && menor < 0) {
                    Console.WriteLine("Números negativos são invalidos... ");
                }
                else {
                    Console.WriteLine("Maior: " + maior +
                                  "\nMenor: " + menor);
                    rodando = false;
                }

            }
        }
        private void Desafio02() {
            bool rodando = true;

            //Para encerrar o programa o código do usuario tem que ser menor ou igual a 0 

            while (rodando) {
                Console.Clear();
                Console.Write("Digite o código do cliente: ");
                int codigo = int.Parse(Console.ReadLine());
                if (codigo <= 0) {
                    Console.WriteLine("Saindo...");
                    rodando = false;
                }
                else {
                    Console.Write("-----MENU-----\n" +
                                  "[1] - Poupança 1,5% a.m.\n" +
                                  "[2] - Poupança Plus 2% a.m.\n" +
                                  "[3] - Fundos de Renda Fixa 4% a.m.\n" +
                                  "Escolha: ");
                    int opcao = int.Parse(Console.ReadLine());

                    switch (opcao) {
                        case 1:
                            Console.Write("Valor do deposito: R$");
                            decimal deposito = decimal.Parse(Console.ReadLine());
                            decimal SaldoInicial = 0m;
                            SaldoInicial = deposito;

                            Console.Write("Quantos meses o dinheiro ficará investido: ");
                            int tempo = int.Parse(Console.ReadLine());

                            decimal rendimento = deposito * (1.5m / 100m);

                            decimal jurospago = 0m;

                            for (int i = 1; i <= tempo; i++) {
                                rendimento = deposito * (1.5m / 100m);
                                deposito += rendimento;
                                jurospago += rendimento;
                            }
                            Console.WriteLine("\n\n-------------------------------\n");
                            Console.WriteLine("Saldo inicial: R$" + SaldoInicial.ToString("F2") + "\n" +
                                              "Total de juros pago: R$" + jurospago.ToString("F2") + "\n" +
                                              "Saldo no final do período: R$" + deposito.ToString("F2"));
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Write("Valor do deposito: R$");
                            deposito = decimal.Parse(Console.ReadLine());
                            SaldoInicial = deposito;

                            Console.Write("Quantos meses o dinheiro ficará investido: ");
                            tempo = int.Parse(Console.ReadLine());

                            jurospago = 0m;

                            for (int i = 1; i <= tempo; i++) {
                                rendimento = deposito * (2m / 100m);
                                deposito += rendimento;
                                jurospago += rendimento;
                            }
                            Console.WriteLine("Saldo inicial: R$" + SaldoInicial.ToString("F2") + "\n" +
                                              "Total de juros pago: R$" + jurospago.ToString("F2") + "\n" +
                                              "Saldo no final do período: R$" + deposito.ToString("F2"));
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Write("Valor do deposito: R$");
                            deposito = decimal.Parse(Console.ReadLine());
                            SaldoInicial = deposito;

                            Console.Write("Quantos meses o dinheiro ficará investido: ");
                            tempo = int.Parse(Console.ReadLine());

                            jurospago = 0m;

                            for (int i = 1; i <= tempo; i++) {
                                rendimento = deposito * (4m / 100m);
                                deposito += rendimento;
                                jurospago += rendimento;
                            }

                            Console.WriteLine("\n\n-------------------------------\n");

                            Console.WriteLine("Saldo inicial: R$" + SaldoInicial.ToString("F2") + "\n" +
                                              "Total de juros pago: R$" + jurospago.ToString("F2") + "\n" +
                                              "Saldo no final do período: R$" + deposito.ToString("F2"));
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Opção Invalida....");
                            Console.ReadKey();
                            break;
                    }
                }

            }
        }
        private void Desafio03() {
            decimal valor1 = 0m, valorauxiliar;
            bool rodando = true;

            while (rodando) {
                Console.Clear();
                Console.WriteLine("----CALCULADORA----");
                Console.WriteLine(valor1.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("-------------------");
                Console.WriteLine("[+] - Adição\n" +
                                  "[-] - Subtração\n" +
                                  "[*] - Multiplicação\n" +
                                  "[/] - Divisão\n" +
                                  "[C] - Limpar Tela\n" +
                                  "[S] - Sair");
                string opcao = Console.ReadLine();

                switch (opcao) {
                    case "+":
                        Console.Write($"{valor1} + ");
                        valorauxiliar = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        valor1 += valorauxiliar;
                        break;
                    case "-":
                        Console.Write($"{valor1} - ");
                        valorauxiliar = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        valor1 -= valorauxiliar;
                        break;
                    case "*":
                        if (valor1 == 0) {
                            Console.Write("Digite o primeiro valor: ");
                            valor1 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Write($"{valor1} * ");
                            valorauxiliar = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        }
                        else {
                            Console.Write($"{valor1} * ");
                            valorauxiliar = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        }
                        valor1 *= valorauxiliar;

                        break;
                    case "/":
                        if (valor1 == 0) {
                            Console.Write("Digite o primeiro valor: ");
                            valor1 = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Write($"{valor1} / ");
                            valorauxiliar = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        }
                        Console.Write($"{valor1} / ");
                        valorauxiliar = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        if (valorauxiliar == 0) {
                            Console.WriteLine("Impossivel realizar divisão por 0");
                            Console.ReadKey();
                        }
                        else
                            valor1 /= valorauxiliar;
                        break;
                    case "C":
                        valor1 = 0;
                        break;
                    case "S":
                        Console.WriteLine("Saindo...");
                        rodando = false;
                        break;
                    default:
                        Console.WriteLine("Opção Invalida....");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void Desafio04() {
            int contador = 0, contador2 = 0;
            string pontos = "*";

            do {
                if (contador <= 3) {
                    contador++;
                    contador2++;
                    Console.WriteLine(pontos);
                    pontos += "*";
                }
                else {
                    contador2--;
                    Console.WriteLine(pontos.Substring(0, contador2));

                }
            } while (contador2 > 0);
        }
        private void Desafio05() {
            //string nomeEpontos = null;

            //Console.Write("Número de partidas: ");
            //int numpartidas = int.Parse(Console.ReadLine());

            //Console.Write("Número de times: ");
            //int numtimes = int.Parse(Console.ReadLine());

            //string[] nometime = new string[numtimes];
            //int[] pontos = new int[numtimes];

            //for (int i = 0; i < numtimes; i++) {
            //    Console.Write("Digite o nome do time e quantidade de pontos: ");
            //    nomeEpontos = Console.ReadLine();

            //    var aux = nomeEpontos.Split(" ");

            //    nometime[i] = aux[0];
            //    pontos[i] = Convert.ToInt32(aux[1]);

            //    Console.WriteLine(nometime[i]);
            //    Console.WriteLine(pontos[i]);
            //}

            //int pontostotal = 0;

            //for (int i = 0; i < numtimes; i++) {
            //    pontostotal += pontos[i];
            //}
            //if (pontostotal > (3 * numpartidas ) && pontostotal < (2 * numpartidas))
            //    Console.WriteLine("Pontos de partidas não condiz com a quantidade total de partidas...");
            //else {

            //}
            
        }
    }
}
