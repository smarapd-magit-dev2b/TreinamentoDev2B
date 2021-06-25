using System;

namespace Aula3.Classes.ClassesExe01 {
    public class Fornecedor : Pessoa {
        public int CNPJ { get; set; }
        public string Segmento { get; set; }
        public string Produto { get; set; }
        
        public Fornecedor(string nome, string endereco, int telefone, int cnpj, string segmento, string produto)
            : base(nome, endereco, telefone) {          
            CNPJ = cnpj;
            Segmento = segmento;
            Produto = produto;
        }
    }
}
