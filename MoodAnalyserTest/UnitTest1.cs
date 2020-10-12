using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserApp;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_Sad_MoodAnalyser_Should_Return_Sad()
        {
            //Arrange
            MoodAnalyser moodAnalyse = new MoodAnalyser("I am in a Sad mood");
            //Act
            string mood = moodAnalyse.AnalyseMood();
            //Assert
            Assert.AreEqual("SAD", mood);
        }
        [TestMethod]
        public void Given_Happy_MoodAnalyser_Should_Return_Happy()
        {
            //Arrange
            MoodAnalyser moodAnalyse = new MoodAnalyser("I am in a Happy mood");
            //Act
            string mood = moodAnalyse.AnalyseMood();
            //Assert
            Assert.AreEqual("HAPPY", mood);
        }
        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMood()
        {
            try
            {
                string message = string.Empty;
                MoodAnalyser moodAnalyse = new MoodAnalyser(message);
                string moodStr = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_Mood_Should_Throw_MoodAnalysisException_Indicating_NullMood()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyse = new MoodAnalyser(message);
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }
    }
}

