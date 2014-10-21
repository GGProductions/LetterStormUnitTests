using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GGProductions.LetterStorm.Data;
using System.Collections.Generic;

namespace Test.GGProductions.LetterStorm.Data
{
    [TestClass]
    public class WordTests
    {
        [TestMethod]
        public void WordTest()
        {
            // Create a word using the empty constructor
            Word word0 = new Word();

            // Test the word's default values
            Assert.AreEqual(null, word0.Text);
            Assert.AreEqual(null, word0.Hint);
            Assert.AreEqual(false, word0.Tested);

            // Create a word using the empty constructor and explicitly assign values
            Word word1 = new Word();
            word1.Text = "cat";
            word1.Hint = "hint";
            word1.Tested = true;

            // Test that the assigned values were stored correctly
            Assert.AreEqual("cat", word1.Text);
            Assert.AreEqual("hint", word1.Hint);
            Assert.AreEqual(true, word1.Tested);

            // Create a word using the text-only constructor
            Word word2 = new Word("dog");

            // Test the word's text and default values
            Assert.AreEqual("dog", word2.Text);
            Assert.AreEqual(String.Empty, word2.Hint);
            Assert.AreEqual(false, word2.Tested);

            // Create a word using the text-and-hint constructor
            Word word3 = new Word("fish", "hint");

            // Test the word's text, hint, and default values
            Assert.AreEqual("fish", word3.Text);
            Assert.AreEqual("hint", word3.Hint);
            Assert.AreEqual(false, word3.Tested);
        }

        [TestMethod]
        public void ToStringTest()
        {
            // Create a word with a text and hint
            Word word1 = new Word("cat", "hint");

            // Test that the word converted to a string properly
            Assert.AreEqual("cat||hint", word1.ToString());
        }

        [TestMethod]
        public void CompareToTest()
        {
            // Create three words
            Word word1 = new Word("dog", "hint");
            Word word2 = new Word("fish", "hint1");
            Word word3 = new Word("fish", "hint2");

            // Add the three words to a list
            List<Word> testList = new List<Word>();
            testList.Add(word1);
            testList.Add(word2);
            testList.Add(word3);

            // Sort the list in ascending order.  This will call the words' CompareTo function.
            testList.Sort();

            // Verify the words were sorted in the correct order (ie that the CompareTo function worked properly)
            Assert.AreEqual("dog", testList[0].Text);
            Assert.AreEqual("fish", testList[1].Text);
            Assert.AreEqual("fish", testList[2].Text);        
        }
    }
}
