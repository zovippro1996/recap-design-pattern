using Proxy2;

Console.WriteLine("***Proxy Pattern Demo2.***\n");
Subject proxy = new Proxy("Admin");
proxy.DoSomeWork();

proxy = new Proxy("Sam");
proxy.DoSomeWork();

proxy = new Proxy("Robin");
proxy.DoSomeWork();
Console.ReadKey();
