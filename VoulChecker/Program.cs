using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoulChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //1: Print the instructions
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Welcome to Voul Checker");
            Console.WriteLine("Enter a characcter to check weather it is a vowel or not?");
            Console.WriteLine("Type exit to quit the app");
            Console.WriteLine("----------------------------------------------------------");

            //2: Prompt user to enter a word
            string character = "";

            //3:Cheeck if the word == "exit"?
            while (character != "q")
            {
                //Ask user to enter a charater
                Console.WriteLine("Enter a character: ");
                character = Console.ReadLine();

                if (isVowel(character))
                {
                    Console.WriteLine(character + " is a vowel.");
                }
                else
                {
                    Console.WriteLine(character + " is not a vowel.");
                }

            }
            
        }
        static bool isVowel(string character)
        {
            string vowels = "aeiou";
            if (vowels.IndexOf(character.ToLower()) > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
