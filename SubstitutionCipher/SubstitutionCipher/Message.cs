using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SubstitutionCipher
{
    class Message
    {
        private Cipher cipher;
        public Message()
        {
            cipher = new Cipher();
        }

        public void Run()
        {
            List<string> options = new List<string>
            {
                "Encode",
                "Decode",
                "Exit"
            };

            WriteLine("Hello agent.");

            bool subcipher = true;
            while (subcipher)
            {
                int index = 0;
                string message;

                WriteLine("\nWhat would you like to do?\n");

                foreach (string option in options)
                {
                    WriteLine($"{index} - {option}");
                    index++;
                }

                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        Clear();
                        Write("Enter text: ");
                        message = ReadLine();
                        WriteLine(cipher.Encrypt(message));
                        WriteLine("Press any key to continue...");
                        ReadKey();
                        break;
                    case "1":
                        Clear();
                        Write("Enter text: ");
                        message = ReadLine();
                        WriteLine(cipher.Decrypt(message));
                        WriteLine("Press any key to continue...");
                        ReadKey();
                        break;
                    default:
                        subcipher = false;
                        break;
                }

            }

        }
    }
}
