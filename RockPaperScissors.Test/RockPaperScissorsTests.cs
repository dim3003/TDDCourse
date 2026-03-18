using NUnit.Framework;

namespace RockPaperScissors.Tests;

[TestFixture]
public class Play
{
    [TestFixture]
    public class PaperBeatsRock 
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

    [TestFixture]
    public class ScissorsBeatsPaper
    {
        [Test]
        public void GivenPlayerScissors_OpponentPaper_ShouldReturnPlayerWins()
        {
            // Arrange
            var sut = new RockPaperScissors();
            // Act
            var actual = sut.Play(PlayerMoves.Scissors, PlayerMoves.Paper);
            // Assert
            Assert.That(actual, Is.EqualTo(Outcomes.PlayerWins));
        }

        [Test]
        public void GivenPlayerPaper_OpponentScissors_ShouldReturnPlayerLoses()
        {
            // Arrange
            var sut = new RockPaperScissors();
            // Act
            var actual = sut.Play(PlayerMoves.Paper, PlayerMoves.Scissors);
            // Assert
            Assert.That(actual, Is.EqualTo(Outcomes.PlayerLoses));
        }
    }

    [TestFixture]
    public class RockBeatsScissors
    {
        [Test]
        public void GivenPlayerRock_OpponentScissors_ShouldReturnPlayerWins()
        {
            // Arrange
            var sut = new RockPaperScissors();
            // Act
            var actual = sut.Play(PlayerMoves.Rock, PlayerMoves.Scissors);
            // Assert
            Assert.That(actual, Is.EqualTo(Outcomes.PlayerWins));
        }

        [Test]
        public void GivenPlayerScissors_OpponentRock_ShouldReturnPlayerLoses()
        {
            // Arrange
            var sut = new RockPaperScissors();
            // Act
            var actual = sut.Play(PlayerMoves.Scissors, PlayerMoves.Rock);
            // Assert
            Assert.That(actual, Is.EqualTo(Outcomes.PlayerLoses));
        }
    }

    [TestFixture]
    public class Tie
    {
        [Test]
        public void GivenPlayerPaper_OpponentPaper_ShouldReturnTie()
        {
            // Arrange
            var sut = new RockPaperScissors();
            // Act
            var actual = sut.Play(PlayerMoves.Paper, PlayerMoves.Paper);
            // Assert
            Assert.That(actual, Is.EqualTo(Outcomes.Tie));
        }

        [Test]
        public void GivenPlayerScissors_OpponentScissors_ShouldReturnTie()
        {
            // Arrange
            var sut = new RockPaperScissors();
            // Act
            var actual = sut.Play(PlayerMoves.Scissors, PlayerMoves.Scissors);
            // Assert
            Assert.That(actual, Is.EqualTo(Outcomes.Tie));
        }

        [Test]
        public void GivenPlayerRock_OpponentRock_ShouldReturnTie()
        {
            // Arrange
            var sut = new RockPaperScissors();
            // Act
            var actual = sut.Play(PlayerMoves.Rock, PlayerMoves.Rock);
            // Assert
            Assert.That(actual, Is.EqualTo(Outcomes.Tie));
        }
    }
}
