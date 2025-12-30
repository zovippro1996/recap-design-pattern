namespace Factory;

public abstract class AnimalFactory
{
    public IAnimal MakeAnimal()
    {
        Console.WriteLine("AnimalFactory.MakeAnimal()-You cannot ignore parent rules.");
        IAnimal animal = CreateAnimal();
        animal.AboutMe();
        return animal;
    }

    public abstract IAnimal CreateAnimal();
}
