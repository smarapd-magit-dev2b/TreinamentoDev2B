using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_2.Exercicio_4
{
    public class Exercicio_4
    {
       public void Executar_Aula2Ex4()
        {
            //Variavel-----------------------

            Aluno A1;
            Professor P1;
            Disciplina D1;


            //Dados Aluno-------------------

            Console.WriteLine("\n Cadastro Aluno ");

            Console.WriteLine("\nDigite o nome do aluno: ");
            string nomea = Console.ReadLine();

            Console.WriteLine("\nDigite a data de nascimento: ");
            DateTime dataa = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("\nDigite o endereço: ");
            string endea = Console.ReadLine();

            Console.WriteLine("\n Digite o Telefone: ");
            int telea = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Digite o email: ");
            string emaia = Console.ReadLine();

            Console.WriteLine("\n Digite a nacionalidade: ");
            string naciona = Console.ReadLine();

            Console.WriteLine("\n Digite a cidade: ");
            string cidada = Console.ReadLine();

            Console.WriteLine("\n Digite o estado: ");
            string estadoa = Console.ReadLine();

            Console.WriteLine("\n Digite a data de matricula: ");
            DateTime datama = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("\n Digite o RA: ");
            int ra = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Digite o nome do professor: ");
            string profa = Console.ReadLine();

            A1 = new Aluno(nomea, dataa, endea, telea, emaia, naciona, cidada, estadoa, datama, ra, profa);


            //Dados Professor---------------

            Console.WriteLine("\n Cadastro Professor ");

            Console.WriteLine("\nDigite o nome do professor: ");
            string nomep = Console.ReadLine();

            Console.WriteLine("\nDigite a data de nascimento: ");
            DateTime datap = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("\nDigite o endereço: ");
            string endep = Console.ReadLine();

            Console.WriteLine("\nDigite o Telefone: ");
            int telep = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o email: ");
            string emaip = Console.ReadLine();

            Console.WriteLine("\nDigite a nacionalidade: ");
            string nacionp = Console.ReadLine();

            Console.WriteLine("\nDigite a cidade: ");
            string cidadp = Console.ReadLine();

            Console.WriteLine("\nDigite o estado: ");
            string estadop = Console.ReadLine();

            Console.WriteLine("\nDigite a CNH: ");
            int cnh = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite a data de admição: ");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("\nDigite Registro do professor: ");
            int rp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite seu salário: ");
            decimal sala = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nDigite a disciplina ");
            string dis = Console.ReadLine();

            P1 = new Professor(nomep, datap, endep, telep, emaip, nacionp, cidadp, estadop, cnh, date, rp, sala, dis);


            //Dados disciplina--------------

            Console.WriteLine("\n Cadastro Disciplina ");

            Console.WriteLine("\nDigite o nome da disciplina: ");
            string nomed = Console.ReadLine();

            Console.WriteLine("\nDigite o CID: ");
            int cid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o curso: ");
            string cur = Console.ReadLine();

            Console.WriteLine("\n Data de inclusão: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            D1 = new Disciplina(nomed, cid, cur, data);

            //Mensagem----------------------

            Console.WriteLine("\n Cadastro aluno: \n");
            A1.Escreverinformacoes3();

            Console.WriteLine("\n Cadastro Professor: \n");
            P1.Escreverinformacoes2();

            Console.WriteLine("\n Cadastro Disciplina: \n");
            D1.Escreverinformacoes1();

        }


    }
}
