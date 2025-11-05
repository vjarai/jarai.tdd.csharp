using Xunit;

namespace jarai.tdd3.TestDoubles.Tests;

public class MotorTests
{
    [Fact]
    public void GivenMotor_WhenAnlassenIsCalled_ThenDrehzahlIsGreaterThanZero()
    {
        // Arrange
        var target = new Motor();

        // Act
        target.Anlassen();

        // Assert
        Assert.True(target.Drehzahl > 0);
    }

    [Fact]
    public void GivenMotor_WhenAbstellenIsCalled_ThenDrehzahlIsZero()
    {
        // Arrange
        var target = new Motor();

        // Act
        target.Abstellen();

        // Assert
        Assert.True(target.Drehzahl == 0);
    }
}