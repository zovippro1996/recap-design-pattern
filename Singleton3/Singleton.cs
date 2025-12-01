namespace Singleton3;

public sealed class Singleton
{
    // Custom delegate.
    delegate Singleton SingletonDelegateWithNoParameter();

    static SingletonDelegateWithNoParameter myDel = MakeSingletonInstance;

    static Func<Singleton> myFuncDelegate = MakeSingletonInstance;

    private static readonly Lazy<Singleton> Instance = new Lazy<Singleton>(myFuncDelegate());

    private static Singleton MakeSingletonInstance()
    {
        return new Singleton();
    }

    private Singleton() { }

    public static Singleton GetInstance
    {
        get
        {
            return Instance.Value;
        }
    }
}
