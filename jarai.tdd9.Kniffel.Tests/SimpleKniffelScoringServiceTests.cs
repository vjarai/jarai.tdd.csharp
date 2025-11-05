using System.Linq;
using FluentAssertions.Execution;
using jarai.tdd9.Kniffel.ScoringRules;
using Moq;
using Xunit;

namespace jarai.tdd9.Kniffel.Tests;

public class SimpleKniffelScoringServiceTests
{
    [Fact]
    public void GivenWurf25345_WhenCalculateScorings_ThenSmallStraightIsFirstWithScore30()
    {
        // Arrange
        var wurf = new Wurf(2, 5, 3, 4, 5);
        var sut = new KniffelScoringService();

        // Act
        var actual = sut.CalculateScorings(wurf).First();

        // Bad Smell: Mehrere Asserts nacheinander (bricht beim ersten Fehler ab)
        Assert.Equal(ScoreId.SmallStraight, actual.ScoreId);
        Assert.Equal(30, actual.Score);

        // Besser: Assert.Multiple (führt alle Asserts aus)
        Assert.Multiple(
            () => Assert.Equal(ScoreId.SmallStraight, actual.ScoreId),
            () => Assert.Equal(30, actual.Score));

        // oder AssertionScope: https://fluentassertions.com/introduction
        using var scope = new AssertionScope();
        Assert.Equal(ScoreId.SmallStraight, actual.ScoreId);
        Assert.Equal(30, actual.Score);

        // Am Besten: Single Assert by using an actual object and its Equals method
        var expected = new ScoringResult(ScoreId.SmallStraight, 30);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GivenWurf12345_WhenCalculateScorings_ThenLargeAndSmallStraightAreTop2()
    {
        // Arrange
        var wurf = new Wurf(1, 2, 3, 4, 5);
        var sut = new KniffelScoringService();

        // Act
        var actual = sut.CalculateScorings(wurf).Take(2);

        // Assert
        Assert.Collection(actual,
            item => { Assert.Equal(ScoreId.LargeStraight, item.ScoreId); },
            item => { Assert.Equal(ScoreId.SmallStraight, item.ScoreId); }
        );
    }

    [Fact]
    public void GivenKniffelScoringServiceWithMockedRule_WhenCalculateScorings_ThenRuleCalculateScoreIsCalled()
    {
        // https://github.com/devlooped/moq/wiki/Quickstart

        // Arrange
        var wurf = new Wurf(1, 2, 3, 4, 5);

        var mockedRule = new Mock<ScoringRule>();
        mockedRule.Setup(r => r.CalculateScore(wurf)).Returns(15);

        var sut = new KniffelScoringService(new[] { mockedRule.Object });

        // Act
        var actual = sut.CalculateScorings(wurf).First();

        // Assert
        mockedRule.Verify(r => r.CalculateScore(wurf), Times.Once);
    }
}