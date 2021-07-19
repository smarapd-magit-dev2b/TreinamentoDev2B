using Aula2.Classes;
using Common.Interfaces;
using System;

namespace Aula2
{
    public class Exercicio4 : IExecute
    {
        public void Execute()
        {
            Aluno aluno = new Aluno()
            {
                Nome = "Lucas",
                Telefone = "00928922",
                Email = "arroba@arroba",
                Nacionalidade = "Cubano",
                Ra = 3812938,
                DataNascimento = new DateTime(2015, 10, 20)
            };

            aluno.Endereco.Rua = "Rua Domingos Rizzo";
            aluno.Endereco.Cidade = "Jardim Nópolis";
            aluno.Endereco.Estado = "Serjipe";
            aluno.DataMatricula = new DateTime(1978, 12, 03);
            aluno.Professor.Nome = "Glenilsson";
            aluno.Professor.Endereco.Rua = "Rua Onório Reberbes";
            aluno.Professor.Telefone = "3902193";
            aluno.Professor.Email = "luras@arroba";
            aluno.Professor.Nacionalidade = "Romano";
            aluno.Professor.Endereco.Cidade = "Sutão";
            aluno.Professor.Endereco.Estado = "Santa Catarina";
            aluno.Professor.Cnh = "3213";
            aluno.Professor.DataAdmissao.Dia = 12;
            aluno.Professor.DataAdmissao.Mes = 12;
            aluno.Professor.DataAdmissao.Ano = 3021;
            aluno.Professor.Registro = 33213423;
            aluno.Professor.Salario = 20000;
            aluno.Professor.Disciplina.Nome = "Redes";
            aluno.Professor.Disciplina.Cid = 321312;
            aluno.Professor.Disciplina.Curso = "Ciência";
            aluno.Professor.Disciplina.DataInclusao = new DateTime(2003, 03, 12);

            Console.WriteLine(aluno);
        }
    }
}
