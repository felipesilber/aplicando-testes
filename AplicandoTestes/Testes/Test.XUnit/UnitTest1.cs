using Xunit;
using AplicandoTestesApp;

namespace Test.XUnit.Temperatura
{
    public class TestesConversorTemperatura
    {
        [Theory]
        [InlineData(32, 0)]
        [InlineData(212, 100)]
        public void TestarConversaoTemperatura(double fahrenheit, double celsius)
        {
            double valorCalculado = ConversorTemperatura.FahrenheitParaCelsius(fahrenheit);
            Assert.Equal(celsius, valorCalculado);
        }

        [Theory]
        [InlineData(32, 10)]
        [InlineData(47, 20)]
        public void TestarConversaoTemperaturaFalha(double fahrenheit, double celsius)
        {
            double valorCalculado = ConversorTemperatura.FahrenheitParaCelsius(fahrenheit);
            Assert.Equal(celsius, valorCalculado);
        }
    }
}
