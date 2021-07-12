using System;

namespace Common.Helpers
{
    public class DateTimeHelper
    {
        public static int GetIdade(DateTime dataNascimento)
        {
            var idade = new DateTime((DateTime.Now - dataNascimento).Ticks).Year;
            return idade;
        }
    }
}
