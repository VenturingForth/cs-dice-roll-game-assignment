var random = new Random();
var dice = new Dice(random);
Console.WriteLine(dice.Roll());

Console.ReadKey();

public class Dice()
{
    private readonly Random _random;
    private const int SidesCount = 6;

    public Dice(Random random) : this()
    {
        this._random = random;
    }

    public int Roll()
    {
        return _random.Next(1, SidesCount + 1);
    }
}