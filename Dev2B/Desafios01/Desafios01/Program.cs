using System;

namespace Desafios01 {
    class Program {
        static void Main(string[] args) {
            Desafio01();
        }
        static void Desafio01() {
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
                        else if(contador < menor && contador > 0){
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
    }
}
