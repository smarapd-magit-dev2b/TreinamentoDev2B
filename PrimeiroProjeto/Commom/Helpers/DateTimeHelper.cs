using System;

namespace Commom.Helpers
{
    public static class DateTimeHelper
    {
        public static int Idade(DateTime birthDate) => new DateTime((DateTime.Now - birthDate).Ticks).Year;
    }
}
