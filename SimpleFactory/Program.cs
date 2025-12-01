// See https://aka.ms/new-console-template for more information
using SimpleFactory;

Console.WriteLine("*** Simple Factory Pattern Demo.***\n");

IAnimal preferredType = null;
var simpleFactory = new SimpleFactory.SimpleFactory();
preferredType = simpleFactory.CreateAnimal();
preferredType.AboutMe();
Console.ReadKey();