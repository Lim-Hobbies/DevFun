using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

namespace StringLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStartWithUpper(){
            // Test that we expect to return true.
            string[] words = {"Alphabet", "Zebra", "ABC", "Aปกva","Mockิฟ"};
            foreach (var word in words) {
                bool result = word.StartsWithUpper();
                Assert.IsTrue(result,
                    String.Format("Expected for '{0}': true; Actual: {1}", 
                    words, result));
            }
        }

        [TestMethod]
        public void TestDoesNotStartWithUpper() {
            // Test that we expect to return false.
            string[] words = {"alphabet", "zebra", "abc", "aกขคbc", "rstกากาก",
                              "1234", ".", ";", " " };
            foreach( var word in words) {
                bool result = word.StartsWithUpper();
                Assert.IsFalse(result,
                    String.Format("Expected for '{0}': false; Actual: {1}",
                    words, result));
            }
        }

        [TestMethod]
        public void DirectCallWithNullOrEmpty() {
            // Test that we expect to return false.
            string[] words = { string.Empty, null };
            foreach (var word in words) {
                bool result = StringLibrary.StartsWithUpper(word);
                Assert.IsFalse(result,
                    String.Format("Expected for '{0}': false; Actual: {1}",
                    words, result));
            }
        }
    }
}
