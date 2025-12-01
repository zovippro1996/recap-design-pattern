using System;

namespace Builder2;

class Car : IBuilder
{
    private string brandName;
    private Product product;

    public Car(string brand)
    {
        product = new Product();
        this.brandName = brand;
    }

    public IBuilder AddHeadlights(int optionalNoOfHeadLights = 2)
    {
       product.Add($"Headlights: {optionalNoOfHeadLights}");
       return this;
    }

    public IBuilder BuildBody(string optionalBodyType = "Steel")
    {
        product.Add($"Body type: {optionalBodyType}");
        return this;
    }

    public Product ConstructCar()
    {
        return product;
    }

    public IBuilder EndOperations(string optionalEndMessage = "Car construction is completed.")
    {
        product.Add(optionalEndMessage);
        return this;
    }

    public IBuilder InsertWheels(int optionalNoOfWheels = 4)
    {
        product.Add($"Wheels:{optionalNoOfWheels}");
        return this;
    }

    public IBuilder StartUpOperations(string optionalStartUpMessage = " Making a car for you.")
    {
        product.Add(optionalStartUpMessage);
        product.Add($"Car model name: {this.brandName}");
        return this;
    }
}
