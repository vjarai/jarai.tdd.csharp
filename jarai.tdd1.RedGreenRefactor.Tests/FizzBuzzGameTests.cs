using Xunit;

namespace jarai.tdd1.RedGreenRefactor.Tests;

public class FizzBuzzGameTests
{
    [Fact]
    public void GivenInputIs1_WhenGetResponse_ThenReturnsNumber1()
    {
        // Arrange
        var game = new FizzBuzzGame();

        // Act
        object actual = game.GetResponse(1);

        // Assert
        Assert.Equal(1, actual);
    }

    [Fact]
    public void GivenInputIsDivisibleBy3Only_WhenGetResponse_ThenReturnsFizz()
    {
        // Arrange
        var game = new FizzBuzzGame();

        // Act
        object actual = game.GetResponse(3);

        // Assert
        Assert.Equal("Fizz", actual);
    }

    [Fact]
    public void GivenInputIsDivisibleBy5Only_WhenGetResponse_ThenReturnsBuzz()
    {
        // Arrange
        var game = new FizzBuzzGame();

        // Act
        object actual = game.GetResponse(5);

        // Assert
        Assert.Equal("Buzz", actual);
    }

    [Fact]
    public void GivenInputIsDivisibleBy3And5_WhenGetResponse_ThenReturnsFizzBuzz()
    {
        // Arrange
        var game = new FizzBuzzGame();

        // Act
        object actual = game.GetResponse(15);

        // Assert
        Assert.Equal("FizzBuzz", actual);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(101)]
    public void GivenInputIsOutsideRange1To100_WhenGetResponse_ThenThrowsArgumentOutOfRangeException(int input)
    {
        // Arrange
        var game = new FizzBuzzGame();

        // Act
        Assert.Throws<ArgumentOutOfRangeException>(() => game.GetResponse(input));
    }

    /// <summary>
    ///     Parametrisierter Test: Deckt alle einfachem Testfälle in einem einzigen Test ab
    /// </summary>
    [Theory]
    [InlineData(1, 1)]
    [InlineData(3, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(15, "FizzBuzz")]
    public void GivenValidInputCases_WhenGetResponse_ThenReturnsExpectedValue(int input, object expected)
    {
        // Arrange
        var game = new FizzBuzzGame();

        // Act
        object actual = game.GetResponse(input);

        // Assert
        Assert.Equal(expected, actual);
    }
}