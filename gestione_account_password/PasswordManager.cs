using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace gestione_account_password
{
    public class PasswordManager
    {
        private static readonly char[] _lowercaseLetters =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        private static readonly char[] _uppercaseLetters =
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        private static readonly char[] _numbers =
        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
        };

        private static readonly char[] _specialChars =
        {
            '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '+', '=', '{', '}', '[', ']', '|', '\\', ':', ';', '"', '\'', '<', '>', ',', '.', '?', '/'
        };

        private string _password;

        public static char[] LowercaseLetters
        {
            get => _lowercaseLetters;
        }

        public static char[] UppercaseLetters
        {
            get => _uppercaseLetters;
        }

        public static char[] Numbers
        {
            get => _numbers;
        }

        public static char[] SpecialChars
        {
            get => _specialChars;
        }

        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public PasswordManager()
        {
            Password = "default";
        }

        public PasswordManager(int length, bool caps, bool numbers, bool specialChars, string username)
        {
            Password = PasswordGenerator(length, caps, numbers, specialChars, username);
        }

        public PasswordManager(string password, string username)
        {
            Password = EncryptPassword(password, username);
        }

        public PasswordManager(string encryptedPassword)
        {
            Password = encryptedPassword;
        }

        public string PasswordGenerator(int length, bool caps, bool numbers, bool specialChars, string username)
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

            string encryptedPassword = EncryptPassword(pw.ToString(), username);
            return encryptedPassword;
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

        private byte[] GetKey(string username)
        {
            string keyString = username;
            byte[] key = Encoding.UTF8.GetBytes(keyString);

            while (key.Length < 32)
            {
                key = key.Concat(Encoding.UTF8.GetBytes(keyString)).ToArray();
            }

            if (key.Length > 32)
            {
                key = key.Take(32).ToArray();
            }

            return key;
        }

        public string EncryptPassword(string password, string username)
        {
            byte[] key = GetKey(username);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.GenerateIV();

                byte[] iv = aesAlg.IV;

                using (ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV))
                {
                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                swEncrypt.Write(password);
                            }
                        }

                        byte[] encrypted = msEncrypt.ToArray();
                        string encryptedPassword = Convert.ToBase64String(encrypted);
                        string ivString = Convert.ToBase64String(iv);

                        return $"{encryptedPassword}-{ivString}";
                    }
                }
            }
        }

        public string DecryptPassword(string username)
        {
            byte[] key = GetKey(username);

            // Split the encrypted password and IV
            string[] parts = Password.Split('-');
            if (parts.Length != 2)
            {
                throw new ArgumentException("The input string is not in the correct format.");
            }

            string encryptedPassword = parts[0];
            string ivString = parts[1];

            byte[] iv = Convert.FromBase64String(ivString);
            byte[] cipherText = Convert.FromBase64String(encryptedPassword);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                using (ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV))
                {
                    using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                return srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
            }
        }
    }
}