using DiceRollGame.UserCommunication;

namespace DiceRollGame.Game
{
    public class GuessingGame
    {
        private readonly Dice _dice;
        private const int NumberOfTries = 3;

        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }

        public GameResult Play()
        {
            int diceRollResult = _dice.Roll();
            Console.WriteLine($"Dice rolled. Guess what number it shows in {NumberOfTries} tries.");

            int triesLeft = NumberOfTries;
            while (triesLeft > 0)
            {
                int guess = ConsoleInterface.ReadInteger("Enter a number:");
                if (guess == diceRollResult)
                {
                    return GameResult.Victory;
                }
                Console.WriteLine("Wrong number.");
                --triesLeft;
            }
            return GameResult.Loss;
        }

        public static void PrintResult(GameResult gameResult)
        {
            string message = gameResult == GameResult.Victory
                ? "You win"
                : "You lose :(";
            Console.WriteLine(message);
        }
    }
}