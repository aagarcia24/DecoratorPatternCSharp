namespace DecoratorPatternConsole
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage WrappedBeverage { get; set; }
    }
}
