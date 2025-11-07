using Jarai.Patterns.Behavioral.ChainOfResponsibilty;
using Xunit;

namespace jarai.tdd4c.Alexa.Tests
{
    public class LampenSkillTests
    {
        [Fact()]
        public void HandleRequestTest()
        {
            // Arrange
            var sut = new LampenSkill();

            // Act
            string response = sut.HandleRequest("Schalte Licht ein");

            // Assert
            Assert.Equal("Licht ist ein", response);
        }
    }
}