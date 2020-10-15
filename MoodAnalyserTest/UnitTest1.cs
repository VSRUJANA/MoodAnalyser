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

        [TestMethod]
        public void Given_MoodAnalyserClassName_Should_ReturnMoodAnalyserObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object actual = MoodAnalyserFactory.MoodAnalyseObjectCreation("MoodAnalyserApp.MoodAnalyser", "MoodAnalyser");
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod]
        public void Given_ImproperClassName_Should_Throw_MoodAnalysisException_NO_SUCH_CLASS()
        {
            try
            {
                object expected = new MoodAnalyser();
                object actual = MoodAnalyserFactory.MoodAnalyseObjectCreation("WrongClass", "MoodAnalyser");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("No such class found", e.Message);
            }
        }

        [TestMethod]
        public void Given_ImproperConstructorName_Should_Throw_MoodAnalysisException_NO_SUCH_METHOD()
        {
            try
            {
                object expected = new MoodAnalyser();
                object actual = MoodAnalyserFactory.MoodAnalyseObjectCreation("WrongConstructor", "WrongConstructor");
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("No such Constructor found", e.Message);
            }
        }
    }
}


