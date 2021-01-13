using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace PasswordManager
{
    class Crypto
    {
        private const string cryptoKey = "HmJr1tw61a92CsuGtWNcq7wJp8V3je8X4V1Jhh3fBX6=";
        private const int keySize = 256;

        //not really necessary, becaus i only use "random" numbers once, could be replaced by a normal number generator
        public static string EncryptString(string text)
        {
            if(text == null)
            {
                throw new ArgumentNullException("string is plain");
            }

            byte[] key = Convert.FromBase64String(cryptoKey);
            byte[] encrypted;

            using(RijndaelManaged riManaged = new RijndaelManaged())
            {
                riManaged.KeySize = keySize;
                riManaged.Key = key;
                riManaged.GenerateIV();
                ICryptoTransform encryptor = riManaged.CreateEncryptor(riManaged.Key, riManaged.IV);

                using(MemoryStream meStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(meStream, encryptor, CryptoStreamMode.Write))
                    {
                        using(StreamWriter streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(text);
                        }
                        encrypted = meStream.ToArray();
                    }
                }
            }

            // add all numbers of array to get number -> use as file name, cause normal encryption returns illegal signs
            string number = "";

            for (int i = 0; i < encrypted.Length; i++)
            {
                number += encrypted[i];
            }

            return number;
        }

        //public static string DecryptString(string encryptedText)
        //{
        //    if (encryptedText == null)
        //    {
        //        throw new ArgumentNullException("string is plain");
        //    }

        //    byte[] key = Convert.FromBase64String(cryptoKey);
        //    string decrypted = "";

        //    using (RijndaelManaged riManaged = new RijndaelManaged())
        //    {
        //        riManaged.KeySize = keySize;
        //        riManaged.Key = key;
        //        riManaged.GenerateIV();
        //        ICryptoTransform decryptor = riManaged.CreateDecryptor(riManaged.Key, riManaged.IV);

        //        using (MemoryStream meStream = new MemoryStream())
        //        {
        //            using (CryptoStream cryptoStream = new CryptoStream(meStream, decryptor, CryptoStreamMode.Read))
        //            {
        //                using (StreamReader streamReader = new StreamReader(cryptoStream))
        //                {
        //                    decrypted = streamReader.ReadToEnd();
        //                }
                        
        //            }
        //        }
        //    }
        //    return decrypted;
        //}
    }
}
