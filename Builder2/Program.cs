// See https://aka.ms/new-console-template for more information
using Builder2;

internal class Program
{
    static Product customCar;
    private static void Main(string[] args)
    {
        Console.WriteLine("***Builder Pattern alternative implementation.***");

        customCar = new Car("Suzuki Swift")
            .StartUpOperations()
            .AddHeadlights(6)
            .InsertWheels()
            .BuildBody("Plastic")
            .EndOperations("Suzuki construction Completed.")
            .ConstructCar();

        customCar.Show();
    }
}