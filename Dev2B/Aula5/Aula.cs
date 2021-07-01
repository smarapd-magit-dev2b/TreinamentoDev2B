using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Aula5
{
    class Aula
    {
        public void Listas()
        {
            var ListaPessoas = new List<Pessoa> {
                new Pessoa()
                {
                    Nome = "ze", Sobrenome = "silva", Cpf = "11245", Nascimento = new DateTime(1194,12,02)
                },
                new Pessoa()
                {
                    Nome = "zezinho", Sobrenome = "silva", Cpf = "112485", Nascimento = new DateTime(1194,12,03)
                },
                new Pessoa()
                {
                    Nome = "zezao", Sobrenome = "silva", Cpf = "112452", Nascimento = new DateTime(1194,12,04)
                }
            };
            foreach (var pessoa in ListaPessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}, Sobrenome: {pessoa.Sobrenome}, Cpf: {pessoa.Cpf}, Nascimento: {pessoa.Nascimento.ToString("dd/MM/yyyy")}");
            }
            var MaioresDeIdade = ListaPessoas.Where(x => new DateTime((DateTime.Now - x.Nascimento).Ticks).Year > 18);
            foreach (var pessoa in MaioresDeIdade)
            {
                pessoa.Sobrenome = pessoa.Sobrenome + " maior de idade";
            }
        }
    }
}
