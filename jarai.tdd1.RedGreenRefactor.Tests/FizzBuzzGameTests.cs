using Xunit;

namespace jarai.tdd1.RedGreenRefactor.Tests;

public class FizzBuzzGameTests
{
    [Fact]
    public void GivenFizzBuzzGame_whenInputIs1_ThenGetResponseReturnsNumber1()
    {
        // Arrange
        var sut = new FizzBuzzGame();

        // Act
        object actual = sut.GetResponse(1);

        // Assert
        Assert.Equal(1, actual);
    }

    [Fact]
    public void GivenFizzBuzzGame_whenInputIs3_ThenGetResponseReturnsFizz()
    {
        // Arrange
        var sut = new FizzBuzzGame();

        // Act
        object actual = sut.GetResponse(3);

        // Assert
        Assert.Equal("Fizz", actual);
    }

    [Fact]
    public void GivenFizzBuzzGame_whenInputIs5_ThenGetResponseReturnsBuzz()
    {
        // Arrange
        var sut = new FizzBuzzGame();

        // Act
        object actual = sut.GetResponse(5);

        // Assert
        Assert.Equal("Buzz", actual);
    }

    [Fact]
    public void GivenFizzBuzzGame_whenInputIs15_ThenGetResponseReturnsFizzBuzz()
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
    public void GivenFizzBuzzGame_whenInputIsOutsideRange1To100_ThenGetResponseThrowsArgumentOutOfRangeException(int input)
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
    public void GivenFizzBuzzGame_whenInputIsValid_ThenGetResponseReturnsExpectedValue(int input, object expected)
    {
        // Arrange
        var sut = new FizzBuzzGame();

        // Act
        object actual = sut.GetResponse(input);

        // Assert
        Assert.Equal(expected, actual);
    }
}