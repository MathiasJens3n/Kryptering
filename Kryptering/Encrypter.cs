using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kryptering
{
    internal class Encrypter
    {
        static string encyptedText;
        static string decryptedText;
        static char[] charArray;
        static string[] alphabet = new string[] {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
            "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Æ", "Ø" , "Å"};
        public static string Encrypt(string input)
        {
            charArray = input.ToCharArray(); 

            for (int i = 0; i < input.Length; i++)
            {
                if (charArray[i] == 'Å')
                {
                    encyptedText += alphabet[0];
                }
                else
                {
                    encyptedText += alphabet[Array.IndexOf(alphabet, charArray[i].ToString()) + 1];
                }
            }
            
            return encyptedText;
        }

        public static string Decrypt(string input)
        {

            charArray = input.ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (charArray[i] == 'A')
                {
                    decryptedText += alphabet[28];
                }
                else
                {
                    decryptedText += alphabet[Array.IndexOf(alphabet, charArray[i].ToString()) - 1];
                }
            }


            return decryptedText;
        }
    }
}
