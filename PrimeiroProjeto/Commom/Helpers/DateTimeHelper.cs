using System;

namespace Commom.Helpers
{
    public static class DateTimeHelper
    {
        public static int Idade(DateTime dataNascimento) => new DateTime((DateTime.Now - dataNascimento).Ticks).Year;
    }
}
