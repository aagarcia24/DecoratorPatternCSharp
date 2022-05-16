namespace DecoratorPatternConsole
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            WrappedBeverage = beverage;
            Description = $"{WrappedBeverage.Description}, Mocha";
        }
        public override double Cost()
        {
            return WrappedBeverage.Cost() + .20;
        }
    }
}
