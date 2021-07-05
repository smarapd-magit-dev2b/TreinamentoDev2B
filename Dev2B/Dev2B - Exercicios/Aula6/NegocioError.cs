using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Aula6
{
    public class NegocioError
    {
        public static int LogarErro(NegocioException nex)
        {
            var idErro = new Random().Next();
            var nomeArquivo = idErro + ".txt";
            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo), nex.ToString());
            return idErro;
        }
    }
}
