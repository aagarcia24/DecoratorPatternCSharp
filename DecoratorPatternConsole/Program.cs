using System;

namespace DecoratorPatternConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Beverage beverage = new Expresso();
            Console.WriteLine(beverage);

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2);

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3);
        }
    }
}
