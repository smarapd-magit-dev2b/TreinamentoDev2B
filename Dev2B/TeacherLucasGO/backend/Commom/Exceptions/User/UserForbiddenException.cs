using System;

namespace Commom.Exceptions.User
{
    public class UserForbiddenException : Exception
    {
        public UserForbiddenException(string message) : base(message)
        {
        }
    }
}
