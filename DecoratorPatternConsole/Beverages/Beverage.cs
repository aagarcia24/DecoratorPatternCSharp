namespace DecoratorPatternConsole
{
    public abstract class Beverage
    {
        public virtual string Description { get; set; } = "Unknown Beverage";

        public abstract double Cost();

        public override string ToString()
        {
            return $"{Description} ${Cost()}";
        }
    }
}
