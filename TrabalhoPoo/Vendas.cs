using System;
using System.Collections.Generic;

namespace TrabalhoPoo
{
    class Vendas
    {
        private List<Carro> LV = new List<Carro>();
        private TData datavenda = new TData();
        private Cliente comprador;
        public List<Carro> Lv { get => LV; set => LV = value; }
        public TData Datavenda { get => datavenda; set => datavenda = value; }
        public Cliente Comprador { get => comprador; set => comprador = value; }

        public void AddCarro(Carro C)
        {
            Lv.Add(C);
        }
        public void SetDataVenda(int d, int m, int a)
        {
            
            if (!Datavenda.GravarData(d, m, a))
            {
                Console.WriteLine("Data Inválida");
            }
            
        }
        public string GetDataVenda()
        {
            return Datavenda.MostrarData();
        }

        public string MostraDados()
        {
            string s = "Data: " + GetDataVenda() + "\n" +
                   comprador.MostraDados() + "\n" +
                   "Veículo(s):\n";
            foreach (Carro c in LV) { s += c.MostraDados(); }
            return s;
        }
    }
}
