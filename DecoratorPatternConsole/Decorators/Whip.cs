namespace DecoratorPatternConsole
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            WrappedBeverage = beverage;
            Description = $"{WrappedBeverage.Description}, Whip";
        }
        public override double Cost()
        {
            return WrappedBeverage.Cost() + .10;
        }
    }
}
