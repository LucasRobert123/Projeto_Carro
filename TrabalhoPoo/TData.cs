using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPoo
{
    class TData
    {
        private int dia, mes, ano;
        public TData()
        {
        }

        public bool GravarData(int d, int m, int a)
        {
            bool Ok = false;
            if (((d > 0) && (d < 31)) && ((m > 0) && (m < 13)) && (a > 0))
            {
                dia = d;
                mes = m;
                ano = a;
                Ok = true;
            }
            return Ok;
        }
        public string MostrarData()
        {
            string aux = "";

            aux = dia.ToString("00");
            aux += mes.ToString("/00");
            aux += ano.ToString("/00");

            return aux;
        }
    }
}
