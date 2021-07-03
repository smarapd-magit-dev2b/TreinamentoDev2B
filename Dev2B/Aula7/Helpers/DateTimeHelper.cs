using System;

namespace Aula7.Helpers
{
    public static class DateTimeHelper
    {
        public static DateTime Idade(DateTime dataNascimento) =>
            new DateTime((DateTime.Now - dataNascimento).Ticks);
    }
}
