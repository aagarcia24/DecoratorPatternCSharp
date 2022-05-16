namespace DecoratorPatternConsole
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast Coffe";
        }
        public override double Cost()
        {
            return .99;
        }
    }
}
