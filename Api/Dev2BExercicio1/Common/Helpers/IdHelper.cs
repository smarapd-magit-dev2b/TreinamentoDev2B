using System;

namespace Common.Helpers
{
    public class IdHelper
    {
        public static int GenerateId()
        {
            var id = new Random().Next();
            return id;
        }
    }
}
