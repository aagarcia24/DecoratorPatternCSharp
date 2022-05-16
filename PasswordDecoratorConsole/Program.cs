using System;

namespace PasswordDecoratorConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPassword obj = new SpecialCharacterPasswordDecorator(new NumberPasswordDecorator(new LetterPassword(), 4), 2);

            for (int i = 0; i < 10; i++)
            {
                string password = obj.GeneratePassword(6);
                Console.WriteLine($"The password is: {password} and its length is: {password.Length}");
            }
        }
    }
}
