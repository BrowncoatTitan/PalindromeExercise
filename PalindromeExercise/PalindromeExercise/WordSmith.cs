using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
           string word1 = string.Empty;
           for (int i = word.Length - 1; i >= 0; i--)
            {
                word1 += word[i];
            }
            if (word == word1) return true;
            return false;
        }
    
    }

}
