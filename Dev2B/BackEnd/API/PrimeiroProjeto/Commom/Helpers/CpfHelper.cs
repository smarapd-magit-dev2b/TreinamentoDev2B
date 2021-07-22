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
                int multiplicador = 11;

                foreach (int digito in cpf.GetRange(0,9))
                {
                    multiplicador--;

                    soma += digito * multiplicador;
                }

                if (soma * 10 % 11 == cpf[9])
                {
                    soma = 0;
                    multiplicador = 12;

                    foreach (int digito in cpf.GetRange(0, 10))
                    {
                        multiplicador--;

                        soma += digito * multiplicador;
                    }

                    if (soma * 10 % 11 == cpf[10])
                        return true;
                }
            }

            return false;
        }
    }
}
