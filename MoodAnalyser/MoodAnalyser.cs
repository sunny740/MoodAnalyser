namespace MoodAnalyser
{
    public class MoodAnalyzer
    {
        public string message;
        //public string AnalyseMood(string message)
        //{
            //if (message.ToLower().Contains("Sad"))   //UC-1, TC-1.1, TC-1.2
            //{
            //    return "SAD";
            //}
            //else
            //{
            //    return "Happy";
            //}
            //return message;
        //}
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
                    return "Happy";
                }
                else
                {
                    return "Sad";
                }
            }
            catch(Exception)
            {
                return message;
            }
        }
    }
}