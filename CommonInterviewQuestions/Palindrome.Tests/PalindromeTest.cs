using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindrome.Tests
{
    [TestClass]
    public class PalindromeTest
    {

        [TestMethod]
        public void PalindromeKayak()
        {
            string givenResult = "kayak";

            var result = Palindrome.CheckAndGivePalindrome("kayak");

            Assert.AreEqual(givenResult, result);
        }

        [TestMethod]
        public void FalsyPalindromeMathijs()
        {
            var result = Palindrome.CheckAndGivePalindrome("Mathijs");

            Assert.IsNull(result);
        }
        
        [TestMethod]
        public void IsPalindromeLol()
        {
            var result = Palindrome.IsPalindromeSingleLine("lol");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LongestPalindrome12345432()
        {
            string givenResult = "01234543210";
            string input = "wowjezuslegovogel01234543210";
            

            var result = Palindrome.LongestPalindrome(input);

            Assert.AreEqual(givenResult, result);
        }

        [TestMethod]
        public void LongestPalindromeSh12345432()
        {
            string givenResult = "01234543210";
            string input = "wowjezuslegovogel01234543210";


            var result = Palindrome.LongestPalindromeSh(input);

            Assert.AreEqual(givenResult, result);
        }
    }
}
