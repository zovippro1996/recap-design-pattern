using System;

namespace Prototype;

public class Ford : BasicCar
{
    public Ford(string m)
    {
        ModelName = m;
        basePrice = 500000;
    }

    public override BasicCar Clone()
    {
        return MemberwiseClone() as Ford;
    }
}
