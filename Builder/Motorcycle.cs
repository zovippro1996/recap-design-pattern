using System;

namespace Builder;

class Motorcycle : IBuilder
{
    private string brandName;
    private Product product;
    
    public Motorcycle(string brandName)
    {
        product = new Product();
        this.brandName = brandName;
    }

    public void AddHeadlights()
    {
        product.Add("1 Headlights are added");
    }

    public void BuildBody()
    {
        product.Add("This is a body of a Motorcycle");
    }

    public void EndOperations()
    {
        product.Add($"Motorcycle model: {this.brandName}");
        product.Add("______");
    }

    public void InsertWheels()
    {
        product.Add("2 wheels are added");
    }

    public void StartUpOperations()
    {
        product.Add("______");
    }

    public Product GetVehicle()
    {
        return product;
    }
}
