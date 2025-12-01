namespace SingletonDemo;

public sealed class Singleton
{
    private static readonly Singleton Instance;
    private static int TotalInstances;
    public static int MyInt = 25;

    /// <summary>
    /// Private constructor is used to prevent
    /// creation of instances with the 'new' keyword
    /// outside of this class.
    /// </summary>
    private Singleton()
    {
        Console.WriteLine("--Private constructor is called.");
        Console.WriteLine("--Exit now from private constructor.");
    }

    /// <summary>
    /// A static constructor is used for the following purposes:
    /// 1. To initialize any static data.
    /// 2. To perform a specific action only once.
    /// 
    /// The static constructor will be called automatically before:
    /// i. You create the first instance; or
    /// ii. You refer to any static members in your code.
    /// </summary>
    static Singleton()
    {
        Console.WriteLine("-Static constructor is called");
        Instance = new Singleton();
        TotalInstances++;
        Console.WriteLine("-Exit from static constructor");
    }

    public static Singleton GetInstance => Instance;
}
