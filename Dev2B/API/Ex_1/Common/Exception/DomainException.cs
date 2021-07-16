using System;

namespace Common.Exceptions
{
    
    //Classe responsavel para retornar mensagem
   public class DomainException : Exception
    {
      public DomainException(string message) : base(message) { }
   
    }
}
