using Xunit;

namespace jarai.tdd2.OutsideInTDD.Tests.UnitTests;

public class KontoTests
{
    [Fact]
    public void GivenKonto_WhenEinzahlenIsCalled_ThenBalanceIsIncreased()
    {
        // Arrange
        var target = new Konto(new FakeKalenderService());

        // Act
        target.Einzahlen(100);
    }

    [Fact]
    public void GivenKonto_WhenAbhebenIsCalled_ThenBalanceIsDecreased()
    {
        // Arrange
        var target = new Konto(new FakeKalenderService());

        // Act
        target.Abheben(50);
    }
}