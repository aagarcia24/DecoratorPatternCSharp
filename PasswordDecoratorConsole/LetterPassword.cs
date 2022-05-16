using System;
using System.Text;

namespace PasswordDecoratorConsole
{
    public class LetterPassword : IPassword
    {
        public string GeneratePassword(int length)
        {
            StringBuilder password = new StringBuilder(length);
            Random random = new Random();
            bool flag = true;

            for (int i = 0; i < length; i++)
            {
                if (flag)
                    password.Append(Convert.ToChar(random.Next(65, 91)));
                else
                    password.Append(Convert.ToChar(random.Next(97, 123)));
                flag = !flag;
            }

            return password.ToString();
        }
    }
}
