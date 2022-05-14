namespace MoodAnalyser
{
    public class MoodAnalyzer
    {
        public string message;
        public MoodAnalyzer(string message)   //Refactor
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (message.ToLower().Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
                return message;
            }
            catch(Exception)
            {
                return "Happy";
            }
        }
    }
}