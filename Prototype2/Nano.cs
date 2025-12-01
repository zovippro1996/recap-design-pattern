namespace Prototype2;

public class Nano : BasicCar
{
    public Nano(string m)
    {
        ModelName = m;
        basePrice = 100000;
    }

    public override BasicCar Clone()
    {
        return MemberwiseClone() as Nano;
    }
}
