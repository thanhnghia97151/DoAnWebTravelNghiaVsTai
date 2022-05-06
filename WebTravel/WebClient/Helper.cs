using System;
using System.Security.Cryptography;
using System.Text;

namespace WebClient
{
    public class Helper
    {
        public static string RandomString(int len)
        {
            string pattern = "qwertyuiopasdfghjklzxcvbnm1234567890";
            Random random = new Random();
            char[] arr = new char[len];
            for (int i = 0; i < len; i++)
            {
                arr[i] = pattern[random.Next(pattern.Length)];

            }
            return string.Join(string.Empty, arr);
        }
        public static byte[] Hash(string plaintext)
        {
            HashAlgorithm hash = HashAlgorithm.Create("SHA-512");
            return hash.ComputeHash(Encoding.ASCII.GetBytes(plaintext));
        }
    }
}
