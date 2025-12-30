namespace AbstractFactory;

public class PetDog : IDog
{
    public void AboutMe()
    {
        Console.WriteLine("Pet dog says: Bow-Wow. I prefer to stay at home.");
    }
}
