using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GGProductions.LetterStorm.Data.Collections;
using GGProductions.LetterStorm.Data;

namespace Test.GGProductions.LetterStorm.Data.Collections
{
    [TestClass]
    public class WordSetTests
    {
        [TestMethod]
        public void GetNextWordTest()
        {
            // Create a word set with 3 words
            WordSet wordSet = new WordSet();
            wordSet.Add(new Word("text1", "hint1"));
            wordSet.Add(new Word("text3", "hint2"));
            wordSet.Add(new Word("text2", "hint3"));

            // Verify the three words are returned in alphabetical order
            Assert.AreEqual("text1", wordSet.GetNextWord().Text, false);
            Assert.AreEqual("text2", wordSet.GetNextWord().Text, false);
            Assert.AreEqual("text3", wordSet.GetNextWord().Text, false);
        }

        [TestMethod]
        public void GetRandomWordTest()
        {
            /* TEST 1 */
            // Create a word set with 4 words
            WordSet wordSet = new WordSet();
            wordSet.Add(new Word("text1", "hint1"));
            wordSet.Add(new Word("text2", "hint2"));
            wordSet.Add(new Word("textaa", "hintaa"));
            wordSet.Add(new Word("textbb", "hintbb"));

            Boolean testPassed = false;

            // Retrieve the words randomly
            String[] wordTexts = new String[] { wordSet.GetRandomWord().Text, 
                wordSet.GetRandomWord().Text, wordSet.GetRandomWord().Text, 
                wordSet.GetRandomWord().Text};

            // Verify the three words are returned in pseudo-random order
            if((wordTexts[0].Equals("text1") && wordTexts[1].Equals("text2")) ||
                (wordTexts[0].Equals("text2") && wordTexts[1].Equals("text1")))
            {
                if((wordTexts[2].Equals("textaa") && wordTexts[3].Equals("textbb")) ||
                (wordTexts[2].Equals("textbb") && wordTexts[3].Equals("textaa")))
                {
                    testPassed = true;
                }
            }
            Assert.AreEqual(testPassed, true);

            /* Test 2 */
            // Create a word set with 4 words
            WordSet wordSet2 = new WordSet();
            wordSet2.Add(new Word("cat", "hint1"));
            wordSet2.Add(new Word("dog", "hint2"));
            wordSet2.Add(new Word("fish", "hintaa"));
            wordSet2.Add(new Word("horse", "hintbb"));

            Boolean testPassed2 = false;

            // Retrieve the words randomly
            String[] wordTexts2 = new String[] { wordSet2.GetRandomWord().Text, 
                wordSet2.GetRandomWord().Text, wordSet2.GetRandomWord().Text, 
                wordSet2.GetRandomWord().Text};

            // Verify the three words were returned in pseudo-random order
            if ((wordTexts2[0].Equals("cat") && wordTexts2[1].Equals("dog")) ||
                (wordTexts2[0].Equals("dog") && wordTexts2[1].Equals("cat")))
            {
                if (wordTexts2[2].Equals("fish") && wordTexts2[3].Equals("horse"))
                {
                    testPassed2 = true;
                }
            }
            Assert.AreEqual(testPassed2, true);
        }
    }
}
