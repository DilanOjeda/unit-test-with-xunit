using Calcualtor;

namespace Calculator.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        CalculatorOperation operation = new CalculatorOperation();
        operation.NumberA = 1;
        operation.NumberB = 59;
        int expected = 60;

        // Act
        var actual = operation.Addition();

        // Assert
        Assert.Equal(expected, actual);
    }
}