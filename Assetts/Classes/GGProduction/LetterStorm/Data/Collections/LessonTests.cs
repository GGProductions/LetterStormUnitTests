using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GGProductions.LetterStorm.Data.Collections;

namespace Test.GGProductions.LetterStorm.Data.Collections
{
    [TestClass]
    public class LessonTests
    {
        [TestMethod]
        public void LessonTest()
        {
            // Create a new lesson using the constructor that accepts the lesson's name
            Lesson lesson = new Lesson("Test Lesson");

            // Test to see if the name was assigned properly
            Assert.AreEqual("Test Lesson", lesson.Name);
        }
    }
}
