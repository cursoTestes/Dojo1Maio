using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDeVendas
{
    public class VendaRepository
    {
        public List<Venda> GetVendas(int mes, int ano)
        {
            return null;
        }

        public static void Main()
        {
        }
    }

    public class Venda
    {
        public int idVenda{get;set;}
        public  double totalVenda { get; set; }

        public Venda(int id, double total)
        {
            this.idVenda = id;
            this.totalVenda = total;
        }
    }

    public interface IVendaRepository
    {
        List<Venda> GetVendas(int mes, int ano);
    }
}
