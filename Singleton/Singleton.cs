namespace SingletonDemo;

public sealed class Singleton
{
    private static readonly Singleton Instance;
    private static int TotalInstances;
    public static int MyInt = 25;

    private Singleton()
    {
        Console.WriteLine("--Private constructor is called.");
        Console.WriteLine("--Exit now from private constructor.");
    }

    static Singleton()
    {
        Console.WriteLine("-Static constructor is called");
        Instance = new Singleton();
        TotalInstances++;
        Console.WriteLine("-Exit from static constructor");
    }

    public static Singleton GetInstance => Instance;
}
