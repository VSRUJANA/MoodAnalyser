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
            string message = "I am in a Sad mood";
            MoodAnalyser moodAnalyse = new MoodAnalyser();
            //Act
            string mood = moodAnalyse.AnalyseMood(message);
            //Assert
            Assert.AreEqual("SAD", mood);
        }
        [TestMethod]
        public void Given_Happy_MoodAnalyser_Should_Return_Happy()
        {
            //Arrange
            string message = "I am in a Happy mood";
            MoodAnalyser moodAnalyse = new MoodAnalyser();
            //Act
            string mood = moodAnalyse.AnalyseMood(message);
            //Assert
            Assert.AreEqual("HAPPY", mood);
        }
    }
}
