using Proxy;

Console.WriteLine("***Proxy Pattern Demo.***\n");
// Use the fully qualified name to avoid ambiguity with the namespace
Subject proxy = new Proxy.Proxy();
proxy.DoSomeWork();
Console.ReadKey();