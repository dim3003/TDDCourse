using NUnit.Framework;

namespace RockPaperScissors.Tests;

[TestFixture]
public class Play
{
    [TestFixture]
    public class RockBeatsPaper
    {
        [Test]
        public void GivenPlayerRock_OpponentPaper_ShouldReturnPlayerLoses()
        {
            // Arrange
            var sut = new RockPaperScissors();
            // Act
            var actual = sut.Play(PlayerMoves.Rock, PlayerMoves.Paper);
            // Assert
            Assert.That(actual, Is.EqualTo(Outcomes.PlayerLoses));
        }

        [Test]
        public void GivenPlayerPaper_OpponentRock_ShouldReturnPlayerWin()
        {
            // Arrange
            var sut = new RockPaperScissors();
            // Act
            var actual = sut.Play(PlayerMoves.Paper, PlayerMoves.Rock);
            // Assert
            Assert.That(actual, Is.EqualTo(Outcomes.PlayerWins));
        }
    }
}
