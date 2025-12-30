using Factory;

Console.WriteLine("***Factory Pattern Demo.***\n");

// Creating a Tiger Factory
AnimalFactory tigerFactory = new TigerFactory();

// Creating a tiger using the Factory Method
//IAnimal tiger = tigerFactory.CreateAnimal();
//tiger.AboutMe();
IAnimal tiger = tigerFactory.MakeAnimal();

// Creating a DogFactory
AnimalFactory dogFactory = new DogFactory();
// Creating a dog using the Factory Method
//IAnimal dog = dogFactory.CreateAnimal();
//dog.AboutMe();
IAnimal dog = dogFactory.MakeAnimal();

Console.ReadKey();
