using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDeVendas;

namespace TesteVendas
{
    [TestClass]
    public class TesteCalculaComissao
    {
        [TestMethod]
        public void TestVenda100ReaisCalculaComissaoIguala5()
        {
            double valorComissao = 5;
            double valorVendas = 100;
            double valorCalculado;

            CalculadoraComissao cc = new CalculadoraComissao();
            valorCalculado = cc.calculaComissao(valorVendas);
            Assert.AreEqual(valorComissao, valorCalculado);
        }

        [TestMethod]
        public void TestVenda1000ReaisCalculaComissaoIguala50()
        {
            double valorComissao = 50;
            double valorVendas = 1000;
            double valorCalculado;

            CalculadoraComissao cc = new CalculadoraComissao();
            valorCalculado = cc.calculaComissao(valorVendas);
            Assert.AreEqual(valorComissao, valorCalculado);
        }

        [TestMethod]
        public void TestVenda500ReaisCalculaComissaoIguala25()
        {
            double valorComissao = 25;
            double valorVendas = 500;
            double valorCalculado;

            CalculadoraComissao cc = new CalculadoraComissao();
            valorCalculado = cc.calculaComissao(valorVendas);
            Assert.AreEqual(valorComissao, valorCalculado);
        }

        [TestMethod]
        public void TestVenda100000ReaisCalculaComissaoIguala6000()
        {
            double valorComissao = 6000;
            double valorVendas = 100000;
            double valorCalculado;

            CalculadoraComissao cc = new CalculadoraComissao();
            valorCalculado = cc.calculaComissao(valorVendas);
            Assert.AreEqual(valorComissao, valorCalculado);
        }

        [TestMethod]
        public void TestVenda10000ReaisCalculaComissaoIguala500()
        {
            double valorComissao = 500;
            double valorVendas = 10000;
            double valorCalculado;

            CalculadoraComissao cc = new CalculadoraComissao();
            valorCalculado = cc.calculaComissao(valorVendas);
            Assert.AreEqual(valorComissao, valorCalculado);
        }

        [TestMethod]
        public void TestVenda10000Reais49CentavosCalculaComissaoIguala600Reais2Centavos()
        {
            double valorComissao = 600.02;
            double valorVendas = 10000.49;
            double valorCalculado;

            CalculadoraComissao cc = new CalculadoraComissao();
            valorCalculado = cc.calculaComissao(valorVendas);
            Assert.AreEqual(valorComissao, valorCalculado);
        }

    }
}
