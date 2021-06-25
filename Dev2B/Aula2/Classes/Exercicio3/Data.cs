using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Data
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        public Data()
        {
            Dia = DateTime.Now.Day;
            Mes = DateTime.Now.Month;
            Ano = DateTime.Now.Year;
        }

        public Data(int dia, int mes, int ano)
        {
            if (dia > 0 && dia <= 30)
                Dia = dia;
            else
                throw new Exception("Dia invalido");

            if (mes > 0 && mes <= 12)
                Mes = mes;
            else
                throw new Exception("Mes invalido");

            if (ano > 0)
                Ano = ano;
            else
                throw new Exception("Ano invalido");
        }

        public void ProximoDia()
        {
            if (Dia == 30)
            {
                Dia = 1;
                ProximoMes();
            }
            else
                Dia++;
        }
        private void ProximoMes()
        {
            if (Mes == 12)
            {
                Mes = 1;
                ProximoAno();
            }
            else
                Mes++;
        }
        private void ProximoAno()
        {
            Ano++;
        }

        public override string ToString()
        {
            return $"{Dia}/{Mes}/{Ano}";
        }
    }
}
