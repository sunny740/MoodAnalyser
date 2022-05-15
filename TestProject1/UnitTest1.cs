using MoodAnalyser;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void WhenAnalyzeMoodTest_ShouldGive_Output_As_Empty()
        {
            try
            {
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer("");
                string actual = moodAnalyzer.AnalyzeMood();
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
                string actual = moodAnalyzer.AnalyzeMood();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Null");
            }
        }
        [Test]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalyserObject()
        {
            object expected = new MoodAnalyzer("");
            object obj = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyzer.AnalyseMood", "AnalyseMood");
            expected.Equals(obj);
        }
        [Test]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalyserObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyzer("HAPPY");
            object obj = MoodAnalyseFactory.CreateMoodAnalyseUsingPrameterizedConstructor("MoodAnalyzer.AnalyseMood", "AnalyseMood", "HAPPY");
            expected.Equals(obj);
        }
    }
}