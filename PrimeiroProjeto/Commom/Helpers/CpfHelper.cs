using System;
using System.Collections.Generic;

namespace Commom.Helpers
{
    public static class CpfHelper
    {
        public static bool Valido(string documentCpf)
        {
            List<int> cpf = new List<int>();

            foreach (char caractere in documentCpf)
            {
                try
                { cpf.Add(int.Parse(caractere.ToString())); }
                catch (Exception) { }
            }

            if (cpf.Count == 11)
            {
                int soma = 0;

                for (int i = 0; i < 9; i++)
                    soma += cpf[i] * (i + 1);

                if (soma % 11 == cpf[9])
                {
                    soma = 0;

                    for (int i = 0; i < 10; i++)
                        soma += cpf[i] * i;
                    if (soma % 11 == cpf[10])
                        return true;
                }
            }

            return false;
        }
    }
}
