using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.Classes
{
    public class PasswordGenerator
    {
        private readonly string _digits;
        private readonly string _lowercaseLetters;
        private readonly string _uppercaseLetters;
        private readonly string _specialChars;
        private static Random random = new Random();

        public PasswordGenerator(string digits, string lowercaseLetters, 
                            string uppercaseLetters, string specialChars)
        {
            _digits = digits;
            _lowercaseLetters = lowercaseLetters;
            _uppercaseLetters = uppercaseLetters;
            _specialChars = specialChars;
        }

        public string Generate(int length, bool useDigits, bool useLowercaseLetters, 
                            bool useUppercaseLetters, bool useSpecialChars)
        {
            //Формируем пул символов
            string charPull = "";
            if (useDigits)
                charPull += _digits;
            if (useLowercaseLetters)
                charPull += _lowercaseLetters;
            if (useUppercaseLetters)
                charPull += _uppercaseLetters;
            if (useSpecialChars)
                charPull += _specialChars;

            if (string.IsNullOrEmpty(charPull))
                return "";

            StringBuilder password = new StringBuilder();
            while (password.Length != length)
                password.Append(charPull[random.Next(0, charPull.Length)]);

            return password.ToString();
        }
    }
}
