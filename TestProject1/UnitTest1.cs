using MoodAnalyser;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void WhenAnalyzeMoodTest_InputAsNull_ShouldGive_Output_As_Null()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(null);
            string actual = moodAnalyzer.AnalyseMood();
            Assert.AreEqual(actual, "Happy");
        }
        [Test]
        public void WhenAnalyzeMoodTest_ShouldGive_Output_As_Sad()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am in Sad Mood");
            string actual = moodAnalyzer.AnalyseMood();
            Assert.AreEqual(actual, "Happy");
        }

        [Test]
        public void WhenAnalyzeMoodTest_ShouldGive_Output_As_Empty()
        {
            try
            {
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer("");
                string actual = moodAnalyzer.AnalyseMood();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Empty");
            }
        }
        [Test]
        public void WhenAnalyzeMoodTest_ShouldGive_Output_As_Null()
        {
            try
            {
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(null);
                string actual = moodAnalyzer.AnalyseMood();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Null");
            }
        }
    }
}