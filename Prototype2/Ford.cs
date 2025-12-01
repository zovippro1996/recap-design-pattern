using System;

namespace Prototype2;

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
