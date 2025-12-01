using System;

namespace SimpleFactory;

public class Dog : IAnimal
{
    public void AboutMe()
    {
        System.Console.WriteLine("The dogs says: Bow-Wow. I prefer barking.");
    }
}
