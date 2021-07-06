using System;
using System.Collections.Generic;
using System.Text;

namespace Aula8.DIP.ExemploRuim
{
    public class ProdutoRepository
    {
        private SqlConnection Connection { get; set; }
        public ProdutoRepository(SqlConnection connection)
        {
            Connection = connection;
            Connection.ConnectSql();
        }
        public void Save()
        {
            //abreviado
        }
    }
}
