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

            using (Aes advEncrStandard = Aes.Create())
            {
                advEncrStandard.Key = key;
                advEncrStandard.GenerateIV();

                using (ICryptoTransform encryptor = advEncrStandard.CreateEncryptor(advEncrStandard.Key, advEncrStandard.IV))
                {
                    using (MemoryStream msEncrypt = new())
                    {
                        using (CryptoStream csEncrypt = new(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new(csEncrypt))
                            {
                                swEncrypt.Write(password);
                                swEncrypt.Close();
                            }

                            csEncrypt.Close();
                        }

                        byte[] encryptedBytes = msEncrypt.ToArray();
                        string encryptedPassword = BitConverter.ToString(encryptedBytes).Replace("-", "");
                        msEncrypt.Close();
                        encryptor.Dispose();
                        advEncrStandard.Dispose();

                        return encryptedPassword;
                    }
                }
            }
        }

        private byte[] StringtoByteArray(string hex)
        {
            int numChars = hex.Length;
            byte[] bytes = new byte[numChars / 2];

            for (int i = 0; i < numChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }

            return bytes;
        }

        public string DecryptPassword(string username)
        {
            byte[] key = GetKey(username);
            string decryptedPassword = "";

            using (Aes advEncrStandard = Aes.Create())
            {
                advEncrStandard.Key = key;

                byte[] encryptedBytes = StringtoByteArray(Password);
                byte[] iv = encryptedBytes.Take(16).ToArray();
                byte[] encryptedData = encryptedBytes.Skip(16).ToArray();
                
                using (ICryptoTransform decryptor = advEncrStandard.CreateDecryptor(advEncrStandard.Key, iv))
                {
                    using (MemoryStream msDecrypt = new(encryptedData))
                    {
                        using (CryptoStream csDecrypt = new(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new(csDecrypt))
                            {
                                decryptedPassword = srDecrypt.ReadToEnd();
                                srDecrypt.Close();
                            }
                            
                            csDecrypt.Close();
                        }
                        msDecrypt.Close();
                    }
                    decryptor.Dispose();
                }
                advEncrStandard.Dispose();
            }

            return decryptedPassword;
        }
    }
}
