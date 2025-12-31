namespace Proxy;

public class Proxy : Subject
{
    Subject subject;
    public override void DoSomeWork()
    {
        Console.WriteLine("Welcome, my client.");
        /*
        Lazy initialization:We'll not instantiate the object until the
        method is called.
        */
        subject ??= new ConcreteSubject();
        subject.DoSomeWork();
    }
}
