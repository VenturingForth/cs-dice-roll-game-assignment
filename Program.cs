var random = new Random();
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);

GameResult gameResult = guessingGame.Play();
guessingGame.PrintResult(gameResult);

Console.ReadKey();

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
        while(triesLeft > 0)
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

public enum GameResult
{
    Victory,
    Loss
}

public static class ConsoleInterface
{
    public static int ReadInteger(string message)
    {
        int result;
        do
        {
            Console.WriteLine(message);
        }
        while (!int.TryParse(Console.ReadLine(), out result));
        return result;
    }
}

public class Dice()
{
    private readonly Random _random;
    private const int SidesCount = 6;

    public Dice(Random random) : this()
    {
        this._random = random;
    }

    public int Roll() => _random.Next(1, SidesCount + 1);
}