using System;
using System.Text;

namespace PasswordDecoratorConsole
{
    public class NumberPasswordDecorator : IPassword
    {
        public IPassword PasswordObject { get; set; }
        public int NumbersQuantity { get; set; }

        public NumberPasswordDecorator() : this(null) { }

        public NumberPasswordDecorator(IPassword password, int numbersQuantity = 1)
        {
            PasswordObject = password;
            NumbersQuantity = numbersQuantity;
        }
        public string GeneratePassword(int length)
        {
            StringBuilder password = PasswordObject != null ? new StringBuilder(PasswordObject.GeneratePassword(length)) : new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < NumbersQuantity; i++)
            {
                int index = random.Next(0, password.Length + 1);
                int number = random.Next(0, 10);
                password = password.Insert(index, number);
            }

            return password.ToString();
        }
    }
}
