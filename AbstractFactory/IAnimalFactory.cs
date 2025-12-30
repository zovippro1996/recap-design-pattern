namespace AbstractFactory;

public interface IAnimalFactory
{
    IDog GetDog();
    ITiger GetTiger();
}
