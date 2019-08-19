using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1: Print the instructions
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Welcome to Palindrome Checker");
            Console.WriteLine("Enter a woird to check weather it is a palindrome or not?");
            Console.WriteLine("Type exit to quit the app");
            Console.WriteLine("----------------------------------------------------------");

            //2: Prompt user to enter a word
            string word = "";

            //3:Cheeck if the word == "exit"?
            while (word != "exit")
            {
                //Ask user to enter a word
                Console.WriteLine(" Enter a word: ");
                word = Console.ReadLine();

                //4: Reverse the word ans store it in "reversedWord" --> method
                //Call to exicure the reverseWord method
                string reversedword = reverseWord(word);

                //5: Check if the word == reverseWord?
                if(word == reversedword)
                {
                    //6a: If yes, print out "It is a palindore"
                    Console.WriteLine(word + " is a palindrome.");
                }
                else
                {
                    Console.WriteLine(word + " is not a palindrome.");
                }

                //6b: if no, print out "It is not a palindrome"
            }
        }

        //Create a method called "reverseWord"
        static string reverseWord(string word)
        {
            string reverseWord = "";
            //Word = "hello -> reverseword "olleh"
            //build the word reverser
            for (int i = word.Length - 1; i >= 0; i --)
            {
                reverseWord += word[i];
            }
            return reverseWord;
        }

    }
}
