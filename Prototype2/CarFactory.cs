using System;

namespace Prototype2;

class CarFactory
{
    private readonly BasicCar nano;
    private readonly BasicCar ford;
    public CarFactory()
    {
        nano = new Nano("Green Nano");
        ford = new Ford("Ford Yellow");
    }
    public BasicCar GetNano()
    {
        return nano.Clone();
    }
    public BasicCar GetFord()
    {
        return ford.Clone();
    }
}
