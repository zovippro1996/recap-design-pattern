namespace Factory
{
    public class TigerFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Tiger();
        }
    }
}
