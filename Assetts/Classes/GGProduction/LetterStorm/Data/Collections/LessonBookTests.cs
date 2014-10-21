using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GGProductions.LetterStorm.Data.Collections;

namespace Test.GGProductions.LetterStorm.Data.Collections
{
    [TestClass]
    public class LessonBookTests
    {
        [TestMethod]
        public void CreateSampleLessonTest()
        {
            // Create a lesson book with a sample lesson
            LessonBook lessonBook = new LessonBook();
            lessonBook.CreateSampleLessons();

            // Verify a lesson was created and that it has the correct name
            Assert.AreEqual(5, lessonBook.Lessons.Count);
            Assert.AreEqual("K5 Sample", lessonBook.Lessons[0].Name);

            // Verify the lesson's words were created
            Assert.AreEqual(5, lessonBook.Lessons[0].Words.Count);
            Assert.AreEqual("cat", lessonBook.Lessons[0].Words[0].Text);
            Assert.AreEqual("dog", lessonBook.Lessons[0].Words[1].Text);
            Assert.AreEqual("bug", lessonBook.Lessons[0].Words[2].Text);
            Assert.AreEqual("fish", lessonBook.Lessons[0].Words[3].Text);
            Assert.AreEqual("horse", lessonBook.Lessons[0].Words[4].Text);
        }
    }
}
