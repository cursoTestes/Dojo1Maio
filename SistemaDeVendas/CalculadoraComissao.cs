using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDeVendas
{
    public class CalculadoraComissao
    {
        public double calculaComissao(double p)
        {
            double resultado;

            if (p <= 10000)
            {
                resultado = p * 5;
            }
            else
            {
                resultado = p * 6;
            }

            resultado = Math.Floor(resultado);
            resultado /= 100;

            return resultado;
        }
    }

    public interface ICalculadoraComissao
    {
        double calculaComissao(double p);
    }
}
