public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(EvenOrOdd(int.TryParse(args[0], out int number) ? number : 0));
    }
    public static string EvenOrOdd(int number)
    {
        return number % 2 == 0 ? "Even" : "Odd";
    }

}