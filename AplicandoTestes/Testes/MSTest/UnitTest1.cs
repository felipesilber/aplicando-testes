using Microsoft.VisualStudio.TestTools.UnitTesting;
using Temperatura;

namespace MSTest
{
    [TestClass]
    public class TestesConversorTemperatura
    {
        [DataRow(32, 0)]
        [DataRow(212, 100)]
        [DataRow(50,10)]
        [DataTestMethod]
        public void TestarFahrenheitParaCelsius(double fahrenheit, double celsiusEsperado)
        {
            double celsius = ConversorTemperatura.FahrenheitParaCelsius(fahrenheit);
            Assert.AreEqual(celsiusEsperado, celsius);
        }

        [DataRow(32, 1)]
        [DataRow(212, 101)]
        [DataTestMethod]
        public void TestarFahrenheitParaCelsiusFalha(double fahrenheit, double celsiusEsperado)
        {
            double celsius = ConversorTemperatura.FahrenheitParaCelsius(fahrenheit);
            Assert.AreEqual(celsiusEsperado, celsius);
        }
    }
}