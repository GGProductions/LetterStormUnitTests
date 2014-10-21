using GGProductions.LetterStorm.Data.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.GGProductions.LetterStorm.Data.Collections
{
    [TestClass]
    public class LessonCollectionTests
    {
        [TestMethod]
        public void GetLessonByIdTest()
        {
            // Create a new lesson collection and three lessons
            LessonCollection lessonCollection = new LessonCollection();
            Lesson testLesson1 = new Lesson("testLesson1");
            Lesson testLesson2 = new Lesson("testLesson2");
            Lesson testLesson3 = new Lesson("testLesson3");
            
            // Add the lessons to the lesson collection
            lessonCollection.Add(testLesson1);
            lessonCollection.Add(testLesson2);
            lessonCollection.Add(testLesson3);

            // Verify the three lessons can be retrieved by their IDs
            Assert.AreEqual(testLesson3.Name, lessonCollection.GetLessonById(testLesson3.ID).Name);
            Assert.AreEqual(testLesson2.Name, lessonCollection.GetLessonById(testLesson2.ID).Name);
            Assert.AreEqual(testLesson1.Name, lessonCollection.GetLessonById(testLesson1.ID).Name);
        }
    }
}
