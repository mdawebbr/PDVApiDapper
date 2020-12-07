using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using PdvApiDapper.Controllers;
using PdvApiDapper.Models;
using PdvApiDapper.Contex;
using PdvApiDapper.Tools;
using System.Collections.Generic;

namespace NUnitTestPdvApi
{
    [TestClass]
    public class UnitTest1
    {
        PdvRepository pdvRepository = new PdvRepository();

        [TestInitialize]
        public void IniciarTestes()
        {

        }

        [TestMethod]
        public void TestGetAll()
        {
            var resultado = pdvRepository.GetAll();
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void TestGetById()
        {
            var resultado = pdvRepository.GetById(1);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void TestAdd()
        {
            Tools tools = new Tools();
            Pdv newPdv = new Pdv();
            newPdv.Pagamento = 100;
            newPdv.Preco = 33.54;
            newPdv.Troco = newPdv.Pagamento - newPdv.Preco;
            newPdv.NotasMoedas = tools.CalculaNotas(newPdv.Pagamento, newPdv.Preco);
            var resultado = pdvRepository.Add(newPdv);
            Assert.AreEqual(true, resultado);
        }
        
        [TestMethod]
        public void TestUpdte()
        {
            Tools tools = new Tools();
            Pdv newPdv = new Pdv();
            newPdv.PdvId = 1;
            newPdv.Pagamento = 100;
            newPdv.Preco = 33.54;
            newPdv.Troco = newPdv.Pagamento - newPdv.Preco;
            newPdv.NotasMoedas = tools.CalculaNotas(newPdv.Pagamento, newPdv.Preco);
            var resultado = pdvRepository.Update(newPdv);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void TestDelete()
        {
            Pdv newPdv = new Pdv();
            newPdv.PdvId = 1;
            var resultado = pdvRepository.Delete(newPdv.PdvId);
            Assert.AreEqual(true, resultado);
        }

        [TestCleanup]
        public void FinalizarTestes()
        {
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}