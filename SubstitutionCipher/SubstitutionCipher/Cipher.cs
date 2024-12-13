using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstitutionCipher
{
    class Cipher
    {
        string alphabet;
        string substitute;

        public Cipher()
        {
            alphabet = "abcdefghijklmnopqrstuvwxyz ";
            substitute = "opdefghiqr sxyzabcjklmntuvw";
        }

        public string Encrypt(string _message)
        {
            int index;
            char replacement = 'z';
            string result = "";
            _message = _message.ToLower();

            foreach (char c in _message)
            {
                //add code here to replace each character c
                index = alphabet.IndexOf(c);
                replacement = substitute[index];
                //with the letter from the same index number in the substitute string
                result += replacement;
            }

            return result;
        }

        public string Decrypt(string _message)
        {
            string result = "";
            int index;
            char replacement = 'a';
            _message = _message.ToLower();
            foreach (char c in _message)
            {
                index = substitute.IndexOf(c);
                replacement = alphabet[index];
                result += replacement;
            }
            return result;
        }
    }
}
