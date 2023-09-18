using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("mom", true)]
        [InlineData("dad", true)]
        [InlineData("taco", false)]
        [InlineData("papa", false)]

        public void IsAPalinedromeTest(string str, bool expected)
        {
            WordSmith instance = new WordSmith();
            bool actual = instance.IsAPalindrome(str);

        }  
    }
}
