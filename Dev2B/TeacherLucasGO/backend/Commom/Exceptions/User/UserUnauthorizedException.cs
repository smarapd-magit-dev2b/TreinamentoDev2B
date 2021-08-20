using System;

namespace Commom.Exceptions.User
{
    public class UserUnauthorizedException : Exception
    {
        public UserUnauthorizedException(string message) : base(message)
        {
        }
    }
}
