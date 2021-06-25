using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3.Domain
{
    public class Funcionario : PessoaFisica
    {
        public Funcionario(string nome, string endereco, string telefone
            , string celular, string rg, string cpf, int qntFilhos
            , string estadoCivil, decimal salario, string cnh, DateTime dataAdmissao) 
            : base(nome, endereco, telefone, celular, rg, cpf, qntFilhos, estadoCivil)
        {
            Salario = salario;
            CNH = cnh;
            DataAdmissao = dataAdmissao;
        }

        public decimal Salario { get; set; }
        public string CNH { get; set; }
        public DateTime DataAdmissao { get; set; }
        
    }
}
