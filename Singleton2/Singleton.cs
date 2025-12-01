namespace Singleton2;

public sealed class Singleton
{
    private static readonly Singleton Instance = new Singleton();
    private static int TotalInstances;

    private Singleton()
    {
        Console.WriteLine("Private const is called.");
        Console.WriteLine("--Exit now from private const.");
    }

    public static Singleton GetInstance
    {
        get
        {
            return Instance;
        }
    }
}
