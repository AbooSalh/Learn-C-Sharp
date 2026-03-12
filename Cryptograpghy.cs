using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    internal class Cryptograpghy
    {
        public static string ReverseCipher(string message)
        {
            string translated = "";
            int i = message.Length - 1;
            while (i >= 0)
            {
                translated += message[i];
                i--;
            }
            return translated;
        }

        public static string CaesarCipher(string message, int shift)
        {
            string result = "";
            for (int i = 0; i < message.Length; i++)
            {
                {
                    char c = message[i];
                    if (char.IsLetter(c))
                    {
                        char d = char.IsUpper(c) ? 'A' : 'a';
                        result += (char)((((c + shift) - d) % 26) + d);
                    }
                    else
                    {
                        result += c;
                    }
                }
            }
            return result;
        }

        public static string XORCipher(string message, string key)
        {
            string result = "";
            for (int i = 0; i < message.Length; i++)
            {
                char c = message[i];
                char k = key[i % key.Length];
                result += (char)(c ^ k);
            }
            return result;

        }
    }
}
