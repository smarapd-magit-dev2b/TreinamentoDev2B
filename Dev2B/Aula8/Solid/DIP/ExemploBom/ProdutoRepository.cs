using System;
using System.Collections.Generic;
using System.Text;

namespace Aula8.DIP.ExemploBom
{
    public class ProdutoRepository
    {
        private IDbConnection Connection { get; set; }
        public ProdutoRepository(IDbConnection connection)
        {
            Connection = connection;
            Connection.Connect();
        }
        public void Save()
        {
            //abreviado
        }
    }
}
