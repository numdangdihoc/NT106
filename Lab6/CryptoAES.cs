using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class CryptoAES
    {
        public Aes aesAlg;

        public CryptoAES()
        {
            aesAlg = Aes.Create();
            aesAlg.GenerateKey();
            aesAlg.GenerateIV();
        }
        public CryptoAES(byte[] key, byte[] iv)
        {
            aesAlg = Aes.Create();
            aesAlg.Key = key;
            aesAlg.IV = iv;
        }

        public string Encrypt(string plainText)
        {
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            byte[] encryptedBytes = null;
            using (var msEncrypt = new System.IO.MemoryStream())
            {
                using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }
                    encryptedBytes = msEncrypt.ToArray();
                }
            }

            string encryptedText = Convert.ToBase64String(encryptedBytes);
            return encryptedText;
        }

        public string Decrypt(string encryptedText)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);

            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            string decryptedText = null;
            using (var msDecrypt = new System.IO.MemoryStream(encryptedBytes))
            {
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                    {
                        decryptedText = srDecrypt.ReadToEnd();
                    }
                }
            }

            return decryptedText;
        }
    }
}

