namespace MoodAnalyser
{
    public class MoodAnalyzer
    {
        public string message;

        //public MoodAnalyzer()
        //{

        //}
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (message == null)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MOOD, "Message is Null");
                }
                if (message.Equals(""))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MOOD, "Message is Empty");

                }
                if (message.ToLower().Contains("sad"))
                {
                    return "Sad";
                }
                return "Happy";
            }
            catch (MoodAnalyserException ex)
            {
                return ex.Message;
            }
        }
    }
}