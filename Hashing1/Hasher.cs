using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hashing1
{
    internal class Hasher
    {
        private static HMAC hmac;
        public Hasher(string algorithm)
        {
            switch (algorithm)
            {
                case "SHA1":
                    hmac = new HMACSHA1();
                    break;
                case "SHA256":
                    hmac = new HMACSHA256();
                    break;
                case "SHA512":
                    hmac = new HMACSHA512();
                    break;
                case "MD5":
                    hmac = new HMACMD5();
                    break;
            }
        }
        public byte[] ComputeMAC(byte[] message, byte[] key)
        {
            hmac.Key = key;

            return hmac.ComputeHash(message);
        }


    }
}
