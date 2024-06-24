namespace DiceRollGame.UserCommunication
{
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
}