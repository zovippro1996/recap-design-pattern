// See https://aka.ms/new-console-template for more information

using Singleton2;

Console.WriteLine("***Singleton Pattern Demo.***\n");

Singleton firstInstance = Singleton.GetInstance;
Singleton secondInstance = Singleton.GetInstance;
if (firstInstance.Equals(secondInstance))
{
    Console.WriteLine("Same");
}
else
{
    Console.WriteLine("Difference");
}


Console.Read();