using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace gestione_account_password
{
    public class PasswordManager
    {
        private static readonly char[] _lowercaseLetters =
        [
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        ];

        private static readonly char[] _uppercaseLetters =
        [
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        ];

        private static readonly char[] _numbers =
        [
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
        ];

        private static readonly char[] _specialChars =
        [
            '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '+', '=', '{', '}', '[', ']', '|', '\\', ':', ';', '"', '\'', '<', '>', ',', '.', '?', '/'
        ];
        
        private string _password;

        public char[] LowercaseLetters
        {
            get => _lowercaseLetters;
        }

        public char[] UppercaseLetters
        {
            get => _uppercaseLetters;
        }

        public char[] Numbers
        {
            get => _numbers;
        }

        public char[] SpecialChars
        {
            get => _specialChars;
        }

        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public PasswordManager(int length, bool caps, bool numbers, bool specialChars)
        {
            Password = PasswordGenerator(length, caps, numbers, specialChars);
        }

        public PasswordManager(string password)
        {
            Password = password;
            EncryptPassword();
        }

        public string PasswordGenerator(int length, bool caps, bool numbers, bool specialChars)
        {
            if (length < 8 || length > 30)
            {
                throw new ArgumentOutOfRangeException();
            }

            Random rng = new();
            StringBuilder pw = new();
            char[] allowedChars = LowercaseLetters;

            if (caps)
                allowedChars = ConcatArrays(allowedChars, UppercaseLetters);
            if (numbers)
                allowedChars = ConcatArrays(allowedChars, Numbers);
            if (specialChars)
                allowedChars = ConcatArrays(allowedChars, SpecialChars);

            for (int i = 0; i < length; i++)
            {
                pw.Append(allowedChars[rng.Next(allowedChars.Length)]);
            }
            
            return pw.ToString();
        }

        private static char[] ConcatArrays(params char[][] arrays)
        {
            int totalLength = 0;
            foreach (char[] array in arrays)
            {
                totalLength += array.Length;
            }

            char[] result = new char[totalLength];
            int offset = 0;
            foreach (char[] array in arrays)
            {
                Array.Copy(array, 0, result, offset, array.Length);
                offset += array.Length;
            }

            return result;
        }

        public string EncryptPassword()
        {
            byte[] plainPassword = Encoding.UTF8.GetBytes(Password);
            return Convert.ToBase64String(plainPassword);
        }

        public string DecryptPassword(string encryptedPassword)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedPassword);
            return Encoding.UTF8.GetString(encryptedBytes);
        }
    }
}
