using ExemploTemplateBiblioteca;
using NUnit.Framework;

namespace ExemploTemplateTests
{
    public class Tests
    {
        private Calculadora _sujeitoTeste;

        [SetUp]
        public void Setup()
        {
            _sujeitoTeste = new Calculadora();
        }

        [Test]
        public void TesteSomarCalculadora()
        {
            var resultado = _sujeitoTeste.Somar(2, 3);
            Assert.AreEqual(5, resultado);

            resultado = _sujeitoTeste.Somar(4, 10);
            Assert.AreEqual(14, resultado);
        }

        [Test]
        public void TesteSubtrairCalculadora()
        {
            var resultado = _sujeitoTeste.Subtrair(3, 1);
            Assert.AreEqual(2, resultado);

            resultado = _sujeitoTeste.Subtrair(4, 10);
            Assert.AreEqual(-6, resultado);
        }

        [Test]
        public void TesteMultiplicarCalculadora()
        {
            var resultado = _sujeitoTeste.Multiplicar(2, 3);
            Assert.AreEqual(6, resultado);

            resultado = _sujeitoTeste.Multiplicar(4, 10);
            Assert.AreEqual(40, resultado);
        }

        [Test]
        public void TesteDividirCalculadora()
        {
            var resultado = _sujeitoTeste.Dividir(2, 3);
            Assert.AreEqual(0, resultado);

            resultado = _sujeitoTeste.Dividir(10, 4);
            Assert.AreEqual(2, resultado);

            resultado = _sujeitoTeste.Dividir(10, 0);
            Assert.AreEqual(0, resultado);
        }
    }
}