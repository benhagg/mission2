

class Dice
{
    private int value;
    public int Roll()
    {
        Random random = new Random();
        value = random.Next(1, 7);
        return value;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        try
        {
            int rolls = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number.");
        }
        // instantiate 2 new dice (could just use one and roll twice tho)
        Dice dice1 = new Dice();
        Dice dice2 = new Dice();
        // array of length 11 for all dice combinations
        int[] results = new int[11];
        // fill all slots with starting value 0
        for (int i = 0; i < results.Length; i++)
        {
            results[i] = 0;
        }
        for (int i = 0; i < rolls; i++)
        {
            int value = dice1.Roll() + dice2.Roll()
            results[value - 2]++;
        }
    }
}