using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPoo
{
    class Carro
    {
        protected string nomecarro;
        protected string cor;
        protected string numchaci;
        protected double valor;
        public string Nomecarro { get => nomecarro; set => nomecarro = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Numchaci { get => numchaci; set => numchaci = value; }
        public double Valor { get => valor; set => valor = value; }

        public string MostraDados()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Nome do carro: " + nomecarro);
            str.AppendLine("Cor do carro: " + cor);
            str.AppendLine("Nº do chaci: " + numchaci);
            str.AppendLine("Valor do carro: " + valor);
            return str.ToString();
        }
    }
}
