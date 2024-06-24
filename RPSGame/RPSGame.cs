using System;

namespace RockPaperScissors
{
    public class RPSGame
    {
        public int PlayerScore { get; private set; }
        public int AIScore { get; private set; }

        public RPSGame()
        {
            PlayerScore = 0;
            AIScore = 0;
        }

        public void StartGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("First to 3 points wins.");

            while (PlayerScore < 3 && AIScore < 3)
            {
                Console.WriteLine("Enter your move (rock, paper, or scissors):");
                string playerMove = Console.ReadLine();
                if (!IsValidMove(playerMove))
                {
                    Console.WriteLine("Invalid move. Please try again.");
                    continue;
                }

                string aiMove = GetRandomMove();
                Console.WriteLine($"AI chose: {aiMove}");

                string result = DetermineWinner(playerMove, aiMove);
                Console.WriteLine(result);
                Console.WriteLine($"Score - Player: {PlayerScore}, AI: {AIScore}");
            }

            if (PlayerScore == 3)
            {
                Console.WriteLine("Congratulations! You won the game.");
            }
            else
            {
                Console.WriteLine("AI wins the game. Better luck next time!");
            }
        }

        private bool IsValidMove(string move)
        {
            return move == "rock" || move == "paper" || move == "scissors";
        }

        private string GetRandomMove()
        {
            string[] moves = { "rock", "paper", "scissors" };
            Random rand = new Random();
            int index = rand.Next(moves.Length);
            return moves[index];
        }

        public string DetermineWinner(string playerMove, string aiMove)
        {
            playerMove = playerMove.ToLower();
            aiMove = aiMove.ToLower();

            if (playerMove == aiMove)
            {
                return "It's a tie!";
            }
            else if ((playerMove == "rock" && aiMove == "scissors") ||
                     (playerMove == "paper" && aiMove == "rock") ||
                     (playerMove == "scissors" && aiMove == "paper"))
            {
                PlayerScore++;
                return "You win this round!";
            }
            else
            {
                AIScore++;
                return "AI wins this round!";
            }
        }
    }
}
