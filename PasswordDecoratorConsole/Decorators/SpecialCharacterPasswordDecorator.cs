using System;
using System.Text;

namespace PasswordDecoratorConsole
{
    public class SpecialCharacterPasswordDecorator : IPassword
    {
        public IPassword PasswordObject { get; set; }
        public int SpecialCharactersQuantity { get; set; }
        public SpecialCharacterPasswordDecorator() : this(null) { }
        public SpecialCharacterPasswordDecorator(IPassword password, int specialCharactersQuantity = 1)
        {
            PasswordObject = password;
            SpecialCharactersQuantity = specialCharactersQuantity;
        }
        public string GeneratePassword(int length)
        {
            StringBuilder password = PasswordObject != null ? new StringBuilder(PasswordObject.GeneratePassword(length)) : new StringBuilder();
            char[] specialCharacters = { '!', '#', '$', '%', '&', '+', '*', '-', '/' };
            Random random = new Random();

            for (int i = 0; i < SpecialCharactersQuantity; i++)
            {
                int index = random.Next(0, password.Length + 1);
                char specialCharacter = specialCharacters[random.Next(0, specialCharacters.Length)];
                password = password.Insert(index, specialCharacter);
            }

            return password.ToString();
        }
    }
}
