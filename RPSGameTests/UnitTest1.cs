using Xunit;
using RockPaperScissors; // Ensure this matches the namespace of your main project

namespace RPSGameTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestPlayerWins()
        {
            // Arrange
            var game = new RPSGame();

            // Act
            game.DetermineWinner("rock", "scissors");

            // Assert
            Assert.Equal(1, game.PlayerScore);
            Assert.Equal(0, game.AIScore);
        }

        [Fact]
        public void TestComputerWins()
        {
            // Arrange
            var game = new RPSGame();

            // Act
            game.DetermineWinner("rock", "paper");

            // Assert
            Assert.Equal(0, game.PlayerScore);
            Assert.Equal(1, game.AIScore);
        }

        [Fact]
        public void TestDraw()
        {
            // Arrange
            var game = new RPSGame();

            // Act
            game.DetermineWinner("rock", "rock");

            // Assert
            Assert.Equal(0, game.PlayerScore);
            Assert.Equal(0, game.AIScore);
        }

        [Fact]
        public void TestScoresAreUpdatedCorrectly()
        {
            // Arrange
            var game = new RPSGame();

            // Act
            game.DetermineWinner("rock", "scissors"); // Player wins
            game.DetermineWinner("rock", "paper");    // AI wins
            game.DetermineWinner("paper", "rock");    // Player wins

            // Assert
            Assert.Equal(2, game.PlayerScore);
            Assert.Equal(1, game.AIScore);
        }
    }
}
