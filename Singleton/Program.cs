// See https://aka.ms/new-console-template for more information
using SingletonDemo;

Console.WriteLine("***Singleton Pattern Demo.***\n");

Singleton firstInstance = Singleton.GetInstance;
Singleton secondInstance = Singleton.GetInstance;
if (firstInstance.Equals(secondInstance))
{
    System.Console.WriteLine("Same");
}
else
{
    System.Console.WriteLine("Difference");
}
System.Console.WriteLine($"The value of MyInt is :{Singleton.MyInt}");
Console.Read();