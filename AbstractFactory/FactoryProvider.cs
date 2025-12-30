namespace AbstractFactory;

public class FactoryProvider
{
    public static IAnimalFactory GetAnimalFactory(string factoryType)
    {
        if (factoryType.Equals("Pet", StringComparison.OrdinalIgnoreCase))
        {
            return new PetAnimalFactory();
        }
        else if (factoryType.Equals("Wild", StringComparison.OrdinalIgnoreCase))
        {
            return new WildAnimalFactory();
        }
        throw new ArgumentException("Invalid factory type");
    }
}
