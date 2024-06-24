namespace RockPaperScissors
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Score = 0;
        }

        public string ChooseMove()
        {
            Console.WriteLine($"{Name}, enter your move (rock, paper, or scissors):");
            string move = Console.ReadLine();
            if (string.IsNullOrEmpty(move))
            {
                throw new ArgumentException("Move cannot be null or empty");
            }
            return move;
        }
    }
}
