using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    /*
    * A palindrome is a collection of alphabetical of characters that reads the same backward or forward.
    * Write a function that checks if a given word is a palindrome.
    *
    * Character case should be ignored.
    * Only alphabetic characters should be included in the evaluation
    *
    */

    public class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            for (var i = 0; i < word.Length / 2; i++)
            {
                if ((Char.ToLower(word[i]) != Char.ToLower(word[word.Length - 1 - i])))
                    return false;
            }
            return true;
        }

        public static bool IsPalindromeSlow(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return (new string(charArray).ToLower() == word.ToLower()) ? true : false;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Palindrome.IsPalindrome("eaae"));
            Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
            Console.WriteLine(Palindrome.IsPalindrome("KAYAK"));
            Console.WriteLine(Palindrome.IsPalindrome("Never a foot too far, even."));
            Console.ReadKey();
        }
    }
}
