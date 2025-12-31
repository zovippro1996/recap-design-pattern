namespace Proxy;

public class ConcreteSubject : Subject
{
    public override void DoSomeWork()
    {
        Console.WriteLine("I've processed your request.");
    }
}
