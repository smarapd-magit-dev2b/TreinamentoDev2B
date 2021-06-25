using System;
using System.Collections.Generic;
using System.Text;
using Aula2.Exercicio1;
using Aula2.Exercicio2;
using Aula2.Exercicio3;
using Aula2.Exercicio4;
using Aula2.Exercicio5__Extra_;


namespace Aula2
{
    public class ExerciciosAula2
    {
        private void Exercicio1()
        {
            Console.WriteLine("digite o numero do produto, descrição, quantidade comprada e valor unitario: ");
            ItemVenda Item = new ItemVenda(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine(Item.calcularValorTotal());
            Console.ReadLine();
        } 
        private void Exercicio2()
        {
            Console.WriteLine("digite o nome, sobrenome e salario mensal: ");
            Empregado Empregado = new Empregado(Console.ReadLine(), Console.ReadLine(), Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine("Salario Anual:" + Empregado.calcularSalarioAtual());
            Console.WriteLine("qual o reajuste de salario? ");
            Empregado.reajustarSalario(Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine("Novo salario: " + Empregado.SalarioMensal);
        }
        private void Exercicio3()
        {
            Data Data = new Data();
            Console.WriteLine("Dia de hoje: " + Data.toString());
            Data.proximoDia();
            Console.WriteLine("Proximo dia: " + Data.toString());
        }
        private void Exercicio4()
        {
            Console.WriteLine("Preencha os dados do Aluno:");
            Console.WriteLine("Nome, data de nascimento, endereço, telefone, email, \n Nacionalidade, Cidade, Estado, Data de matricula, Registro");
            Aluno Aluno = new Aluno(Console.ReadLine(), Convert.ToDateTime(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Convert.ToDateTime(Console.ReadLine()), Console.ReadLine());
            Console.WriteLine("Preencha os dados do Professor:");
            Console.WriteLine("Nome, data de nascimento, endereço, telefone, email, \n Nacionalidade, cidade, estado, cnh, data de admissao \n registro de professor, salario");
            Aluno.Professor = new Professor(Console.ReadLine(), Convert.ToDateTime(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Convert.ToDateTime(Console.ReadLine()), Console.ReadLine(), Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine("Preencha os dados da Disciplina:");
            Console.WriteLine("Nome, CID, Curso");
            Aluno.Professor.Disciplina = new Disciplina(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Convert.ToDateTime(Console.ReadLine()));
            Console.WriteLine($"{Aluno.Nome} {Aluno.DataNascimento} {Aluno.Endereco} {Aluno.Telefone} \n " +
                $"{Aluno.Email} {Aluno.Nacionalidade} {Aluno.Cidade} {Aluno.Estado} {Aluno.DataMatricula} {Aluno.RegistroAluno}");
            Console.WriteLine($"{Aluno.Professor.Nome} {Aluno.Professor.DataNascimento} {Aluno.Professor.Endereco} {Aluno.Professor.Telefone} {Aluno.Professor.Email} {Aluno.Professor.Nacionalidade} \n {Aluno.Professor.Estado} {Aluno.Professor.Cidade} {Aluno.Professor.Cnh} \n {Aluno.Professor.DataAdmissao} {Aluno.Professor.RegistroProfessor} {Aluno.Professor.Salario}");
            Console.WriteLine($" {Aluno.Professor.Disciplina.Nome} {Aluno.Professor.Disciplina.Cid} {Aluno.Professor.Disciplina.Curso} {Aluno.Professor.Disciplina.DataInclusao}");
        }
        private void Exercicio5()
        {
            Marca Marca = new Marca();
            Console.WriteLine("Digite o nome, cpf e rg do proprietario: ");
            Proprietario Proprietario = new Proprietario(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), new Endereco());
            Carro Carro = new Carro(Proprietario, Marca);
        }
    }
}
