using System;

namespace Aula7.Exceptions
{
    public class NegocioException : Exception
    {
        public override string Message =>
            "Erro de negócio: não existe pessoas com mais de 90 anos";
    }
}
