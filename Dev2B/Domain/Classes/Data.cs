using System;

namespace Domain.Classes
{
    public class Data
    {
        public int? Dia { get; set; }
        public int? Mes { get; set; }
        public int? Ano { get; set; }

        private bool Mes31()
        {
            return Mes == 1 || Mes == 3 || Mes == 5 || Mes == 7 || Mes == 8 || Mes == 10 || Mes == 12;
        }
        private bool Mes30()
        {
            return Mes == 4 || Mes == 6 || Mes == 9 || Mes == 11;
        }
        private bool Mes29()
        {
            return Mes == 2 && (Ano % 4) == 0;
        }
        private bool Mes28()
        {
            return Mes == 2 && (Ano % 4) != 0;
        }

        public Data(int dia, int mes, int ano)
        {
            Ano = ano;
            if (ValidateMes(mes))
            {
                Mes = mes;
                if (ValidateDia(dia))
                    Dia = dia;
            }
        }

        public Data() { }

        private bool ValidateMes(int mes)
        {
            if (mes > 0 && mes < 13)
                return true;
            else
                return false;
        }

        private bool ValidateDia(int dia)
        {
            if (Mes31() && dia >= 1 && dia <= 31)
                return true;
            else if (Mes30() && dia >= 1 && dia <= 30)
                return true;
            else if (Mes29() && dia >= 1 && dia <= 29)
                return true;
            else if (Mes28() && dia >= 1 && dia <= 28)
                return true;
            else
                return false;
        }

        public string ToUserString()
        {
            if (Dia != null && Mes != null && Ano != null)
                return Convert.ToString(Dia) + "/" + Convert.ToString(Mes) + "/" + Convert.ToString(Ano);
            else
                return "Data Inválida";
        }

        public void ProximoDia()
        {
            if (Dia != null && Mes != null && Ano != null)
            {
                Dia++;
                int? proximoMes = Mes;
                if (Mes31() && Dia == 32)
                {
                    proximoMes++;
                    Dia = 1;
                }
                else if (Mes30() && Dia == 31)
                {
                    proximoMes++;
                    Dia = 1;
                }
                else if (Mes29() && Dia == 30)
                {
                    proximoMes++;
                    Dia = 1;
                }
                else if (Mes28() && Dia == 29)
                {
                    proximoMes++;
                    Dia = 1;
                }
                Mes = proximoMes;
                if (Mes == 13)
                {
                    Ano++;
                    Mes = 1;
                }
            }
        }
    }
}
