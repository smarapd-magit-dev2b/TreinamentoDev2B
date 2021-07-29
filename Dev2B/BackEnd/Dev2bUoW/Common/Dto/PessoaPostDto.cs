using System;

namespace Common.Dto
{
    public class PessoaPostDto
    {
        //Dados da Pessoa        
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }

        //Dados do Endereço
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
    }
}
