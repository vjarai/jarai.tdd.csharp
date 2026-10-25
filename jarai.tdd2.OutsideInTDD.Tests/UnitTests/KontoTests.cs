using Xunit;

namespace jarai.tdd2.OutsideInTDD.Tests.UnitTests;

public class KontoTests
{
    [Fact]
    public void GivenNewKonto_WhenEinzahlenIsCalled_ThenBalanceIsIncreased()
    {
        // Arrange
        var target = new Konto(new FakeKalenderService());

        // Act
        target.Einzahlen(100);

        // Assert
        Assert.Equal(100, target.Kontostand);
    }

    [Fact]
    public void GivenNewKonto_WhenAbhebenIsCalled_ThenBalanceIsDecreased()
    {
        // Arrange
        var target = new Konto(new FakeKalenderService());

        // Act
        target.Abheben(50);

        // Assert
        Assert.Equal(-50, target.Kontostand);
    }
}