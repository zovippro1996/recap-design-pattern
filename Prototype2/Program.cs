// See https://aka.ms/new-console-template for more information
using Prototype2;

Console.WriteLine("Hello, World!");
System.Console.WriteLine("***Prototype Pattern Demo2.***\n");
CarFactory carFactory = new CarFactory();

// Get a Nano
BasicCar basicCar = carFactory.GetNano();
// Working on cloned copy
basicCar.onRoadPrice = basicCar.basePrice + BasicCar.SetAdditionalPrice();
System.Console.WriteLine($"Car is: {basicCar.ModelName}, and it's price is Rs. {basicCar.onRoadPrice}");

// Get a Ford
basicCar = carFactory.GetFord();
// Working on cloned copy
basicCar.onRoadPrice = basicCar.basePrice + BasicCar.SetAdditionalPrice();
System.Console.WriteLine($"Car is: {basicCar.ModelName}, and it's price is Rs. {basicCar.onRoadPrice}");

Console.ReadLine();