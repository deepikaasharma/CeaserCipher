using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeaserCipher
{
    class Program
    {  
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a string to encrypt:"); 
             String Userstring= Console.ReadLine(); // user enters the string
            Console.WriteLine();

            Console.WriteLine("Enter Your Key please");
            int Key = Convert.ToInt32(Console.ReadLine()); // user enters the key 
            Console.WriteLine();

            Console.WriteLine("Encrypted Data:");
            string cipheredstring = Encipher(Userstring, Key); //call on encipher method using the user-input "Userstring and Key". 
            Console.WriteLine(cipheredstring); // writes the ciphered string out on console
            Console.WriteLine();

            //Console.WriteLine("Enter your encrypted code");
            //String encryptedText= Console.ReadLine(); // lets the user enter their own encrypted code 
            //Console.WriteLine();

            Console.WriteLine("Decrypted Code:");
            String decryptedText = Decipher(cipheredstring, Key); // calls on the Decipher method
            Console.WriteLine(decryptedText); // writes the decrypted string out on the console 
            Console.WriteLine();


        }

        static char Cipher (char character, int key)

        { if (!char.IsLetter(character))
            {
                return character; 
            }
            char d = char.IsUpper(character) ? 'A' : 'a';

            return (char)((((character + key)-d) % 26)+d);
        }

        private static string Encipher(string input, int key)
        {
            string output = " ";

            foreach (char character in input)
            { output += Cipher(character, key); }
            
            return output;

        }

        private static string Decipher(string input, int key)
        {
            return (string)Encipher(input, 26 - key);  //decrypts the encrypted ciphered string to a simple string but I don't understand this stupid formula.

        }


    }
}
