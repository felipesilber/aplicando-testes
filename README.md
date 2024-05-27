# Aplicando Testes com dotNet

## Introdução
Este documento tem como objetivo esclarecer e explicitar a implementação de 3 tipos de testes unitários utilizando dotNet: MSTest, XUnit e NUnit

- **MSTest:** utiliza o ```[DataRow]``` para trabalhar com parâmetros.
- **XUnit:** utiliza o ```[Theory]``` para indicar que o teste será feito com parâmetros e utiliza o ```[InlineData]``` para passar os parâmetros.
- **NUnit:** utiliza o ```[TestCase]``` para indicar os valores dos parâmetros a serem testados.

## Função a ser testada

```csharp
public static double FahrenheitParaCelsius(double fahrenheit)
        {
            return Math.Round((fahrenheit - 32) / 1.8, 2);
        }
```

## Execução dos testes

### MSTest

#### Sucesso
![MSTest_sucesso](./Assets/mstest.png)

#### Falha
![MSTest_falha](./Assets/mstestfalha.png)

### XUnit

#### Sucesso
![XUnit_sucesso](./Assets/xunit.png)

#### Falha
![XUnit_falha](./Assets/xunitfalha.png)

### NUnit

#### Sucesso
![NUnit_sucesso](./Assets/nunit.png)

#### Falha
![NUnit_falha](./Assets/nunitfalha.png)
