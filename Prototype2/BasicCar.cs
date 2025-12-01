namespace Prototype2;

public abstract class BasicCar
{
    public int basePrice = 0;
    public int onRoadPrice = 0;

    public string ModelName { get; set; }

    public static int SetAdditionalPrice()
    {
        Random random = new Random();
        int additionalPrice = random.Next(200000, 500000);
        return additionalPrice;
    }

    public abstract BasicCar Clone();
}
