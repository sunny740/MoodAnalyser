using MoodAnalyser;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        //UC-1
        //[Test]
        //public void GivenStringInput_WhenTestAnalyseMood_shouldReturnHappyorSad()
        //{
        //    MoodAnalyzer moodAnalyser = new MoodAnalyzer();
        //    string result = moodAnalyser.AnalyseMood("Hi!! How is Your Mood");
        //    Assert.AreEqual(result, "Happy");
        //}

        //TC-1.1
        //[Test]
        //public void GivenStringInput_WhenTestAnalyseMood_shouldReturnSAD()
        //{
        //    MoodAnalyzer moodAnalyser = new MoodAnalyzer();
        //    string result = moodAnalyser.AnalyseMood("I am in Sad Mood");
        //    Assert.AreEqual(result, "SAD");
        //}

        //TC-1.2
        //[Test]
        //public void GivenStringInput_WhenTestAnalyseMood_shouldReturnHappy()
        //{
        //    MoodAnalyzer moodAnalyser = new MoodAnalyzer();
        //    string result = moodAnalyser.AnalyseMood("I am in Any Mood");
        //    Assert.AreEqual(result, "Happy");
        //}

        //Refactor
        //[Test]
        //public void GivenStringInput_WhenTestAnalyseMood_shouldReturnSAD()
        //{
        //    MoodAnalyzer moodAnalyser = new MoodAnalyzer("Hii!! How is your Mood");
        //    string result = moodAnalyser.AnalyseMood();
        //    Assert.AreEqual(result, "Happy");
        //}

        //R(TC-1.1)
        //[Test]
        //public void GivenStringInput_WhenTestAnalyseMood_shouldReturnSAD()
        //{
        //    MoodAnalyzer moodAnalyser = new MoodAnalyzer("I am in Sad Mood");
        //    string result = moodAnalyser.AnalyseMood();
        //    Assert.AreEqual(result, "Sad");
        //}

        //R(TC-1.2)
        [Test]
        public void GivenStringInput_WhenTestAnalyseMood_shouldReturnSAD()
        {
            MoodAnalyzer moodAnalyser = new MoodAnalyzer("I am in Any Mood");
            string result = moodAnalyser.AnalyseMood();
            Assert.AreEqual(result, "Sad");
        }
    }
}