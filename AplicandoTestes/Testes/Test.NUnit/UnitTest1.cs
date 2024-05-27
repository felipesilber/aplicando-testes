using NUnit.Framework;
using AplicandoTestesApp;

namespace Temperatura
{
    public class TestesConversorTemperatura
    {
        [TestCase(32, 0)]
        [TestCase(212, 100)]
        public void TestarConversaoTemperatura(double fahrenheit, double celsiusEsperado)
        {
            double celsius = ConversorTemperatura.FahrenheitParaCelsius(fahrenheit);
            Assert.AreEqual(celsiusEsperado, celsius);
        }

        [TestCase(32, 10)]
        [TestCase(47, 20)]
        public void TestarConversaoTemperaturaFalha(double fahrenheit, double celsiusEsperado)
        {
            double celsius = ConversorTemperatura.FahrenheitParaCelsius(fahrenheit);
            Assert.AreEqual(celsiusEsperado, celsius);
        }
    }
}
