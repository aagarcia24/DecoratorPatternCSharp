namespace DecoratorPatternConsole
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            WrappedBeverage = beverage;
            Description = $"{WrappedBeverage.Description}, Soy";
        }
        public override double Cost()
        {
            return WrappedBeverage.Cost() + .15;
        }
    }
}
