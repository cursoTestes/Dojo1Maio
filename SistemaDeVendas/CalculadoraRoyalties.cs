using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDeVendas
{
    public class CalculadoraRoyalties
    {
        
        private IVendaRepository iRepositorioVendas;
        private ICalculadoraComissao calculoComissao ;
        
        public CalculadoraRoyalties(IVendaRepository iRepositorioVendas, ICalculadoraComissao calculoComissao)
        {
            this.calculoComissao = calculoComissao;
            this.iRepositorioVendas = iRepositorioVendas;
        }

        public Double calculaRoyalties(int mes, int ano)
        {
            List<Venda> lista = iRepositorioVendas.GetVendas(mes, ano);
            double vendasLiquidas=0;
            foreach (Venda v in lista)
            {
                double liquido = v.totalVenda - calculoComissao.calculaComissao(v.totalVenda);
                vendasLiquidas += liquido;
            }

            return vendasLiquidas * 0.2;
        }
    }
}
