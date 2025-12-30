using AbstractFactory;

Console.WriteLine("***Abstract Factory Pattern Demo.***\n");

IAnimalFactory animalFactory = FactoryProvider.GetAnimalFactory("Wild");
IDog dog = animalFactory.GetDog();
ITiger tiger = animalFactory.GetTiger();
dog.AboutMe();
tiger.AboutMe();

Console.WriteLine("******************");

animalFactory = FactoryProvider.GetAnimalFactory("Pet");

dog = animalFactory.GetDog();
tiger = animalFactory.GetTiger();
dog.AboutMe();
tiger.AboutMe();

Console.ReadLine();