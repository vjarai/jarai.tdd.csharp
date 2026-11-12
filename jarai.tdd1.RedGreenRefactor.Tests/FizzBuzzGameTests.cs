using Xunit;

namespace jarai.tdd1.RedGreenRefactor.Tests;

public class FizzBuzzGameTests
{
    [Fact]
    public void Given_InputIs1_When_GetResponse_Then_ReturnsNumber1()
    {
        // Arrange
        var sut = new FizzBuzzGame();

        // Act
        object actual = sut.GetResponse(1);

        // Assert
        Assert.Equal(1, actual);
    }

    [Fact]
    public void Given_InputIsDivisibleBy3Only_When_GetResponse_Then_ReturnsFizz()
    {
        // Arrange
        var sut = new FizzBuzzGame();

        // Act
        object actual = sut.GetResponse(3);

        // Assert
        Assert.Equal("Fizz", actual);
    }

    [Fact]
    public void Given_InputIsDivisibleBy5Only_When_GetResponse_Then_ReturnsBuzz()
    {
        // Arrange
        var sut = new FizzBuzzGame();

        // Act
        object actual = sut.GetResponse(5);

        // Assert
        Assert.Equal("Buzz", actual);
    }

    [Fact]
    public void Given_InputIsDivisibleBy3And5_When_GetResponse_Then_ReturnsFizzBuzz()
    {
        // Arrange
        var sut = new FizzBuzzGame();

        // Act
        object actual = sut.GetResponse(15);

        // Assert
        Assert.Equal("FizzBuzz", actual);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(101)]
    public void Given_InputIsOutsideRange1To100_When_GetResponse_Then_ThrowsArgumentOutOfRangeException(int input)
    {
        // Arrange
        var sut = new FizzBuzzGame();

        // Act
        Assert.Throws<ArgumentOutOfRangeException>(() => sut.GetResponse(input));
    }

    /// <summary>
    ///     Parametrisierter Test: Deckt alle einfachem Testfälle in einem einzigen Test ab
    /// </summary>
    [Theory]
    [InlineData(1, 1)]
    [InlineData(3, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(15, "FizzBuzz")]
    public void Given_ValidInputCases_When_GetResponse_Then_ReturnsExpectedValue(int input, object expected)
    {
        // Arrange
        var sut = new FizzBuzzGame();

        // Act
        object actual = sut.GetResponse(input);

        // Assert
        Assert.Equal(expected, actual);
    }
}