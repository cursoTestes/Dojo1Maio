using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaDeVendas;
using Moq;

namespace TesteVendas
{
    [TestClass]
    public class TesteCalculadoraRoyalties
    {
        ICalculadoraComissao calculadora;
        Mock<IVendaRepository> mock;

        [TestInitialize]
        public void metodoSetup()
        {
            Mock<ICalculadoraComissao> mockCalculadoraComissao = new Mock<ICalculadoraComissao>();
            mockCalculadoraComissao.Setup(calc => calc.calculaComissao(It.IsAny<double>())).Returns(0);

            calculadora = mockCalculadoraComissao.Object;

            mock = new Mock<IVendaRepository>();

        }

        [TestMethod]
        public void TestUmaVenda100Retorna20()
        {
            List<SistemaDeVendas.Venda> listaVenda = new List<SistemaDeVendas.Venda>();
            listaVenda.Add(new SistemaDeVendas.Venda(1, 100));

            mock.Setup(repository => repository.GetVendas(1, 2012))   .Returns(listaVenda);
            IVendaRepository vendaRepository = mock.Object;

        
            CalculadoraRoyalties cR = new CalculadoraRoyalties(vendaRepository, calculadora);

            double royaltiesEsperados = 20;
            int mes = 1;
            int ano = 2012;
            double royaltiesCalculados = cR.calculaRoyalties(mes, ano);

            Assert.AreEqual(royaltiesEsperados, royaltiesCalculados);
        }

        [TestMethod]
        public void TestUmaVenda1000Retorna200()
        {
            List<SistemaDeVendas.Venda> listaVenda = new List<SistemaDeVendas.Venda>();
            listaVenda.Add(new SistemaDeVendas.Venda(1, 1000));

            mock.Setup(repository => repository.GetVendas(2, 2012)).Returns(listaVenda);

            IVendaRepository vendaRepository = mock.Object;

            CalculadoraRoyalties cR = new CalculadoraRoyalties(vendaRepository, calculadora);

            double royaltiesEsperados = 200;
            int mes = 2;
            int ano = 2012;
            double royaltiesCalculados = cR.calculaRoyalties(mes, ano);

            Assert.AreEqual(royaltiesEsperados, royaltiesCalculados);
        }

    }
}
