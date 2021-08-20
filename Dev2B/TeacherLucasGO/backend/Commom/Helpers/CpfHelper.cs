﻿using System;
using System.Collections.Generic;

namespace Commom.Helpers
{
    public static class CpfHelper
    {
        public static bool Validate(string cpf)
        {
            NoDot(cpf);

            List<int> cpfNumber = ToListInt(cpf);

            return IsValid(cpfNumber);
        }

        public static void NoDot(string cpf)
        {
            if (!Has11numbers(cpf))
            {
                _ = cpf.Replace(".", "")
                       .Replace("-", "");
            }
        }

        public static List<int> ToListInt(string docCpf)
        {
            List<int> cpf = new List<int>();

            foreach (char character in docCpf)
            {
                try
                {
                    int number = int.Parse(character.ToString());

                    cpf.Add(number);
                }
                catch (FormatException) { }
            }

            return cpf;
        }

        public static bool IsValid(List<int> cpf)
        {
            if (Has11numbers(cpf))
            {
                int sum = 0;
                int multiplier = 11;

                foreach (int number in cpf.GetRange(0, 9))
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

        private static bool Has11numbers(string cpf) => cpf.Length == 11;

        private static bool Has11numbers(List<int> cpf) => cpf.Count == 11;
    }
}
