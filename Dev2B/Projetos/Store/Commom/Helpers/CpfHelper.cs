using System;
using System.Collections.Generic;

namespace Commom.Helpers
{
    public static class CpfHelper
    {
        public static bool Validate(string docCpf)
        {
            List<int> cpf = noPoint(docCpf);

            if (cpf.Count == 11)
            {
                int sum = 0;
                int multiplier = 11;

                foreach (int number in cpf.GetRange(0,9))
                    sum += number * --multiplier;

                int rest = sum % 11;

                int digit = 0;

                if (rest >= 2)
                    digit = 11 - rest;


                if (digit == cpf[9])
                {
                    sum = 0;
                    multiplier = 12;

                    foreach (int number in cpf.GetRange(0, 10))
                        sum += number * --multiplier;

                    rest = sum % 11;

                    digit = 0;

                    if (rest >= 2)
                        digit = 11 - rest;

                    if (digit == cpf[10])
                        return true;
                }
            }

            return false;
        }

        public static string cpfNoPoint(string docCpf)
        {
            List<int> noPointList = noPoint(docCpf);

            string cpf = "";

            foreach (int digit in noPointList)
                cpf += digit;

            return cpf;
        }

        private static List<int> noPoint(string docCpf)
        {
            List<int> cpf = new List<int>();

            foreach (char character in docCpf)
            {
                try
                { cpf.Add(int.Parse(character.ToString())); }
                catch (Exception) { }
            }

            return cpf;
        }
    }
}
