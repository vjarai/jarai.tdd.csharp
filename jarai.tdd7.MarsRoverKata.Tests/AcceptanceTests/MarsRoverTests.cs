using Xunit;

namespace jarai.tdd7.MarsRoverKata.Tests.AcceptanceTests;

public class MarsRoverTests
{
    [Fact]
    public void GivenMarsRover_WhenExecuteCommandsM_ThenPositionIs_0_1_N()
    {
        // Arrange
        var target = new MarsRover();

        // Act
        string actual = target.ExecuteCommands("M");

        // Assert
        Assert.Equal("0:1:N", actual);
    }

    [Fact]
    public void GivenMarsRover_WhenExecuteCommandsMMMMMMMMMM_ThenPositionIs_0_0_N()
    {
        // Arrange
        var target = new MarsRover();

        // Act
        string actual = target.ExecuteCommands("MMMMMMMMMM");

        // Assert
        Assert.Equal("0:0:N", actual);
    }

    [Fact]
    public void GivenMarsRover_WhenExecuteCommandsMMRMMLM_ThenPositionIs_2_3_N()
    {
        // Arrange
        var target = new MarsRover();

        // Act
        string actual = target.ExecuteCommands("MMRMMLM");

        // Assert
        Assert.Equal("2:3:N", actual);
    }

    [Fact]
    public void GivenMarsRoverWithObstacleAt_0_3_WhenExecuteCommandsMMMM_ThenPositionIs_O_0_2_N()
    {
        // Arrange
        var grid = new Grid();
        grid.AddObstacle(new Position(0, 3));

        var target = new MarsRover(grid, new Position(0, 0), NorthDirection.Instance);

        // Act
        string actual = target.ExecuteCommands("MMMM");

        // Assert
        Assert.Equal("O:0:2:N", actual);
    }
}