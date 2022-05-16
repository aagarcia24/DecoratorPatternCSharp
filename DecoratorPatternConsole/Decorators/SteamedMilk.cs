namespace DecoratorPatternConsole
{
    public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage)
        {
            WrappedBeverage = beverage;
            Description = $"{WrappedBeverage.Description}, Steamed Milk";
        }
        public override double Cost()
        {
            return WrappedBeverage.Cost() + .10;
        }
    }
}
