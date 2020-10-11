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
    }
}
