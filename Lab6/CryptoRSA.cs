using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class CryptoRSA
    {
        private RSACryptoServiceProvider RSA;
        public string PublicKey;
        public string PrivateKey;

        public CryptoRSA()
        {
            CspParameters cspParams = new CspParameters();
            cspParams.Flags = CspProviderFlags.UseMachineKeyStore;
            RSA = new RSACryptoServiceProvider(cspParams);
            PublicKey = RSA.ToXmlString(false);
            PrivateKey = RSA.ToXmlString(true);
        }

        public byte[] Encrypt(byte[] Data, string PublicKeyIn)
        {
            RSA.FromXmlString(PublicKeyIn);
            return RSA.Encrypt(Data, false);
        }

        public byte[] Decrypt(byte[] Data, string PrivateKeyIn)
        {
            RSA.FromXmlString(PrivateKeyIn);
            return RSA.Decrypt(Data, false);
        }
    }
}
